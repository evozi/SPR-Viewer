using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using SPR_Viewer.Utils;

namespace SPR_Viewer
{
    public partial class Main : Form
    {
        private readonly Dictionary<int, Format> ColorFomat3D3 = new Dictionary<int, Format>();
        private readonly Dictionary<int, PixelFormat> ColorPixel = new Dictionary<int, PixelFormat>();

        private Device m_Device;

        public int ReadSizeType = 0x80;
        private string Sname = string.Empty;
        private readonly List<SprFileData> SprList = new List<SprFileData>();

        public Main()
        {
            InitializeComponent();
            var node = new TreeNode();
            node.Name = "mainNode";
            node.Text = "SPR Images";
            treeView1.Nodes.Add(node);

            label1.Text = "Index (Hex)";
            label2.Text = "Loop Count1";
            label3.Text = "Loop Count2";
            label4.Text = "Unknown - var 4";
            label5.Text = "Color Type";
            label6.Text = "Text Blend";
            label7.Text = "File Type";
            label8.Text = "RGB Value";
            label9.Text = "Width";
            label10.Text = "Height";
            label11.Text = "NumPixels";
            ColorPixel.Add(3, PixelFormat.Format16bppArgb1555);
            ColorPixel.Add(4, PixelFormat.Format32bppArgb);
            ColorFomat3D3.Add(3, Format.A1R5G5B5);
            ColorFomat3D3.Add(4, Format.A8R8G8B8);
            ColorFomat3D3.Add(5, Format.A4R4G4B4);
            ColorFomat3D3.Add(6, Format.Dxt1);
            ColorFomat3D3.Add(7, Format.Dxt2);
            ColorFomat3D3.Add(8, Format.Dxt3);
            ColorFomat3D3.Add(9, Format.Dxt4);
        }

        private void CreateBitmap(int w, int h, byte[] data, PixelFormat Format)
        {
            var bitmap = new Bitmap(w, h, Format);
            var bitmapdata = bitmap.LockBits(new Rectangle(new Point(), bitmap.Size), ImageLockMode.ReadOnly, Format);
            var length = bitmapdata.Stride * bitmap.Height;
            Marshal.Copy(data, 0, bitmapdata.Scan0, length);
            bitmap.UnlockBits(bitmapdata);
            pictureBox1.Image = bitmap;
        }

        private void InitializeDevice()
        {
            var parameters = new PresentParameters();
            parameters.Windowed = true;
            parameters.SwapEffect = SwapEffect.Discard;
            m_Device = new Device(0, DeviceType.Hardware, pictureBox1.Handle, CreateFlags.SoftwareVertexProcessing,
                parameters);
            m_Device.RenderState.CullMode = Cull.None;
            m_Device.RenderState.Lighting = false;
            m_Device.Transform.Projection = Matrix.PerspectiveFovLH(0.7853982f, 1.333333f, 1f, 1000f);
            m_Device.Transform.View = Matrix.LookAtLH(new Vector3(0f, 10f, -20f), new Vector3(0f, 0f, 0f),
                new Vector3(0f, 1f, 0f));
            m_Device.VertexFormat = VertexFormats.Diffuse | VertexFormats.Position;
            m_Device.RenderState.ZBufferEnable = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (m_Device == null) InitializeDevice();
            m_Device.Clear(ClearFlags.Target, Color.Black, 1f, 0);
            m_Device.BeginScene();
            m_Device.EndScene();
        }

        private void ParseSprFile(string fileName, int fileType)
        {
            var num = 1;
            var header = new SprFileHeader();
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var reader = new BinaryReader(stream);
                try
                {
                    if (fileType == 1)
                    {
                        var count = 0;
                        num = reader.ReadInt32();
                        count = num * 8;
                        reader.ReadBytes(count);
                    }

                    while (num > 0)
                    {
                        if(fileType == 1)
                        {
                            reader.ReadInt32();
                            header.ItemIDCount = reader.ReadInt32();
                            for (int x = 0; x < header.ItemIDCount; x++)
                            {
                                header.ItemID = reader.ReadInt32();
                            }
                        }
                        header.FirstRead = reader.ReadBytes(ReadSizeType);
                        header.SecondRead = reader.ReadBytes(ReadSizeType);
                        header.ImgCount = reader.ReadInt32();
                        for (var j = header.ImgCount; j > 0; j--)
                        {
                            var item = new SprFileData();
                            item.var1 = reader.ReadInt32();
                            item.LoopCount1 = reader.ReadInt32();
                            if (item.LoopCount1 > 0)
                                for (var k = 0; k < item.LoopCount1; k++)
                                {
                                    item.LoopVars1.Add(reader.ReadInt32());
                                    item.LoopVars1.Add(reader.ReadInt32());
                                    item.LoopVars1.Add(reader.ReadInt32());
                                    item.LoopVars1.Add(reader.ReadInt32());
                                }

                            item.LoopCount2 = reader.ReadInt32();
                            if (item.LoopCount2 > 0)
                                for (var m = 0; m < item.LoopCount2; m++)
                                {
                                    item.LoopVars2.Add(reader.ReadInt32());
                                    item.LoopVars2.Add(reader.ReadInt32());
                                    item.LoopVars2.Add(reader.ReadInt32());
                                    item.LoopVars2.Add(reader.ReadInt32());
                                }

                            item.var4 = reader.ReadByte();
                            item.ColorType = reader.ReadInt32();
                            item.TexBlendType = reader.ReadInt32();
                            item.m_FileType = reader.ReadInt32();
                            item.SearchColor = reader.ReadBytes(3);
                            item.Width = reader.ReadInt32();
                            item.Height = reader.ReadInt32();
                            item.NumPixels = reader.ReadInt32();
                            var num6 = 0;
                            switch (item.ColorType)
                            {
                                case 3:
                                    num6 = item.NumPixels << 1;
                                    break;

                                case 4:
                                    num6 = item.NumPixels << 2;
                                    break;
                            }

                            item.ImageData = new byte[num6];
                            item.DataOffset = reader.BaseStream.Position;
                            item.ImageData = reader.ReadBytes(num6);
                            SprList.Add(item);
                        }

                        num--;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }
                catch (EndOfStreamException)
                {
                    reader.Close();
                }
                finally
                {
                    if (reader != null) ((IDisposable) reader).Dispose();
                }

                stream.Close();
            }

            var index = 0;
            index = 0;
            while (index < 0x80)
            {
                if (header.FirstRead[index] == 0) break;
                index++;
            }

            var encoding = Encoding.GetEncoding("euc-kr");
            var str = encoding.GetString(header.FirstRead, 0, index);
            header.SprFileName = str;
            str = "";
            index = 0;
            while (index < 0x80)
            {
                if (header.SecondRead[index] == 0) break;
                index++;
            }

            str = encoding.GetString(header.SecondRead, 0, index);
            header.SprDescrption = str;
            textBox1.Text = header.SprFileName;
            textBox2.Text = header.SprDescrption;
            for (var i = 0; i < SprList.Count; i++)
            {
                var num10 = i + 1;
                treeView1.Nodes["mainNode"].Nodes.Add(i.ToString(), "Image : " + num10);
                treeView1.Nodes["mainNode"].Nodes[i.ToString()].Tag = "1";
            }
        }

        private void saveImageFile(string type)
        {
            if (type == "dds")
                saveFileDialog1.Filter = "DDS .dds|*.dds";
            else
                saveFileDialog1.Filter = "PNG .png|*.png";

            try
            {
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                if (!string.IsNullOrEmpty(saveFileDialog1.FileName) && treeView1 != null &&
                    treeView1.SelectedNode != null)
                {
                    var fileName = saveFileDialog1.FileName;
                    var data = new SprFileData();
                    data = SprList[int.Parse(treeView1.SelectedNode.Name)];
                    var surface = m_Device.GetBackBuffer(0, 0, BackBufferType.Mono);
                    surface.Device.CreateOffscreenPlainSurface((short) data.Width, (short) data.Height,
                        ColorFomat3D3[data.ColorType], Pool.Default);
                    var srcTexture = new Texture(surface.Device, (short) data.Width, (short) data.Height, 1, Usage.None,
                        ColorFomat3D3[data.ColorType], Pool.Managed);
                    var stream = srcTexture.LockRectangle(0, LockFlags.None);
                    if (stream.CanWrite) stream.Write(data.ImageData, 0, data.ImageData.Length);
                    srcTexture.UnlockRectangle(0);
                    stream.Dispose();

                    if (type == "dds")
                        TextureLoader.Save(fileName, ImageFileFormat.Dds, srcTexture);
                    else
                        TextureLoader.Save(fileName, ImageFileFormat.Png, srcTexture);

                    srcTexture.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonOpenSpr_Click(object sender, EventArgs e)
        {
            treeView1.Nodes["mainNode"].Nodes.Clear();
            SprList.Clear();
            openFileDialog1.Filter = "SPR File .spr|*.spr";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                var fileName = openFileDialog1.FileName;
                Sname = openFileDialog1.SafeFileName;
                ParseSprFile(fileName, 0);

                treeView1.ExpandAll();
            }
        }


        private void buttonAuto_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = "Select the folder that contain .spr files";
            dialog.ShowDialog();
            var selectedPath = dialog.SelectedPath;

            if (string.IsNullOrEmpty(selectedPath)) return;

            var info = new DirectoryInfo(selectedPath);
            var currentDirectory = Directory.GetCurrentDirectory();
            var savingDirectory = currentDirectory + @"\SprImages\";

            if (info.GetFiles("*.spr").Length <= 0)
            {
                MessageBox.Show("No .spr files found");
                return;
            }

            if (Directory.CreateDirectory(savingDirectory).Exists)
            {
                Process.Start(savingDirectory);
            }
           
            foreach (var info2 in info.GetFiles("*.spr"))
            {
                var flag = true;
                if (info2.Name == "Dialog_Group.spr") flag = false;
                if (info2.Name == "Dialog_Map.spr") flag = false;
                if (flag)
                {
                    Sname = info2.Name;
                    ParseSprFile(info2.Directory + @"\" + info2.Name, 0);

                    Directory.CreateDirectory(savingDirectory + info2.Name);
                    for (var i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
                    {
                        treeView1.SelectedNode = treeView1.Nodes[0].Nodes[i];
                        treeView1.Select();

                        var data = new SprFileData();
                        data = SprList[int.Parse(treeView1.SelectedNode.Name)];
                        var surface = m_Device.GetBackBuffer(0, 0, BackBufferType.Mono);
                        surface.Device.CreateOffscreenPlainSurface((short) data.Width, (short) data.Height,
                            ColorFomat3D3[data.ColorType], Pool.Default);
                        var srcTexture = new Texture(surface.Device, (short) data.Width, (short) data.Height, 1,
                            Usage.None, ColorFomat3D3[data.ColorType], Pool.Managed);
                        var stream = srcTexture.LockRectangle(0, LockFlags.None);
                        if (stream.CanWrite) stream.Write(data.ImageData, 0, data.ImageData.Length);
                        srcTexture.UnlockRectangle(0);

                        surface.Dispose();
                        stream.Dispose();

                        if (radioButtonDds.Checked)
                            TextureLoader.Save(
                                savingDirectory + info2.Name + @"\" + treeView1.SelectedNode.Name +
                                ".dds",
                                ImageFileFormat.Dds, srcTexture);
                        else
                            TextureLoader.Save(
                                savingDirectory + info2.Name + @"\" + treeView1.SelectedNode.Name +
                                ".png",
                                ImageFileFormat.Png, srcTexture);


                        srcTexture.Dispose();

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }

                treeView1.Nodes["mainNode"].Nodes.Clear();
                SprList.Clear();
            }

            MessageBox.Show("Completed, extracted to:\n" + savingDirectory);
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (radioButtonDds.Checked)
                saveImageFile("dds");
            else
                saveImageFile("png");
        }

        private void buttonCopyByte_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) Clipboard.SetImage(pictureBox1.Image);
        }

        private void checkBoxMGO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMGO.Checked) ReadSizeType = 0x100;
            if (!checkBoxMGO.Checked) ReadSizeType = 0x80;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((string) e.Node.Tag == "1")
            {
                var data = new SprFileData();
                data = SprList[int.Parse(e.Node.Name)];
                textBox3.Text = data.var1.ToString("X");
                textBox4.Text = data.LoopCount1.ToString("X");
                textBox5.Text = data.LoopCount2.ToString("X");
                textBox6.Text = data.var4.ToString("X");
                textBox7.Text = "(" + data.ColorType.ToString("X") + ")-> " +
                                Enum.GetName(typeof(Format), ColorFomat3D3[data.ColorType]);
                textBox8.Text = data.TexBlendType.ToString("X");
                textBox9.Text = "(" + data.m_FileType.ToString("X") + ")-> " +
                                Enum.GetName(typeof(D3DIMAGE_FILEFORMAT), data.m_FileType);
                textBox10.Text = data.SearchColor[0].ToString("X2") + data.SearchColor[1].ToString("X2") +
                                 data.SearchColor[2].ToString("X2");
                textBox11.Text = ((short) data.Width).ToString();
                textBox12.Text = ((short) data.Height).ToString();
                textBox13.Text = data.NumPixels.ToString("X");
                label12.Text = "Byte Count: " + data.ImageData.Length.ToString("X");
                label13.Text = "Data Offset: " + data.DataOffset.ToString("X");
                CreateBitmap((short) data.Width, (short) data.Height, data.ImageData, ColorPixel[data.ColorType]);
            }
        }

        private void linkLabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.evozi.com");
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/evozi/SPR-Viewer");
        }

        private void buttonOpenCsp_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes["mainNode"].Nodes.Clear();
            this.SprList.Clear();
            this.openFileDialog1.Filter = "Spr File .csp|*.csp";
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName != "")
            {
                string fileName = this.openFileDialog1.FileName;
                this.ParseSprFile(fileName, 1);
            }
        }
    }
}
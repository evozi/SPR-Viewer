namespace SPR_Viewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.checkBoxMGO = new System.Windows.Forms.CheckBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCopyByte = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenSpr = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxSave = new System.Windows.Forms.GroupBox();
            this.radioButtonPng = new System.Windows.Forms.RadioButton();
            this.radioButtonDds = new System.Windows.Forms.RadioButton();
            this.groupBoxOpen = new System.Windows.Forms.GroupBox();
            this.buttonOpenCsp = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.labelAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSave.SuspendLayout();
            this.groupBoxOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxMGO
            // 
            this.checkBoxMGO.AutoSize = true;
            this.checkBoxMGO.Location = new System.Drawing.Point(0, 148);
            this.checkBoxMGO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMGO.Name = "checkBoxMGO";
            this.checkBoxMGO.Size = new System.Drawing.Size(181, 24);
            this.checkBoxMGO.TabIndex = 76;
            this.checkBoxMGO.Text = "Read mGO (Legacy)";
            this.checkBoxMGO.UseVisualStyleBackColor = true;
            this.checkBoxMGO.CheckedChanged += new System.EventHandler(this.checkBoxMGO_CheckedChanged);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(9, 74);
            this.buttonAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(282, 35);
            this.buttonAuto.TabIndex = 75;
            this.buttonAuto.Text = "Auto Load && Save Image";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 625);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 72;
            this.label13.Text = "Data Offset:";
            // 
            // buttonCopyByte
            // 
            this.buttonCopyByte.Location = new System.Drawing.Point(9, 148);
            this.buttonCopyByte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCopyByte.Name = "buttonCopyByte";
            this.buttonCopyByte.Size = new System.Drawing.Size(282, 35);
            this.buttonCopyByte.TabIndex = 69;
            this.buttonCopyByte.Text = "Copy To Clipboard";
            this.buttonCopyByte.UseVisualStyleBackColor = true;
            this.buttonCopyByte.Click += new System.EventHandler(this.buttonCopyByte_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 595);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Byte Count:";
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(9, 29);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(282, 35);
            this.buttonSaveImage.TabIndex = 67;
            this.buttonSaveImage.Text = "Save Single Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 537);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 497);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 452);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 417);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "label7";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(366, 532);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(318, 26);
            this.textBox13.TabIndex = 57;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(366, 492);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(318, 26);
            this.textBox12.TabIndex = 56;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(366, 452);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(318, 26);
            this.textBox11.TabIndex = 55;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(366, 412);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(318, 26);
            this.textBox10.TabIndex = 54;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(366, 377);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(318, 26);
            this.textBox9.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(694, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 908);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenSpr
            // 
            this.buttonOpenSpr.Location = new System.Drawing.Point(9, 29);
            this.buttonOpenSpr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenSpr.Name = "buttonOpenSpr";
            this.buttonOpenSpr.Size = new System.Drawing.Size(282, 35);
            this.buttonOpenSpr.TabIndex = 46;
            this.buttonOpenSpr.Text = "Open SPR";
            this.buttonOpenSpr.UseVisualStyleBackColor = true;
            this.buttonOpenSpr.Click += new System.EventHandler(this.buttonOpenSpr_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(366, 340);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(318, 26);
            this.textBox8.TabIndex = 45;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(366, 300);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(318, 26);
            this.textBox7.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "label1";
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(18, 106);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(232, 549);
            this.treeView1.TabIndex = 83;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(536, 225);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 26);
            this.textBox6.TabIndex = 82;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(536, 185);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 26);
            this.textBox5.TabIndex = 81;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(536, 145);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 80;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(536, 105);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 79;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(604, 26);
            this.textBox2.TabIndex = 78;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 26);
            this.textBox1.TabIndex = 77;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxSave
            // 
            this.groupBoxSave.Controls.Add(this.radioButtonPng);
            this.groupBoxSave.Controls.Add(this.radioButtonDds);
            this.groupBoxSave.Controls.Add(this.buttonSaveImage);
            this.groupBoxSave.Controls.Add(this.buttonCopyByte);
            this.groupBoxSave.Controls.Add(this.buttonAuto);
            this.groupBoxSave.Location = new System.Drawing.Point(366, 680);
            this.groupBoxSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSave.Name = "groupBoxSave";
            this.groupBoxSave.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSave.Size = new System.Drawing.Size(300, 192);
            this.groupBoxSave.TabIndex = 89;
            this.groupBoxSave.TabStop = false;
            this.groupBoxSave.Text = "Save";
            // 
            // radioButtonPng
            // 
            this.radioButtonPng.AutoSize = true;
            this.radioButtonPng.Checked = true;
            this.radioButtonPng.Location = new System.Drawing.Point(58, 112);
            this.radioButtonPng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPng.Name = "radioButtonPng";
            this.radioButtonPng.Size = new System.Drawing.Size(68, 24);
            this.radioButtonPng.TabIndex = 77;
            this.radioButtonPng.TabStop = true;
            this.radioButtonPng.Text = "PNG";
            this.radioButtonPng.UseVisualStyleBackColor = true;
            // 
            // radioButtonDds
            // 
            this.radioButtonDds.AutoSize = true;
            this.radioButtonDds.Location = new System.Drawing.Point(170, 112);
            this.radioButtonDds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonDds.Name = "radioButtonDds";
            this.radioButtonDds.Size = new System.Drawing.Size(69, 24);
            this.radioButtonDds.TabIndex = 76;
            this.radioButtonDds.TabStop = true;
            this.radioButtonDds.Text = "DDS";
            this.radioButtonDds.UseVisualStyleBackColor = true;
            // 
            // groupBoxOpen
            // 
            this.groupBoxOpen.Controls.Add(this.buttonOpenCsp);
            this.groupBoxOpen.Controls.Add(this.buttonOpenSpr);
            this.groupBoxOpen.Controls.Add(this.checkBoxMGO);
            this.groupBoxOpen.Location = new System.Drawing.Point(18, 680);
            this.groupBoxOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOpen.Name = "groupBoxOpen";
            this.groupBoxOpen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOpen.Size = new System.Drawing.Size(300, 192);
            this.groupBoxOpen.TabIndex = 90;
            this.groupBoxOpen.TabStop = false;
            this.groupBoxOpen.Text = "Open";
            // 
            // buttonOpenCsp
            // 
            this.buttonOpenCsp.Location = new System.Drawing.Point(9, 78);
            this.buttonOpenCsp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenCsp.Name = "buttonOpenCsp";
            this.buttonOpenCsp.Size = new System.Drawing.Size(282, 35);
            this.buttonOpenCsp.TabIndex = 77;
            this.buttonOpenCsp.Text = "Open CSP";
            this.buttonOpenCsp.UseVisualStyleBackColor = true;
            this.buttonOpenCsp.Click += new System.EventHandler(this.buttonOpenCsp_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(14, 23);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(42, 20);
            this.labelPath.TabIndex = 91;
            this.labelPath.Text = "Path";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 63);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 92;
            this.labelName.Text = "Name";
            // 
            // linkLabelWebsite
            // 
            this.linkLabelWebsite.AutoSize = true;
            this.linkLabelWebsite.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelWebsite.Location = new System.Drawing.Point(362, 906);
            this.linkLabelWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelWebsite.Name = "linkLabelWebsite";
            this.linkLabelWebsite.Size = new System.Drawing.Size(67, 20);
            this.linkLabelWebsite.TabIndex = 93;
            this.linkLabelWebsite.TabStop = true;
            this.linkLabelWebsite.Text = "Website";
            this.linkLabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebsite_LinkClicked);
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelGithub.Location = new System.Drawing.Point(440, 906);
            this.linkLabelGithub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(57, 20);
            this.linkLabelGithub.TabIndex = 94;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAbout.Location = new System.Drawing.Point(14, 906);
            this.labelAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(262, 20);
            this.labelAbout.TabIndex = 95;
            this.labelAbout.Text = "SPR Viewer is made by Nati && Evozi";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 942);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.linkLabelWebsite);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.groupBoxOpen);
            this.Controls.Add(this.groupBoxSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "SPR Viewer - v2.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSave.ResumeLayout(false);
            this.groupBoxSave.PerformLayout();
            this.groupBoxOpen.ResumeLayout(false);
            this.groupBoxOpen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMGO;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonCopyByte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenSpr;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxSave;
        private System.Windows.Forms.GroupBox groupBoxOpen;
        private System.Windows.Forms.RadioButton radioButtonPng;
        private System.Windows.Forms.RadioButton radioButtonDds;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkLabelWebsite;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Button buttonOpenCsp;
    }
}


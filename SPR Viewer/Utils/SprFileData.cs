using System.Collections.Generic;

namespace SPR_Viewer.Utils
{
    class SprFileData
    {
        public int ColorType;
        public long DataOffset;
        public int Height;
        public byte[] ImageData;
        public int LoopCount1;
        public int LoopCount2;
        public List<int> LoopVars1 = new List<int>();
        public List<int> LoopVars2 = new List<int>();
        public int m_FileType;
        public int NumPixels;
        public byte[] SearchColor = new byte[3];
        public int TexBlendType;
        public int var1;
        public byte var4;
        public int Width;
    }
}
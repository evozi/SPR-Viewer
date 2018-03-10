namespace SPR_Viewer.Utils
{
    class SprFileHeader
    {
        public byte[] FirstRead = new byte[0x80];
        public byte[] SecondRead = new byte[0x80];
        public int ImgCount;
        public string SprDescrption;
        public string SprFileName;
    }
}

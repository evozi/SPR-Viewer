using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPR_Viewer.Utils
{
    internal enum D3DIMAGE_FILEFORMAT
    {
        D3DXIFF_BMP = 0,
        D3DXIFF_DDS = 4,
        D3DXIFF_DIB = 6,
        D3DXIFF_FORCE_DWORD = 0x7fffffff,
        D3DXIFF_HDR = 7,
        D3DXIFF_JPG = 1,
        D3DXIFF_PFM = 8,
        D3DXIFF_PNG = 3,
        D3DXIFF_PPM = 5,
        D3DXIFF_TGA = 2
    }
}

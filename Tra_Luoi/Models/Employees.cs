using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Tra_Luoi.Models
{
    public class Employees
    {
        public int MaTD { get; set; }
        public string ViTri { get; set; }
        public string DiaDiem { get; set; }
        public string MucLuong { get; set; }
        public string HinhThuc { get; set; }
        public string KinhNghiem { get; set; }
        public string HanNop { get; set; }

        public List<string> MoTaCongViec { get; set; }
        public List<string> YeuCau { get; set; }
        public List<string> QuyenLoi { get; set; }
        public List<string> ThoiGianLamViec { get; set; }

        public string DiaDiemChiTiet { get; set; }
        public string CachThucUngTuyen { get; set; }
        public string TieuDeEmail { get; set; }
        public string LoiMoi { get; set; }
        public string Email { get; set; }
    }
}
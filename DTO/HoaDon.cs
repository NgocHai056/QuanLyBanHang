//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public string MaPhieu { get; set; }
        public string MaMatHang { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNguoiTao { get; set; }
        public Nullable<System.DateTime> NgayGiaoDich { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> KhachTra { get; set; }
        public string PhuongThuc { get; set; }
        public string TrangThai { get; set; }
        public string No { get; set; }
    
        public virtual CuaHang CuaHang { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnQLDiemSinhVien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIEM
    {
        public string MaSV { get; set; }
        public string MaMon { get; set; }
        public string HanhKiem { get; set; }
        public Nullable<int> HocKi { get; set; }
        public Nullable<double> DiemThuongKi { get; set; }
        public Nullable<double> DiemGiuaKi { get; set; }
        public Nullable<double> DiemThucHanh { get; set; }
        public Nullable<double> DiemThi { get; set; }
        public Nullable<double> DiemTongKet { get; set; }
        public string GhiChu { get; set; }
    
        public virtual MON MON { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
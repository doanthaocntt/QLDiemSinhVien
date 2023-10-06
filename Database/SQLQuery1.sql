USE QLDiemSVNTT;
go
create view thongtindiemsinhvien as
SELECT  SINHVIEN.MaSV, SINHVIEN.HoTenSV, SINHVIEN.MaLop,MON.TenMon,DIEM.DiemThuongKi, 
		DIEM.DiemThucHanh, DIEM.DiemGiuaKi,DIEM.DiemThi,DIEM.DiemTongKet,[dbo].THANGDIEM4(DiemTongKet) as THANGDIEM4
FROM SINHVIEN
INNER JOIN DIEM ON DIEM.MaSV = SINHVIEN.MaSV
INNER JOIN MON ON MON.MaMon = DIEM.MaMon-- 
go

alter function THANGDIEM4
( @DIEMTONGKET FLOAT (2))
returns varchar(1)
begin 
	DECLARE @XL varchar(1)
	if @DIEMTONGKET >= 8.5 and @DIEMTONGKET <= 10
	set @XL = 'A'
	else if @DIEMTONGKET >= 7 
	set @XL = 'B'
	else if @DIEMTONGKET >= 5
	set @XL = 'C'
	else if @DIEMTONGKET>=4
	set @XL = 'D'
	else set @XL='F'
	return @XL
end

select [dbo].THANGDIEM4(10.0)
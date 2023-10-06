use QLDiemSVNTT
select * from thongtindiemsinhvien
GO
alter PROC TIMKIEM
( 
@MSSV NVARCHAR(20) NULL,
@MAMON VARCHAR(20) NULL,
@MACN  VARCHAR(20) NULL
) 
AS 
BEGIN 
IF (@MAMON IS NOT NULL)
BEGIN
	SELECT		dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV, dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, 
				dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
				dbo.THANGDIEM4(dbo.DIEM.DiemTongKet) AS THANGDIEM4
	FROM        dbo.SINHVIEN INNER JOIN
				dbo.DIEM ON dbo.DIEM.MaSV = dbo.SINHVIEN.MaSV INNER JOIN
				dbo.MON ON dbo.MON.MaMon = dbo.DIEM.MaMon INNER JOIN
				dbo.LOP ON dbo.SINHVIEN.MaLop =dbo.LOP.MaLop
	WHERE		MON.MaMon = @MAMON
END
ELSE IF (@MACN IS NOT NULL)
BEGIN
	SELECT		dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV,dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, 
				dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
				dbo.THANGDIEM4(dbo.DIEM.DiemTongKet) AS THANGDIEM4
	FROM        dbo.SINHVIEN INNER JOIN
				dbo.DIEM ON dbo.DIEM.MaSV = dbo.SINHVIEN.MaSV INNER JOIN
				dbo.MON ON dbo.MON.MaMon = dbo.DIEM.MaMon INNER JOIN
				dbo.LOP ON dbo.SINHVIEN.MaLop =dbo.LOP.MaLop INNER JOIN
				dbo.CHUYENNGANH ON dbo.CHUYENNGANH.MSCN = LOP.MSCN
	WHERE		CHUYENNGANH.MSCN =@MACN
END

ELSE 
BEGIN
SELECT			dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV,dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, 
				dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
				dbo.THANGDIEM4(dbo.DIEM.DiemTongKet) AS THANGDIEM4
	FROM        dbo.SINHVIEN INNER JOIN
				dbo.DIEM ON dbo.DIEM.MaSV = dbo.SINHVIEN.MaSV INNER JOIN
				dbo.MON ON dbo.MON.MaMon = dbo.DIEM.MaMon INNER JOIN
				dbo.LOP ON dbo.SINHVIEN.MaLop =dbo.LOP.MaLop INNER JOIN
				dbo.CHUYENNGANH ON dbo.CHUYENNGANH.MSCN = LOP.MSCN
	WHERE		SINHVIEN.MaSV like concat('%',@MSSV,'%')
END
END
GO 
-- test procedure
exec TIMKIEM null,null,'KTPM'
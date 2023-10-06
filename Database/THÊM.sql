USE QLDiemSVNTT;
SELECT * FROM thongtindiemsinhvien
CREATE PROC SUASV
(
@MASV NVARCHAR(10),
@DIEMTHUONGKI FLOAT,
@DIEMTHUCHANH FLOAT,
@DIEMGIUAKI FLOAT,
@DIEMTHI FLOAT,
@DIEMTONGKET FLOAT,
@THANGDIEM4 CHAR(2),
@GHICHU NVARCHAR(100)
)
AS
UPDATE DIEM SET DiemThuongKi = @DIEMTHUONGKI,
				DiemThucHanh = @DIEMTHUCHANH,
				DiemGiuaKi   = @DIEMGIUAKI,
				DiemThi		 = @DIEMTHI,
				GhiChu		 = @GHICHU
WHERE MaSV  = @MASV

CREATE PROC XOADIEM
@MASV NVARCHAR(10) 
AS
DELETE FROM DIEM WHERE MaSV =@MASV
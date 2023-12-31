USE [master]
GO
/****** Object:  Database [QLDiemSVNTT]    Script Date: 8/29/2021 8:47:18 PM ******/
CREATE DATABASE [QLDiemSVNTT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDiemSVNTT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.AZDOAN\MSSQL\DATA\QLDiemSVNTT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDiemSVNTT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.AZDOAN\MSSQL\DATA\QLDiemSVNTT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLDiemSVNTT] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDiemSVNTT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDiemSVNTT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDiemSVNTT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDiemSVNTT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDiemSVNTT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDiemSVNTT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDiemSVNTT] SET  MULTI_USER 
GO
ALTER DATABASE [QLDiemSVNTT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDiemSVNTT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDiemSVNTT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDiemSVNTT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDiemSVNTT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDiemSVNTT] SET QUERY_STORE = OFF
GO
USE [QLDiemSVNTT]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [QLDiemSVNTT]
GO
/****** Object:  UserDefinedFunction [dbo].[THANGDIEM4]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[THANGDIEM4]
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
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MaSV] [nvarchar](10) NOT NULL,
	[HoTenSV] [nvarchar](100) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaLop] [nvarchar](10) NULL,
	[MaMon] [nvarchar](10) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MSCN] [nvarchar](10) NOT NULL,
	[MaLop] [nvarchar](10) NOT NULL,
	[TenLop] [nvarchar](20) NULL,
	[MaGV] [nvarchar](10) NULL,
 CONSTRAINT [PK_LOP_1] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MON]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MON](
	[MaMon] [nvarchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[MaGV] [nvarchar](10) NULL,
	[HocKi] [nvarchar](10) NULL,
	[MSCN] [nvarchar](10) NULL,
	[MaSV] [nvarchar](10) NULL,
 CONSTRAINT [PK_MON] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM](
	[MaSV] [nvarchar](10) NOT NULL,
	[MaMon] [nvarchar](10) NOT NULL,
	[HanhKiem] [nvarchar](20) NULL,
	[HocKi] [int] NULL,
	[DiemThuongKi] [float] NULL,
	[DiemGiuaKi] [float] NULL,
	[DiemThucHanh] [float] NULL,
	[DiemThi] [float] NULL,
	[DiemTongKet] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[thongtindiemsinhvien]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[thongtindiemsinhvien]
AS
SELECT    dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV, dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
                      dbo.DIEM.HanhKiem, dbo.DIEM.HocKi, dbo.THANGDIEM4(dbo.DIEM.DiemTongKet) AS THANGDIEM4, dbo.DIEM.GhiChu
FROM         dbo.SINHVIEN INNER JOIN
                      dbo.DIEM ON dbo.DIEM.MaSV = dbo.SINHVIEN.MaSV INNER JOIN
                      dbo.MON ON dbo.MON.MaMon = dbo.DIEM.MaMon INNER JOIN
                      dbo.LOP ON dbo.SINHVIEN.MaLop = dbo.LOP.MaLop
GO
/****** Object:  Table [dbo].[CHUYENNGANH]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENNGANH](
	[MSCN] [nvarchar](10) NOT NULL,
	[TenCN] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MSCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MaGV] [nvarchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SĐT] [nvarchar](15) NULL,
	[Email] [nvarchar](50) NULL,
	[PhanLoaiGV] [nvarchar](20) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUYENNGANH] ([MSCN], [TenCN]) VALUES (N'HTTT', N'Hệ thống thông tin quản lý')
INSERT [dbo].[CHUYENNGANH] ([MSCN], [TenCN]) VALUES (N'KTPM', N'Kỹ thuật phần mềm')
INSERT [dbo].[CHUYENNGANH] ([MSCN], [TenCN]) VALUES (N'KHMT', N'Khoa học máy tính')
INSERT [dbo].[CHUYENNGANH] ([MSCN], [TenCN]) VALUES (N'MMT', N'Mạng máy tính và truyền thông')
INSERT [dbo].[CHUYENNGANH] ([MSCN], [TenCN]) VALUES (N'TK', N'Thiết kế đồ họa')
INSERT [dbo].[CHUYENNGANH] ([MSCN], [TenCN]) VALUES (N'TTNT', N'Trí tuệ nhân tạo')
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV001', N'001', N'Tốt', 3, 10, 10, 10, 10, 9.9, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV001', N'003', N'Tốt', 4, 10, 10, 10, 9, 5.8, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV002', N'002', N'Tốt', 3, 10, 10, 10, 10, 10, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV002', N'005', N'Khá', 5, 10, 9, 9, 8, 8.4, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV003', N'008', N'Tốt', 2, 10, 7, 8, 7, 7.4, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV006', N'008', N'Khá', 2, 7, 7, 6, 8, 7.6, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV008', N'009', N'Khá', 2, 3, 4, 3, 4, 3.8, N'Thi lại')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV009', N'009', N'Tốt', 2, 6, 5, 3, 5, 4.9, N'')
INSERT [dbo].[DIEM] ([MaSV], [MaMon], [HanhKiem], [HocKi], [DiemThuongKi], [DiemGiuaKi], [DiemThucHanh], [DiemThi], [DiemTongKet], [GhiChu]) VALUES (N'SV010', N'009', N'Khá', 2, 3, 4, 4, 6, 5.3, N'')
GO
INSERT [dbo].[GIANGVIEN] ([MaGV], [TenGV], [GioiTinh], [SĐT], [Email], [PhanLoaiGV], [Username], [Password]) VALUES (N'NTT1', N'Trần Khuê', N'Nữ', N'0797733700', N'khuetran', N'Thỉnh giảng', N'khuetran', N'123456')
INSERT [dbo].[GIANGVIEN] ([MaGV], [TenGV], [GioiTinh], [SĐT], [Email], [PhanLoaiGV], [Username], [Password]) VALUES (N'NTT2', N'Đỗ Hoàng Nam', N'Nam', N'0793675357', N'hoangnam', N'Thỉnh giảng', N'hoangnam', N'123456')
INSERT [dbo].[GIANGVIEN] ([MaGV], [TenGV], [GioiTinh], [SĐT], [Email], [PhanLoaiGV], [Username], [Password]) VALUES (N'NTT3', N'Phạm Văn Đăng', N'Nam', N'0937746584', N'dangpham@gmail.com', N'Thỉnh giảng', N'dangpham', N'9999')
INSERT [dbo].[GIANGVIEN] ([MaGV], [TenGV], [GioiTinh], [SĐT], [Email], [PhanLoaiGV], [Username], [Password]) VALUES (N'NTT4', N'Nguyễn Mai Huy', N'Nam', N'0937852758', N'nmhuy@gmail.com', N'Thỉnh giảng', N'nmhuy', N'123456')
INSERT [dbo].[GIANGVIEN] ([MaGV], [TenGV], [GioiTinh], [SĐT], [Email], [PhanLoaiGV], [Username], [Password]) VALUES (N'NTT5', N'Thái Trúc Nhi', N'Nữ', N'07474246637', N'trucnhi@gmail.com', N'Thỉnh giảng', N'trucnhi', N'123456789')
INSERT [dbo].[GIANGVIEN] ([MaGV], [TenGV], [GioiTinh], [SĐT], [Email], [PhanLoaiGV], [Username], [Password]) VALUES (N'NTT6', N'Nguyễn Thị Hồng', N'Nữ', N'0742668475', N'nthong@gmail.com', N'Thỉnh giảng', N'nguyenhong', N'123456')
GO
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'KTPM', N'001', N'19DTH2C', N'NTT1')
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'KTPM', N'002', N'17DTH1B', N'NTT2')
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'KHMT', N'003', N'19DTH2A', N'NTT1')
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'TTNT', N'004', N'19DTH1A', N'NTT4')
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'MMT', N'005', N'19DTH2B', N'NTT6')
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'HTTT', N'006', N'19DTH1A', N'NTT3')
INSERT [dbo].[LOP] ([MSCN], [MaLop], [TenLop], [MaGV]) VALUES (N'TK', N'007', N'19DTH1C', N'NTT5')
GO
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'001', N'Chuyên đề .NET', N'NTT1', N'1', N'KTPM', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'002', N'Chuyên đề Oracle', N'NTT2', N'1', N'KTPM', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'003', N'Cấu trúc dữ liệu và giải thuật', N'NTT1', N'1', N'KTPM', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'004', N'Hệ điều hành', N'NTT3', N'2', N'KHMT', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'005', N'Lập trình web', N'NTT4', N'3', N'KTPM', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'006', N'Thiết kế web', N'NTT4', N'2', N'KTPM', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'007', N'Mã nguồn mở', N'NTT2', N'2', N'KTPM', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'008', N'Hệ quản trị CSDL', N'NTT5', N'3', N'KHMT', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'009', N'Xác suất thống kê', N'NTT6', N'3', N'HTTT', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'010', N'Kiến trúc máy tính', N'NTT5', N'2', N'KHMT', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'011', N'Tư tưởng HCM', N'NTT6', N'3', N'MMT', NULL)
INSERT [dbo].[MON] ([MaMon], [TenMon], [MaGV], [HocKi], [MSCN], [MaSV]) VALUES (N'012', N'Lý thuyết đồ thị', N'NTT4', N'2', N'TK', NULL)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV001', N'Đoàn Thảo', CAST(N'2000-04-16T00:00:00.000' AS DateTime), N'Nữ', N'429 NVT', N'001', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV002', N'An Phúc', CAST(N'1999-03-21T00:00:00.000' AS DateTime), N'Nam', N'HCM', N'002', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV003', N'Phương Vy', CAST(N'2001-06-01T00:00:00.000' AS DateTime), N'Nữ', N'CT', N'003', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV004', N'Quang Huy', CAST(N'2001-01-28T00:00:00.000' AS DateTime), N'Nam', N'VL', N'003', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV005', N'Thiên Lý', CAST(N'2001-02-18T00:00:00.000' AS DateTime), N'Nữ', N'HCM', N'004', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV006', N'Kim Phụng', CAST(N'2001-01-06T00:00:00.000' AS DateTime), N'Nữ', N'HCM', N'005', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV007', N'Quỳnh Mai', CAST(N'2001-11-15T00:00:00.000' AS DateTime), N'Nữ', N'AG', N'002', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV008', N'Huy Quang', CAST(N'2001-12-20T00:00:00.000' AS DateTime), N'Nam', N'HCM', N'001', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV009', N'Công Chức', CAST(N'2001-12-12T00:00:00.000' AS DateTime), N'Nam', N'HCM', N'001', NULL)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [NgaySinh], [GioiTinh], [DiaChi], [MaLop], [MaMon]) VALUES (N'SV010', N'Phú Đoan', CAST(N'2001-11-06T00:00:00.000' AS DateTime), N'Nữ', N'Huế', N'002', NULL)
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_MON1] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MON] ([MaMon])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_MON1]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN1] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SINHVIEN] ([MaSV])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN1]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_CHUYENNGANH] FOREIGN KEY([MSCN])
REFERENCES [dbo].[CHUYENNGANH] ([MSCN])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_CHUYENNGANH]
GO
ALTER TABLE [dbo].[MON]  WITH CHECK ADD  CONSTRAINT [FK_MON_CHUYENNGANH] FOREIGN KEY([MSCN])
REFERENCES [dbo].[CHUYENNGANH] ([MSCN])
GO
ALTER TABLE [dbo].[MON] CHECK CONSTRAINT [FK_MON_CHUYENNGANH]
GO
ALTER TABLE [dbo].[MON]  WITH CHECK ADD  CONSTRAINT [FK_MON_GIANGVIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIANGVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[MON] CHECK CONSTRAINT [FK_MON_GIANGVIEN]
GO
ALTER TABLE [dbo].[MON]  WITH CHECK ADD  CONSTRAINT [FK_MON_SINHVIEN] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SINHVIEN] ([MaSV])
GO
ALTER TABLE [dbo].[MON] CHECK CONSTRAINT [FK_MON_SINHVIEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
/****** Object:  StoredProcedure [dbo].[SUASV]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUASV]
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
GO
/****** Object:  StoredProcedure [dbo].[TIMKIEM]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TIMKIEM] 
( 
@MSSV NVARCHAR(20) NULL,
@MAMON VARCHAR(20) NULL,
@MACN  VARCHAR(20) NULL
) 
AS 
BEGIN 
IF (@MAMON IS NOT NULL)
BEGIN
	SELECT		dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV, dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
				dbo.THANGDIEM4(dbo.DIEM.DiemTongKet) AS THANGDIEM4
	FROM        dbo.SINHVIEN INNER JOIN
				dbo.DIEM ON dbo.DIEM.MaSV = dbo.SINHVIEN.MaSV INNER JOIN
				dbo.MON ON dbo.MON.MaMon = dbo.DIEM.MaMon INNER JOIN
				dbo.LOP ON dbo.SINHVIEN.MaLop =dbo.LOP.MaLop
	WHERE		MON.MaMon = @MAMON
END
ELSE IF (@MACN IS NOT NULL)
BEGIN
	SELECT		dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV,dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
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
SELECT			dbo.SINHVIEN.MaSV, dbo.SINHVIEN.HoTenSV,dbo.LOP.TenLop, dbo.MON.TenMon, dbo.DIEM.DiemThuongKi, dbo.DIEM.DiemThucHanh, dbo.DIEM.DiemGiuaKi, dbo.DIEM.DiemThi, dbo.DIEM.DiemTongKet, 
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
/****** Object:  StoredProcedure [dbo].[XOADIEM]    Script Date: 8/29/2021 8:47:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOADIEM]
@MASV NVARCHAR(10) 
AS
DELETE FROM DIEM WHERE MaSV =@MASV
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -240
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SINHVIEN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DIEM"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "MON"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "LOP"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'thongtindiemsinhvien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'thongtindiemsinhvien'
GO
USE [master]
GO
ALTER DATABASE [QLDiemSVNTT] SET  READ_WRITE 
GO

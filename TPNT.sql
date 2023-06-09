USE [master]
GO
CREATE LOGIN [khachxem] WITH PASSWORD=N'zlsqsr8B4fLpkM6IPgfqKfpbfvRnC0DdhrSLlCSAdVA=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO


CREATE LOGIN [nv001] WITH PASSWORD=N'ukn6hVQ86yl+hfgTBHw6OPFoqx/CiD9kOuo9a/PZn7o=', DEFAULT_DATABASE=[TPNT], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nv002]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE LOGIN [nv002] WITH PASSWORD=N'sBTH7mXywPCeA+27URFl/Y2GB5/eJ6GIl1nZ4BondG8=', DEFAULT_DATABASE=[TPNT], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [quanli]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE LOGIN [quanli] WITH PASSWORD=N'C8ZABttdUWjV5ZWBv5oc/hoieFAkN9HHfCNHw8ZCi2E=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [khachxem]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [nv001]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [nv002]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [quanli]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [quanli]
GO
USE [TPNT]
GO
/****** Object:  User [abc]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE USER [abc] FOR LOGIN [quanli] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [khachxem]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE USER [khachxem] FOR LOGIN [khachxem] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [nhanvien1]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE USER [nhanvien1] FOR LOGIN [nv001] WITH DEFAULT_SCHEMA=[nhanvien1]
GO
/****** Object:  User [nhanvien2]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE USER [nhanvien2] FOR LOGIN [nv002] WITH DEFAULT_SCHEMA=[nhanvien2]
GO
/****** Object:  DatabaseRole [KHACH]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE ROLE [KHACH]
GO
/****** Object:  DatabaseRole [QUANLI]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE ROLE [QUANLI]
GO
ALTER ROLE [QUANLI] ADD MEMBER [abc]
GO
ALTER ROLE [db_owner] ADD MEMBER [abc]
GO
ALTER ROLE [KHACH] ADD MEMBER [khachxem]
GO
ALTER ROLE [db_datareader] ADD MEMBER [khachxem]
GO
ALTER ROLE [QUANLI] ADD MEMBER [nhanvien1]
GO
ALTER ROLE [db_owner] ADD MEMBER [nhanvien1]
GO
ALTER ROLE [QUANLI] ADD MEMBER [nhanvien2]
GO
ALTER ROLE [db_owner] ADD MEMBER [nhanvien2]
GO
ALTER ROLE [db_datareader] ADD MEMBER [KHACH]
GO
ALTER ROLE [db_owner] ADD MEMBER [QUANLI]
GO
/****** Object:  Schema [nhanvien1]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE SCHEMA [nhanvien1]
GO
/****** Object:  Schema [nhanvien2]    Script Date: 13/07/2023 6:34:06 SA ******/
CREATE SCHEMA [nhanvien2]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_COUNT_TPNT]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_COUNT_TPNT]()
	RETURNS INT
AS
BEGIN
	DECLARE @count int = 0
	SELECT @count = COUNT(MaSoTP) FROM TPNT
	RETURN @count
END

GO
GRANT EXECUTE ON [dbo].[FN_COUNT_TPNT] TO [KHACH] AS [dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_SLTP]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_SLTP]
	(@maTG nvarchar(10))
RETURNS INT
AS
BEGIN
	RETURN (SELECT COUNT(*) FROM TPNT WHERE MaTacGia = @maTG)
END
GO
GRANT EXECUTE ON [dbo].[FN_SLTP] TO [KHACH] AS [dbo]
GO
/****** Object:  Table [dbo].[BoSuuTap]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoSuuTap](
	[MaBST] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](200) NULL,
	[HinhThuc] [nvarchar](20) NULL,
	[MoTa] [ntext] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[NguoiGD] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_BoSuuTap] PRIMARY KEY CLUSTERED 
(
	[MaBST] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_BO_SUU_TAP]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_BO_SUU_TAP]
AS
SELECT        MaBST AS [Mã bộ sưu tập], Ten AS Tên, HinhThuc AS [Hình thức], DiaChi AS [Địa chỉ], MoTa, NguoiGD, SDT
FROM            dbo.BoSuuTap

GO
GRANT SELECT ON [dbo].[V_BO_SUU_TAP] TO [KHACH] AS [dbo]
GO
/****** Object:  Table [dbo].[TPNT]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPNT](
	[MaSoTP] [nvarchar](10) NOT NULL,
	[TenTP] [nvarchar](100) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[NamSangTac] [int] NULL,
	[ChuDe] [nvarchar](50) NULL,
	[QuocGia] [nvarchar](20) NULL,
	[ThoiDai] [nvarchar](50) NULL,
	[LoiDienGiai] [ntext] NULL,
	[MaTacGia] [nvarchar](10) NULL,
 CONSTRAINT [PK_TPNT] PRIMARY KEY CLUSTERED 
(
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHinhKhac]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHinhKhac](
	[MaSoTP] [nvarchar](10) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[PhongCach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiHinhKhac] PRIMARY KEY CLUSTERED 
(
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_SELECTLOAIHINHKHAC]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SELECTLOAIHINHKHAC]
AS
SELECT    LHK.MaSoTP AS Ma, dbo.TPNT.TenTP AS Ten, LHK.TheLoai, LHK.PhongCach
FROM         dbo.LoaiHinhKhac AS LHK INNER JOIN
                      dbo.TPNT ON LHK.MaSoTP = dbo.TPNT.MaSoTP
GO
GRANT SELECT ON [dbo].[V_SELECTLOAIHINHKHAC] TO [KHACH] AS [dbo]
GO
/****** Object:  Table [dbo].[DieuKhacVaTacTuong]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuKhacVaTacTuong](
	[MaSoTP] [nvarchar](10) NOT NULL,
	[VatLieu] [nvarchar](50) NULL,
	[KhoiLuong] [float] NULL,
	[ChieuCao] [float] NULL,
	[PhongCach] [nvarchar](50) NULL,
 CONSTRAINT [PK_DieuKhacVaTacTuong] PRIMARY KEY CLUSTERED 
(
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoiHoa]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiHoa](
	[MaSoTP] [nvarchar](10) NOT NULL,
	[VatLieu] [nvarchar](50) NOT NULL,
	[ChatLieu] [nvarchar](50) NOT NULL,
	[TruongPhai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoiHoa] PRIMARY KEY CLUSTERED 
(
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[NgayMat] [date] NULL,
	[QuocTich] [nvarchar](20) NOT NULL,
	[DienGiai] [ntext] NOT NULL,
	[PhongCach] [ntext] NOT NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[ThoiDai] [ntext] NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_SELECTTACPHAM]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SELECTTACPHAM]
AS
SELECT    dbo.TPNT.MaSoTP, dbo.TPNT.TenTP, dbo.TacGia.HoTen, dbo.TPNT.NamSangTac, dbo.TPNT.ChuDe, dbo.TPNT.QuocGia, dbo.TPNT.ThoiDai, dbo.TPNT.LoiDienGiai
FROM         dbo.TPNT INNER JOIN
                      dbo.TacGia ON dbo.TPNT.MaTacGia = dbo.TacGia.MaTacGia
WHERE     (dbo.TPNT.MaSoTP NOT IN
                          (SELECT    MaSoTP
                            FROM         dbo.HoiHoa)) AND (dbo.TPNT.MaSoTP NOT IN
                          (SELECT    MaSoTP
                            FROM         dbo.DieuKhacVaTacTuong)) AND (dbo.TPNT.MaSoTP NOT IN
                          (SELECT    MaSoTP
                            FROM         dbo.LoaiHinhKhac))

GO
GRANT SELECT ON [dbo].[V_SELECTTACPHAM] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_SELECTHOIHOA]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SELECTHOIHOA]
AS
SELECT Ma = hh.MaSoTP, Ten = TPNT.TenTP, VatLieu, ChatLieu, TruongPhai
FROM HoiHoa HH, TPNT
WHERE HH.MaSoTP = TPNT.MaSoTP
GO
GRANT SELECT ON [dbo].[V_SELECTHOIHOA] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_SLHOIHOA]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SLHOIHOA]
AS
SELECT COUNT(*) AS SLHH FROM HoiHoa
GO
GRANT SELECT ON [dbo].[V_SLHOIHOA] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_SLLHK]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SLLHK]
AS
SELECT COUNT(*) AS SLLHK FROM LoaiHinhKhac
GO
GRANT SELECT ON [dbo].[V_SLLHK] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_SLTG]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SLTG]
AS
SELECT SLTG = COUNT(*) FROM TacGia
GO
GRANT SELECT ON [dbo].[V_SLTG] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_TAC_GIA]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_TAC_GIA]
AS
SELECT        MaTacGia AS [Mã tác giả], HoTen AS [Họ và tên], NgaySinh AS [Ngày sinh], QuocTich AS [Quốc tịch], PhongCach AS [Phong cách], NgayMat, DienGiai, HinhAnh
FROM            dbo.TacGia

GO
GRANT SELECT ON [dbo].[V_TAC_GIA] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_TPNT]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_TPNT]
AS
SELECT        MaSoTP AS [Mã tác phẩm], TenTP AS [Tên tác phẩm], HinhAnh, NamSangTac AS [Năm sáng tác], ChuDe, QuocGia AS [Quốc gia], ThoiDai, LoiDienGiai, MaTacGia
FROM            dbo.TPNT WITH (INDEX = IX_Nam)

GO
GRANT SELECT ON [dbo].[V_TPNT] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[View_ListDieuKhacTacTuong]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ListDieuKhacTacTuong]
AS
SELECT DKTT.MaSoTP, DKTT.VatLieu, DKTT.KhoiLuong, DKTT.ChieuCao, DKTT.PhongCach, dbo.TPNT.NamSangTac, dbo.TPNT.ChuDe, dbo.TPNT.QuocGia,
                      (SELECT HoTen
                       FROM      dbo.TacGia
                       WHERE   (MaTacGia = dbo.TPNT.MaTacGia)) AS TENTACGIA, dbo.TPNT.TenTP
FROM     dbo.TPNT INNER JOIN
                  dbo.DieuKhacVaTacTuong AS DKTT ON DKTT.MaSoTP = dbo.TPNT.MaSoTP

GO
GRANT SELECT ON [dbo].[View_ListDieuKhacTacTuong] TO [KHACH] AS [dbo]
GO
/****** Object:  Table [dbo].[LoaiSoHuu]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSoHuu](
	[MaSoTP] [nvarchar](10) NOT NULL,
	[NgaySoHuu] [date] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[TriGia] [int] NULL,
 CONSTRAINT [PK_LoaiSoHuu] PRIMARY KEY CLUSTERED 
(
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ListLoaiSoHuu]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ListLoaiSoHuu]
AS

SELECT dbo.LoaiSoHuu.MaSoTP AS [Mã tác phẩm], dbo.LoaiSoHuu.NgaySoHuu AS [Ngày sở hữu], dbo.LoaiSoHuu.TinhTrang AS [Tình Trạng], dbo.LoaiSoHuu.TriGia AS [Trị giá], TPNT.NamSangTac AS [Năm sáng tác], TPNT.TenTP AS [Tên tác phẩm] ,
                      (SELECT HoTen
                       FROM      dbo.TacGia
                       WHERE   (TPNT.MaTacGia = MaTacGia)) AS [Tác giả]
FROM     dbo.LoaiSoHuu INNER JOIN
                      (SELECT MaSoTP, ChuDe, NamSangTac, TenTP, MaTacGia
                       FROM      dbo.TPNT AS TPNT_1) AS TPNT ON TPNT.MaSoTP = dbo.LoaiSoHuu.MaSoTP

GO
GRANT SELECT ON [dbo].[View_ListLoaiSoHuu] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[View_ListTPNT]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ListTPNT]
AS
SELECT MaSoTP, ChuDe,
                      (SELECT HoTen
                       FROM      dbo.TacGia
                       WHERE   (MaTacGia = dbo.TPNT.MaTacGia)) AS TENTACGIA, NamSangTac, TenTP
FROM     dbo.TPNT

GO
GRANT SELECT ON [dbo].[View_ListTPNT] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[view_NullLoaiHinhSangTac]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_NullLoaiHinhSangTac]
AS
SELECT MaSoTP, TenTP, NamSangTac, ChuDe , QuocGia , ThoiDai , TacGia = (SELECT HOTEN FROM TacGia WHERE TacGia.MaTacGia = TPNT.MaTacGia) 
FROM     dbo.TPNT
WHERE  (MaSoTP NOT IN
                      (SELECT MaSoTP
                       FROM      dbo.DieuKhacVaTacTuong)) AND (MaSoTP NOT IN
                      (SELECT MaSoTP
                       FROM      dbo.HoiHoa)) AND (MaSoTP NOT IN
                      (SELECT MaSoTP
                       FROM      dbo.LoaiHinhKhac))

GO
GRANT SELECT ON [dbo].[view_NullLoaiHinhSangTac] TO [KHACH] AS [dbo]
GO
/****** Object:  Table [dbo].[LoaiDiMuon]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDiMuon](
	[MaSoTP] [nvarchar](10) NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[MaBST] [nvarchar](10) NULL,
 CONSTRAINT [PK_LoaiDiMuon] PRIMARY KEY CLUSTERED 
(
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_NullSoHuu]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_NullSoHuu]
as
SELECT MaSoTP , TenTP , ChuDe, NamSangTac, 
TacGia = (select HoTen FROM TacGia WHERE TPNT.MaTacGia = TacGia.MaTacGia) FROM TPNT
WHERE MaSoTP NOT IN (SELECT MaSoTP FROM LoaiSoHuu)
AND MaSoTP NOT IN (SELECT MaSoTP FROM LoaiDiMuon)

GO
GRANT SELECT ON [dbo].[view_NullSoHuu] TO [KHACH] AS [dbo]
GO
/****** Object:  View [dbo].[V_DANHSACHJOBDAILY]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* 4 là lịch trình hàng ngày*/
CREATE VIEW [dbo].[V_DANHSACHJOBDAILY]
AS
SELECT    j.name AS job_name, CAST(SUBSTRING(CAST(s.next_run_date AS NVARCHAR(8)), 7, 2) + '/' + SUBSTRING(CAST(s.next_run_date AS NVARCHAR(8)), 5, 2) + '/' + SUBSTRING(CAST(s.next_run_date AS NVARCHAR(8)), 
                      1, 4) AS NVARCHAR(10)) AS next_run_day, CAST(SUBSTRING(CAST(s.next_run_time AS NVARCHAR(6)), 1, 2) + ':' + SUBSTRING(CAST(s.next_run_time AS NVARCHAR(6)), 3, 2) 
                      + ':' + SUBSTRING(CAST(s.next_run_time AS NVARCHAR(6)), 5, 2) AS NVARCHAR(8)) AS nextruntime, CAST(SUBSTRING(CAST(ss.active_start_time AS NVARCHAR(6)), 1, 2) 
                      + ':' + SUBSTRING(CAST(ss.active_start_time AS NVARCHAR(6)), 3, 2) + ':' + SUBSTRING(CAST(ss.active_start_time AS NVARCHAR(6)), 5, 2) AS NVARCHAR(8)) AS activetime, 
                      CAST(SUBSTRING(CAST(ss.active_end_time AS NVARCHAR(6)), 1, 2) + ':' + SUBSTRING(CAST(ss.active_end_time AS NVARCHAR(6)), 3, 2) + ':' + SUBSTRING(CAST(ss.active_end_time AS NVARCHAR(6)), 5, 2) 
                      AS NVARCHAR(10)) AS activeendtime, j.enabled, ss.date_created
FROM         msdb.dbo.sysjobs AS j INNER JOIN
                      msdb.dbo.sysjobschedules AS js ON j.job_id = js.job_id INNER JOIN
                      msdb.dbo.sysschedules AS ss ON js.schedule_id = ss.schedule_id INNER JOIN
                      msdb.dbo.sysjobschedules AS s ON j.job_id = s.job_id
WHERE     (j.name LIKE 'Daily Backup Database %') AND (s.next_run_date IS NOT NULL) AND (ss.freq_type = 4)

GO
/****** Object:  View [dbo].[V_DANHSACHJOBWEEKLY]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* 8 là lịch trình hàng tuần*/
CREATE VIEW [dbo].[V_DANHSACHJOBWEEKLY]
AS
SELECT    j.name AS job_name, CAST(SUBSTRING(CAST(s.next_run_date AS NVARCHAR(8)), 7, 2) + '/' + SUBSTRING(CAST(s.next_run_date AS NVARCHAR(8)), 5, 2) + '/' + SUBSTRING(CAST(s.next_run_date AS NVARCHAR(8)), 
                      1, 4) AS NVARCHAR(10)) AS next_run_day, CAST(SUBSTRING(CAST(s.next_run_time AS NVARCHAR(6)), 1, 2) + ':' + SUBSTRING(CAST(s.next_run_time AS NVARCHAR(6)), 3, 2) 
                      + ':' + SUBSTRING(CAST(s.next_run_time AS NVARCHAR(6)), 5, 2) AS NVARCHAR(8)) AS nextruntime, CAST(ss.freq_interval AS NVARCHAR(20)) AS Expr1, 
                      CAST(SUBSTRING(CAST(ss.active_start_time AS NVARCHAR(6)), 1, 2) + ':' + SUBSTRING(CAST(ss.active_start_time AS NVARCHAR(6)), 3, 2) + ':' + SUBSTRING(CAST(ss.active_start_time AS NVARCHAR(6)), 5, 2) 
                      AS NVARCHAR(8)) AS activetime, CAST(SUBSTRING(CAST(ss.active_end_time AS NVARCHAR(6)), 1, 2) + ':' + SUBSTRING(CAST(ss.active_end_time AS NVARCHAR(6)), 3, 2) 
                      + ':' + SUBSTRING(CAST(ss.active_end_time AS NVARCHAR(6)), 5, 2) AS NVARCHAR(10)) AS activeendtime, j.enabled, ss.date_created
FROM         msdb.dbo.sysjobs AS j INNER JOIN
                      msdb.dbo.sysjobschedules AS js ON j.job_id = js.job_id INNER JOIN
                      msdb.dbo.sysschedules AS ss ON js.schedule_id = ss.schedule_id INNER JOIN
                      msdb.dbo.sysjobschedules AS s ON j.job_id = s.job_id
WHERE     (j.name LIKE 'Weekly Backup Database %') AND (s.next_run_date IS NOT NULL) AND (ss.freq_type = 8)

GO
/****** Object:  Table [dbo].[CT_CuocTrienLam]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_CuocTrienLam](
	[MaSoCTL] [nvarchar](10) NOT NULL,
	[MaSoTP] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_CT_CuocTrienLam] PRIMARY KEY CLUSTERED 
(
	[MaSoCTL] ASC,
	[MaSoTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuocTrienLam]    Script Date: 13/07/2023 6:34:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuocTrienLam](
	[MaSoCTL] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](200) NOT NULL,
	[NgayBD] [date] NOT NULL,
	[NgayKT] [date] NOT NULL,
 CONSTRAINT [PK_CuocTrienLam] PRIMARY KEY CLUSTERED 
(
	[MaSoCTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BoSuuTap] ([MaBST], [Ten], [HinhThuc], [MoTa], [DiaChi], [NguoiGD], [SDT]) VALUES (N'bst111', N'Bộ sưu tập', N'Sưu tầm', N'dang c?p nh?t', N'TP Hồ Chí Minh', N'Nguyễn Văn A', N'0989888   ')
INSERT [dbo].[BoSuuTap] ([MaBST], [Ten], [HinhThuc], [MoTa], [DiaChi], [NguoiGD], [SDT]) VALUES (N'bst222', N'Bộ sưu tập 2', N'Sưu tầm', N'Đang cập nhật 1', N'TP Hà Nội', N'Nguyễn B', N'03451223  ')
INSERT [dbo].[BoSuuTap] ([MaBST], [Ten], [HinhThuc], [MoTa], [DiaChi], [NguoiGD], [SDT]) VALUES (N'bst444', N'Bộ sưu tập 4', N'Đấu giá', N'Đang cập nhật', N'TP Hà Nội', N'Nguyễn C', N'0123334444')
GO
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP001')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP002')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP003')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP004')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP005')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP006')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL001', N'TP008')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL002', N'TP001')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL002', N'TP003')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL002', N'TP005')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL002', N'TP007')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL002', N'TP008')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL003', N'TP002')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL003', N'TP004')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL003', N'TP006')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL003', N'TP008')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP001')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP002')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP003')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP004')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP006')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP007')
INSERT [dbo].[CT_CuocTrienLam] ([MaSoCTL], [MaSoTP]) VALUES (N'CTL004', N'TP008')
GO
INSERT [dbo].[CuocTrienLam] ([MaSoCTL], [Ten], [NgayBD], [NgayKT]) VALUES (N'CTL001', N'Xuân', CAST(N'2024-01-01' AS Date), CAST(N'2024-03-01' AS Date))
INSERT [dbo].[CuocTrienLam] ([MaSoCTL], [Ten], [NgayBD], [NgayKT]) VALUES (N'CTL002', N'Hạ', CAST(N'2024-04-01' AS Date), CAST(N'2024-06-01' AS Date))
INSERT [dbo].[CuocTrienLam] ([MaSoCTL], [Ten], [NgayBD], [NgayKT]) VALUES (N'CTL003', N'Thu', CAST(N'2024-07-01' AS Date), CAST(N'2024-09-01' AS Date))
INSERT [dbo].[CuocTrienLam] ([MaSoCTL], [Ten], [NgayBD], [NgayKT]) VALUES (N'CTL004', N'Đông', CAST(N'2024-10-01' AS Date), CAST(N'2024-12-01' AS Date))
GO
INSERT [dbo].[HoiHoa] ([MaSoTP], [VatLieu], [ChatLieu], [TruongPhai]) VALUES (N'TP001', N'Sơn, Vải, Dầu', N'Sơn dầu', N'Cổ điển')
INSERT [dbo].[HoiHoa] ([MaSoTP], [VatLieu], [ChatLieu], [TruongPhai]) VALUES (N'TP006', N'Màu vẽ, Giấy vẽ, Sơn dầu', N'Giấy, màu', N'Hiện đại')
GO
INSERT [dbo].[LoaiDiMuon] ([MaSoTP], [NgayMuon], [NgayTra], [MaBST]) VALUES (N'TP008', CAST(N'2023-07-13' AS Date), CAST(N'2023-07-29' AS Date), N'bst111')
GO
INSERT [dbo].[LoaiHinhKhac] ([MaSoTP], [TheLoai], [PhongCach]) VALUES (N'TP002', N'Tranh', N'Hiện đại, Cổ điển')
GO
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG001', N'Leonardo da Vinci', CAST(N'1452-04-15' AS Date), CAST(N'1519-05-02' AS Date), N'Ý', N'Ông là một họa sĩ, nhà điêu khắc, kiến trúc sư, nhạc sĩ, bác sĩ, kỹ sư, nhà giải phẫu, nhà sáng tạo và triết học tự nhiên.', N'Khắc họa hình dáng con người một cách chân thực, không gian ba chiều', N'20230709164727.jpg', N'Phục Hưng')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG002', N'Pablo Picasso', CAST(N'1881-10-25' AS Date), CAST(N'1973-04-08' AS Date), N'Tây Ban Nha', N'Picasso được coi là một trong những nghệ sĩ nổi bật nhất của thế kỷ 20, ông cùng với Georges Braque là hai người sáng lập trường phái lập thể trong hội họa và điêu khắc.', N'Họa sĩ và nhà điêu khắc', N'20230709165640.jpg', N'Thế kỉ 20')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG003', N'Vincent van Gogh', CAST(N'1853-03-30' AS Date), CAST(N'1890-07-29' AS Date), N'Hà Lan', N'Van Gogh là nghệ sĩ tiên phong của trường phái biểu hiện và có ảnh hưởng rất lớn tới mỹ thuật hiện đại, đặc biệt là tới trường phái dã thú (Fauvism) và trường phái biểu hiện tại Đức.', N'Một danh họa Hà Lan thuộc phong  cách Hậu ấn tượng', N'20230709165829.jpg', N'Hậu ấn tượng')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG004', N'Edouard Manet', CAST(N'1832-01-23' AS Date), CAST(N'1883-04-30' AS Date), N'Pháp', N'Ông được con là một trong những nhân vật then chốt trong sự chuyển giao từ Trường phái hiện thực tới Trường phái ấn tượng.', N'Một trong những họa sĩ đầu tiên vẽ các tác phẩm liên quan tới các chủ đề về cuộc sống hiện đại', N'20230709170009.jpg', N'Nghệ thuật hiện đại')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG006', N'Paul Cézanne', CAST(N'1839-06-15' AS Date), CAST(N'1906-07-09' AS Date), N'Pháp', N'Ông là một trong những danh họa đại tài của lịch sử thế giới.', N'Theo quan điểm của nhiều người, tranh của Cézanne có ảnh hưởng lớn tới các họa sĩ đương thời, trong đó có Paolo Picasso, người nhờ vào nét bút của ông để sáng tạo ra Chủ nghĩa Lập thể phân tích.', N'20230709170311.jpg', N'Hiện đại')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG007', N'Rembrandt ', CAST(N'1606-07-16' AS Date), CAST(N'1669-10-04' AS Date), N'Hà Lan', N'Ông thường được coi là một trong những họa sĩ vĩ đại nhất trong lịch sử hội họa châu Âu nói chung và Hà Lan nói riêng.', N'Là một họa sĩ và nghệ sĩ khắc bản in nổi tiếng người Hà Lan', N'20230709170453.jpg', N'Thời đại hoàng kim của Hà Lan thế kỉ 17')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG008', N'Andy Warhol', CAST(N'1928-08-06' AS Date), CAST(N'1987-02-22' AS Date), N'Mỹ', N'Ông thường sơn tranh hậu hiện đại, thương mại và viết phim tiền phong. Tác phẩm của ông khám phá mối quan hệ giữa nghệ thuật biểu hiện, văn hóa của những người nổi tiếng và thời kỳ quảng cáo nở rộ của những năm 1960.', N'Nghệ thuật của ông đã sử dụng nhiều loại phương tiện truyền thông, bao gồm cả bản vẽ tay, tranh vẽ, tranh in, nhiếp ảnh, ảnh lụa, điêu khắc, điện ảnh và âm nhạc.', N'20230709211432.jpg', N'Hiện dại')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG009', N'Henri Matisse', CAST(N'1896-12-31' AS Date), CAST(N'1954-11-03' AS Date), N'Pháp', N'Ông là họa sĩ hội họa, đồ họa, kiêm nhà điêu khắc tài ba trong lịch sử mỹ thuật thế giới.', N'Người ta đánh giá ông là thủ lĩnh của trường phái Dã thú.', N'20230709210643.jpg', N'Cổ đại')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [NgayMat], [QuocTich], [DienGiai], [PhongCach], [HinhAnh], [ThoiDai]) VALUES (N'TG010', N'Jackson Pollock', CAST(N'1912-07-01' AS Date), CAST(N'1956-07-01' AS Date), N'Mỹ', N'Pollock là họa sĩ Mỹ có uy thế, là hình ảnh chủ chốt trong chủ nghĩa biểu hiện trừu tượng', N'Ông cho biết là cố gắng để thể hiện cảm giác ở đây bằng cách chuyển động các hình thể thay vì truyền đạt thông qua màu sắc', N'20230709210903.jpg', N'Hiện đại')
GO
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP001', N'Mona Lisa', N'Mona-Lisa.png', 1503, N'chân dung', N'Ý', N'Phục Hưng', N'Bức tranh là một bức chân dung nửa người và thể hiện một phụ nữ có những nét thể hiện trên khuôn mặt thường được miêu tả là bí ẩn.', N'TG001')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP002', N'Bữa ăn tối cuối cùng', N'The-Last-Supper.png', 1495, N'Bữa ăn tối', N'Ý', N'Phục Hưng', N'Bức tranh của Vinci mô tả lại một đoạn trong sách Kinh Thánh rằng: Giuđa — một trong số các môn đệ của Chúa Giêsu — nộp Thầy của mình cho các lực lượng đối lập với Chúa Giêsu lúc bấy giờ, là giới lãnh đạo tôn giáo và nhà cầm quyền La Mã để đổi lấy 30 đồng bạc.', N'TG001')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP003', N'La soupe 1903', N'tkx.png', 1903, N'màu sắc', N'Tây Ban Nha', N'thời kì Xanh', N'Đang cập nhật', N'TG002')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP004', N'The Old Guitarist', N'tkx2.png', 1903, N'màu sắc', N'Tây Ban Nha', N'thời kì Xanh', N'Đang cập nhật', N'TG002')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP005', N'Hoa hướng Dương', N'hhd.png', 1888, N'hoa hướng dương', N'Pháp', N'Đang cập nhật', N'Hoa hướng dương (tên gốc, trong tiếng Pháp: Tournesols) là tên của hai loạt tranh về tĩnh vật được vẽ bởi họa sĩ người Hà Lan Vincent van Gogh.', N'TG003')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP006', N'Hoa diên vĩ', N'hdv.png', 1889, N'hoa', N'Pháp', N'Đang cập nhật', N'Bức tranh chịu ảnh hưởng của thể loại tranh khắc gỗ Nhật Bản ukiyo-e, tương tự như nhiều tác phẩm khác của van Gogh cũng như các họa sĩ cùng thời khác.', N'TG003')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP007', N'A Bar at the Folies-Bergère', N'abatfb.png', 1882, N'khu giải trí', N'Anh', N'Đang cập nhật', N' Bức tranh thể hiện một quầy hàng trong khu giải trí sầm uất, nơi một cô gái đã đến phục vụ người khách quen.', N'TG004')
INSERT [dbo].[TPNT] ([MaSoTP], [TenTP], [HinhAnh], [NamSangTac], [ChuDe], [QuocGia], [ThoiDai], [LoiDienGiai], [MaTacGia]) VALUES (N'TP008', N'Blue Nudes', N'bn.png', 1952, N'người phụ nữ', NULL, N'Đang cập nhật', N'The Blue Nudes là một loạt ảnh ghép và các bản in thạch bản màu có liên quan , của Henri Matisse , được làm từ giấy cắt ra mô tả các nhân vật khỏa thân ở nhiều tư thế khác nhau.', N'TG009')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TenBST]    Script Date: 13/07/2023 6:34:07 SA ******/
ALTER TABLE [dbo].[BoSuuTap] ADD  CONSTRAINT [UK_TenBST] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_HoTenTG]    Script Date: 13/07/2023 6:34:07 SA ******/
ALTER TABLE [dbo].[TacGia] ADD  CONSTRAINT [UK_HoTenTG] UNIQUE NONCLUSTERED 
(
	[HoTen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TenTacGia]    Script Date: 13/07/2023 6:34:07 SA ******/
ALTER TABLE [dbo].[TacGia] ADD  CONSTRAINT [UK_TenTacGia] UNIQUE NONCLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Nam]    Script Date: 13/07/2023 6:34:07 SA ******/
CREATE NONCLUSTERED INDEX [IX_Nam] ON [dbo].[TPNT]
(
	[NamSangTac] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_CuocTrienLam]  WITH NOCHECK ADD  CONSTRAINT [FK_CT_CuocTrienLam_CuocTrienLam] FOREIGN KEY([MaSoCTL])
REFERENCES [dbo].[CuocTrienLam] ([MaSoCTL])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CT_CuocTrienLam] CHECK CONSTRAINT [FK_CT_CuocTrienLam_CuocTrienLam]
GO
ALTER TABLE [dbo].[CT_CuocTrienLam]  WITH NOCHECK ADD  CONSTRAINT [FK_CT_CuocTrienLam_TPNT] FOREIGN KEY([MaSoTP])
REFERENCES [dbo].[TPNT] ([MaSoTP])
GO
ALTER TABLE [dbo].[CT_CuocTrienLam] CHECK CONSTRAINT [FK_CT_CuocTrienLam_TPNT]
GO
ALTER TABLE [dbo].[DieuKhacVaTacTuong]  WITH CHECK ADD  CONSTRAINT [FK_DieuKhacVaTacTuong_TPNT] FOREIGN KEY([MaSoTP])
REFERENCES [dbo].[TPNT] ([MaSoTP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DieuKhacVaTacTuong] CHECK CONSTRAINT [FK_DieuKhacVaTacTuong_TPNT]
GO
ALTER TABLE [dbo].[HoiHoa]  WITH CHECK ADD  CONSTRAINT [FK_HoiHoa_TPNT] FOREIGN KEY([MaSoTP])
REFERENCES [dbo].[TPNT] ([MaSoTP])
GO
ALTER TABLE [dbo].[HoiHoa] CHECK CONSTRAINT [FK_HoiHoa_TPNT]
GO
ALTER TABLE [dbo].[LoaiDiMuon]  WITH CHECK ADD  CONSTRAINT [FK_LoaiDiMuon_BoSuuTap] FOREIGN KEY([MaBST])
REFERENCES [dbo].[BoSuuTap] ([MaBST])
GO
ALTER TABLE [dbo].[LoaiDiMuon] CHECK CONSTRAINT [FK_LoaiDiMuon_BoSuuTap]
GO
ALTER TABLE [dbo].[LoaiDiMuon]  WITH CHECK ADD  CONSTRAINT [FK_LoaiDiMuon_TPNT] FOREIGN KEY([MaSoTP])
REFERENCES [dbo].[TPNT] ([MaSoTP])
GO
ALTER TABLE [dbo].[LoaiDiMuon] CHECK CONSTRAINT [FK_LoaiDiMuon_TPNT]
GO
ALTER TABLE [dbo].[LoaiHinhKhac]  WITH CHECK ADD  CONSTRAINT [FK_LoaiHinhKhac_TPNT] FOREIGN KEY([MaSoTP])
REFERENCES [dbo].[TPNT] ([MaSoTP])
GO
ALTER TABLE [dbo].[LoaiHinhKhac] CHECK CONSTRAINT [FK_LoaiHinhKhac_TPNT]
GO
ALTER TABLE [dbo].[LoaiSoHuu]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSoHuu_TPNT] FOREIGN KEY([MaSoTP])
REFERENCES [dbo].[TPNT] ([MaSoTP])
GO
ALTER TABLE [dbo].[LoaiSoHuu] CHECK CONSTRAINT [FK_LoaiSoHuu_TPNT]
GO
ALTER TABLE [dbo].[TPNT]  WITH NOCHECK ADD  CONSTRAINT [FK_TPNT_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[TPNT] CHECK CONSTRAINT [FK_TPNT_TacGia]
GO
/****** Object:  StoredProcedure [dbo].[SP_BACKUPFULLDB]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BACKUPFULLDB]
	@PATH nvarchar(255)
AS
BEGIN
	DECLARE @S INT
	DECLARE @string nvarchar(20) = 'Backup'
	DECLARE @COUNT INT
	SELECT @COUNT = COUNT(*) FROM sys.backup_devices s WHERE s.physical_name = @PATH
	IF @COUNT = 0
	BEGIN
		SELECT @S = COUNT(*) FROM sys.backup_devices
		SELECT @string = concat(@string ,CONVERT(NVARCHAR, @S + 1))
		EXEC sp_addumpdevice 'disk', @string, @PATH
	END
	BACKUP DATABASE TPNT
	TO DISK = @PATH
	WITH NOFORMAT, INIT, NOREWIND, NOUNLOAD
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_BOSUUTAP_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BOSUUTAP_TPNT]
AS
	BEGIN
		SELECT T.MaSoTP AS [Mã tác phẩm], T.TenTP AS [Tên tác phẩm], L.NgayMuon AS [Ngày mượn] 
			, L.NgayTra AS [Ngày trả]
			, HinhAnh, NamSangTac , ChuDe, QuocGia , ThoiDai, LoiDienGiai, L.MaBST, MaTacGia

			FROM TPNT T INNER JOIN LoaiDiMuon L ON T.MaSoTP = L.MaSoTP 
	END

GO
GRANT EXECUTE ON [dbo].[SP_BOSUUTAP_TPNT] TO [KHACH] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_SYSADMIN]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECK_SYSADMIN]
@TENLOGIN NVARCHAR (50)
AS
BEGIN
	IF EXISTS (SELECT '1' FROM sys.syslogins WHERE name = @TENLOGIN AND sysadmin = 1)
		SELECT '1'
	ELSE
		SELECT '0'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKEXISTSTG]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECKEXISTSTG]
	@maTG nvarchar(10)
AS
BEGIN
	IF EXISTS (SELECT '1' FROM TacGia WHERE MaTacGia = @maTG)
		SELECT '1'
	ELSE
		SELECT '0'
END
GO
GRANT EXECUTE ON [dbo].[SP_CHECKEXISTSTG] TO [KHACH] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_CheckMaCuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CheckMaCuocTrienLam]
@maCTL nvarchar(10),@Check INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT @Check = COUNT(*) 
    FROM CuocTrienLam 
    WHERE MaSoCTL = @maCTL;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETCUOCTRIENLAM]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHITIETCUOCTRIENLAM]
@MACTL VARCHAR(10)
AS
BEGIN
    SELECT CT_CuocTrienLam.MaSoTP,TenTP,NamSangTac, ChuDe,TacGia = (SELECT HOTEN FROM TacGia WHERE TacGia.MaTacGia = TPNT.MaTacGia) 
	FROM CT_CuocTrienLam 
	inner join (SELECT MaSoTP,TenTP,NamSangTac,ChuDe,MaTacGia from TPNT) TPNT 
	ON CT_CuocTrienLam.MaSoTP = TPNT.MaSoTP 
	where CT_CuocTrienLam.MaSoCTL = @MACTL
END

GO
GRANT EXECUTE ON [dbo].[SP_CHITIETCUOCTRIENLAM] TO [KHACH] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHON_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHON_TPNT]
AS
BEGIN
	SELECT  MaSoTP AS [Mã tác phẩm], TenTP AS [Tên tác phẩm], HinhAnh, NamSangTac AS [Năm sáng tác], ChuDe, QuocGia AS [Quốc gia], ThoiDai, LoiDienGiai, MaTacGia
		FROM dbo.TPNT WITH (INDEX = IX_Nam)
		WHERE MaSoTP NOT IN (SELECT MaSoTP FROM LoaiDiMuon)
		AND MaSoTP NOT IN (SELECT MaSoTP FROM LoaiSoHuu)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CT_CTL]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CT_CTL]
@maSoCTL nvarchar(10)
AS
BEGIN
	SELECT * FROM CT_CuocTrienLam WHERE MaSoCTL = @maSoCTL
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER,
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
GRANT EXECUTE ON [dbo].[SP_DANGNHAP] TO [KHACH] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCTCuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_DeleteCTCuocTrienLam]
@maCTL nvarchar(10) ,@maTPNT nvarchar (10)
AS
BEGIN 
	DELETE FROM CT_CuocTrienLam WHERE MaSoCTL = @maCTL AND @maTPNT = MaSoTP
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_DeleteCuocTrienLam]
@maCTL nvarchar(10) 
AS
BEGIN
    SET NOCOUNT ON;

BEGIN TRANSACTION 

BEGIN TRY

	DELETE FROM CT_CuocTrienLam WHERE  MaSoCTL = @maCTL;

 
	DELETE FROM CuocTrienLam WHERE MaSoCTL = @maCTL

    -- Commit giao tác nếu không có lỗi
    COMMIT;
END TRY
BEGIN CATCH
    -- Rollback giao tác nếu có lỗi
    ROLLBACK;

    SELECT ERROR_MESSAGE() AS [Error];
END CATCH;
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDieuKhacVaTacTuong]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DeleteDieuKhacVaTacTuong]
@maTPNT nvarchar(10) 
AS
BEGIN 
	DELETE FROM DieuKhacVaTacTuong WHERE MaSoTP = @maTPNT 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DELETEHOIHOA]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DELETEHOIHOA]
	@maTP nvarchar(10)
AS
BEGIN
	DELETE FROM HoiHoa
	WHERE MaSoTP = @maTP
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETEJOBBACKUP]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DELETEJOBBACKUP]
	@jobname nvarchar(255)
AS
BEGIN
	EXEC msdb.dbo.sp_delete_job
    @job_name = @jobname;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETELHK]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DELETELHK]
	@maTP nvarchar(10)
AS
BEGIN
	DELETE FROM LoaiHinhKhac
	WHERE MaSoTP = @maTP
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteLoaiSoHuu]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_DeleteLoaiSoHuu]
@maTPNT nvarchar(10) 
AS
BEGIN 
	DELETE FROM LoaiSoHuu WHERE MaSoTP = @maTPNT 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DELETETG]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DELETETG]
	@maTG nvarchar(10)
AS
BEGIN
	DECLARE @sltp INT
	SET @sltp = dbo.FN_SLTP(@maTG);
	IF @sltp = 0
	BEGIN
		DELETE FROM TacGia
		WHERE MaTacGia = @maTG
	END
	ELSE
	BEGIN
		RAISERROR('Không thể xóa tác giả vì đã có tác phẩm trong hệ thống', 16, 1)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DISABLEDJOB]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DISABLEDJOB]
	@JOBNAME NVARCHAR(255)
AS
BEGIN
	UPDATE msdb.dbo.sysjobs
	SET enabled = 0
	WHERE name = @JOBNAME

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DOIMATKHAU]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DOIMATKHAU]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @NEWPASS VARCHAR(50)
AS
	DECLARE @RET INT
	EXEC @RET= SP_PASSWORD @PASS, @NEWPASS, @LGNAME
	IF (@RET =1)  
		RETURN 1
	RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[SP_ENABLEDJOB]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ENABLEDJOB]
	@JOBNAME NVARCHAR(255)
AS
BEGIN
	UPDATE msdb.dbo.sysjobs
	SET enabled = 1
	WHERE name = @JOBNAME

END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BST]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_BST]
@ma nvarchar(10), @ten nvarchar(200),
@hinhThuc nvarchar(20), @moTa ntext,
@diaChi nvarchar(100), @nguoiGD nvarchar(50),
@sdt nchar(10)
AS
BEGIN
	INSERT INTO BoSuuTap VALUES (@ma, @ten, @hinhThuc, @moTa, @diaChi, @nguoiGD, @sdt)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_LOAIDIMUON]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_LOAIDIMUON]
@ma nvarchar(10), @ngayMuon date, @ngayTra date, @maBST nvarchar(10)
AS
BEGIN
	INSERT INTO LoaiDiMuon VALUES (@ma, @ngayMuon, @ngayTra, @maBST)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_TPNT]
@ma nvarchar(10),@ten nvarchar(100), @hinhAnh nvarchar(255), @nam int, @chude nvarchar(50), 
@quocgia nvarchar(20), @thoiDai nvarchar(50),
@loiDienGiai ntext, @maTacGia nvarchar(10)
AS
	BEGIN
		INSERT INTO TPNT
		VALUES( @ma, @ten, @hinhAnh, @nam, @chude, @quocgia, @thoiDai, @loiDienGiai, @maTacGia)
		--PRINT('check insert')
	END

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCTCuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertCTCuocTrienLam]
@maCTL nvarchar(10) ,@maTPNT nvarchar (10)
AS
BEGIN 
INSERT INTO CT_CuocTrienLam(MaSoCTL,MaSoTP) VALUES(@maCTL,@maTPNT)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertCuocTrienLam]
@maCTL nvarchar(10) , @ten nvarchar(200), @TGBD datetime , @TGKT datetime
AS
BEGIN 
INSERT INTO CuocTrienLam(MaSoCTL,Ten,NgayBD,NgayKT) VALUES(@maCTL, @ten,@TGBD,@TGKT)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDieuKhacVaTacTuong]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertDieuKhacVaTacTuong]
@maTPNT nvarchar(10) , @KhoiLuong float,@VatLieu nvarchar(50) , @ChieuCao float, @PhongCach nvarchar(50)
AS
BEGIN 
INSERT INTO DieuKhacVaTacTuong(MaSoTP,KhoiLuong,VatLieu,ChieuCao,PhongCach) VALUES(@maTPNT, @KhoiLuong,@VatLieu,@ChieuCao, @PhongCach)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTHOIHOA]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTHOIHOA]
	@maTP nvarchar(10), @vatLieu nvarchar(50), @chatLieu nvarchar(50), @truongPhai nvarchar(50)
AS
BEGIN
	INSERT INTO HoiHoa
	VALUES(@maTP, @vatLieu, @chatLieu, @truongPhai)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTLHK]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTLHK]
	@maTP nvarchar(10), @theLoai nvarchar(50), @phongCach nvarchar(50)
AS
BEGIN
	INSERT INTO LoaiHinhKhac
	VALUES(@maTP, @theLoai, @phongCach)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertLoaiSoHuu]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertLoaiSoHuu]
@maTPNT nvarchar(10) , @NgaySoHuu DateTime,@TinhTrang nvarchar(50) ,@TriGia Int
AS
BEGIN 
INSERT INTO LoaiSoHuu (MaSoTP,NgaySoHuu,TinhTrang, TriGia) VALUES(@maTPNT,@NgaySoHuu ,@TinhTrang,@TriGia)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTTG]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTTG]
	@maTG nvarchar(10), @hoTen nvarchar(50), @ngaySinh date,
	@ngayMat nvarchar(10), @quocTich nvarchar(20), @dienGiai ntext,
	@phongCach ntext, @hinhAnh nvarchar(255), @thoiDai ntext
AS
BEGIN
	INSERT INTO TacGia
	VALUES (@maTG, @hoTen, @ngaySinh, CASE WHEN @ngayMat = '' THEN NULL ELSE CONVERT(date, @ngayMat) END, @quocTich, @dienGiai, @phongCach, @hinhAnh, @thoiDai)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RP_CuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_RP_CuocTrienLam]
@FROM dateTime , @TO datetime
AS
BEGIN
	 
	SELECT CuocTrienLam.* , TPNT.MaSoTP, TPNT.TenTP, TPNT.ChuDe,TPNT.NamSangTac, TPNT.QuocGia,TACGIA= (SELECT HoTen FROM TacGia WHERE MaTacGia = TPNT.MaTacGia)
	FROM CuocTrienLam 
	
	join CT_CuocTrienLam on CT_CuocTrienLam.MaSoCTL = CuocTrienLam.MaSoCTL
	join TPNT on TPNT.MaSoTP= CT_CuocTrienLam.MaSoTP
	Where CuocTrienLam.NgayBD Between @FROM and @TO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SET_UP_JOB_FOR_BACKUP]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SET_UP_JOB_FOR_BACKUP]
	@PATH nvarchar(255)
AS
BEGIN
		 IF NOT EXISTS (SELECT 1 FROM msdb.dbo.sysjobs j WHERE j.name = N'Backup Database Job')
			 BEGIN -- CHUA TON TAI JOB BACKUP TRONG DB THI TAO MOI
				DECLARE @str nvarchar(500)
				SET @str = 'EXEC [dbo].[SP_BACKUPFULLDB] ' + ''''+ @PATH+ ''''

				DECLARE @SL INT
				SELECT @SL = COUNT(*)
				FROM msdb.dbo.sysjobsteps
				WHERE job_id = (SELECT job_id FROM msdb.dbo.sysjobs WHERE name = N'Backup Database Job')

				DECLARE @step nvarchar(255)
				SET @step = 'Backup Database Step ' + CAST(@SL + 1 AS nvarchar(10))

				EXEC msdb.dbo.sp_add_job
					@job_name = N'Backup Database Job';

				EXEC msdb.dbo.sp_add_jobstep
				@job_name = N'Backup Database Job',
				@step_name = @step,
				@subsystem = N'TSQL',
				@command = @str,
				@database_name = 'TPNT';
				EXEC msdb.dbo.sp_add_jobserver
					@job_name = 'Backup Database Job',
					@server_name = N'(local)';
			 END -- ĐÃ TỒN TẠI JOB
		ELSE
			BEGIN
				DECLARE @str1 nvarchar(500)
				SET @str1 = 'EXEC [dbo].[SP_BACKUPFULLDB] ' + ''''+ @PATH+ ''''

				DECLARE @SL1 INT
				SELECT @SL1 = COUNT(*)
				FROM msdb.dbo.sysjobsteps
				WHERE job_id = (SELECT job_id FROM msdb.dbo.sysjobs WHERE name = N'Backup Database Job')

				DECLARE @step1 nvarchar(255)
				SET @step1 = 'Backup Database Step ' + CAST(@SL1 + 1 AS nvarchar(10))

				EXEC msdb.dbo.sp_add_jobstep
				@job_name = N'Backup Database Job',
				@step_name = @step1,
				@subsystem = N'TSQL',
				@command = @str1,
				@database_name = 'TPNT';
			END
	 -- TẠO LỊCH TRÌNH MỚI CHO JOB
		DECLARE @SLLT INT
		SELECT @SLLT = COUNT(*)
		FROM msdb.dbo.sysjobschedules js
			INNER JOIN msdb.dbo.sysjobs j ON js.job_id = j.job_id
		WHERE j.name = 'Backup Database Job';

		DECLARE @strsc nvarchar(255)
		SET @strsc = 'Backup Schedule ' + CAST(@SLLT + 1 AS nvarchar(10))

		EXEC msdb.dbo.sp_add_schedule
			@schedule_name = @strsc,
			@freq_type = 4, -- Scheduling type: Daily
			@freq_interval = 1,
			@active_start_time = 85100; -- Thời gian bắt đầu (vd: 20:00:00)

		-- them lich cho backup
		EXEC msdb.dbo.sp_attach_schedule
			@job_name = N'Backup Database Job',
			@schedule_name = @strsc;

		EXEC msdb.dbo.sp_update_job
			@job_name = N'Backup Database Job',
			@enabled = 1;

END

GO
/****** Object:  StoredProcedure [dbo].[SP_SET_UP_JOB_FOR_BACKUP_DAILY]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SET_UP_JOB_FOR_BACKUP_DAILY]
	@PATH nvarchar(255), @TIME INT
AS
BEGIN
	DECLARE @JOB_NAME NVARCHAR(255)
	SET @JOB_NAME = 'Daily Backup Database ' + CAST(@TIME AS NVARCHAR(50))

	DECLARE @STRSCHEDULE NVARCHAR(255)
	SET @STRSCHEDULE = 'Backup Database Daily Step ' + + CAST(@TIME AS NVARCHAR(50))
		 IF NOT EXISTS (SELECT 1 FROM msdb.dbo.sysjobs j WHERE j.name = @JOB_NAME)
			 BEGIN -- CHUA TON TAI JOB BACKUP TRONG DB THI TAO MOI
				DECLARE @str nvarchar(500)
				SET @str = 'EXEC [dbo].[SP_BACKUPFULLDB] ' + ''''+ @PATH+ ''''

				EXEC msdb.dbo.sp_add_job
					@job_name = @JOB_NAME;

				EXEC msdb.dbo.sp_add_jobstep
				@job_name = @JOB_NAME,
				@step_name = 'Backup Database Daily Step',
				@subsystem = N'TSQL',
				@command = @str,
				@database_name = 'TPNT';

				EXEC msdb.dbo.sp_add_jobserver
					@job_name = @JOB_NAME,
					@server_name = N'(local)';
			 END -- ĐÃ TỒN TẠI JOB
		ELSE
			BEGIN
				RAISERROR('Đã có lịch trình Backup này', 16, 1)
				RETURN

			END	
				
	 -- TẠO LỊCH TRÌNH MỚI CHO JOB

		EXEC msdb.dbo.sp_add_schedule
			@schedule_name = @STRSCHEDULE,
			@freq_type = 4, -- Scheduling type: Daily
			@freq_interval = 1,
			@active_start_time = @TIME; -- Thời gian bắt đầu (vd: 20:00:00)

		-- them lich cho backup
		EXEC msdb.dbo.sp_attach_schedule
			@job_name = @JOB_NAME,
			@schedule_name = @STRSCHEDULE;

		EXEC msdb.dbo.sp_update_job
			@job_name = @JOB_NAME,
			@enabled = 1;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SET_UP_JOB_FOR_BACKUP_WEEKLY]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SET_UP_JOB_FOR_BACKUP_WEEKLY]
	@PATH nvarchar(255), @TIME INT, @THU INT
AS
BEGIN
	DECLARE @DAY_NAME NVARCHAR(20)
	IF @THU = 1
		BEGIN 
		 SET @DAY_NAME = 'Sunday'
		END
	ELSE IF @THU = 2
		BEGIN
			SET @DAY_NAME = 'Monday'
		END
	ELSE IF @THU = 4
		BEGIN
			SET @DAY_NAME = 'Tuesday'
		END
	ELSE IF @THU = 8
		BEGIN
			SET @DAY_NAME = 'Wednesday'
		END
	ELSE IF @THU = 16
		BEGIN
			SET @DAY_NAME = 'Thursday'
		END
	ELSE IF @THU = 32
		BEGIN
			SET @DAY_NAME = 'Friday'
		END
	ELSE IF @THU = 64
		BEGIN
			SET @DAY_NAME = 'Saturday'
		END
	DECLARE @JOB_NAME NVARCHAR(255)
	SET @JOB_NAME = 'Weekly Backup Database ' + @DAY_NAME + ' ' + CAST(@TIME AS NVARCHAR(50))

	DECLARE @STRSCHEDULE NVARCHAR(255)
	SET @STRSCHEDULE = 'Backup Database Weekly Step ' + @DAY_NAME + ' ' + CAST(@TIME AS NVARCHAR(50))
		 IF NOT EXISTS (SELECT 1 FROM msdb.dbo.sysjobs j WHERE j.name = @JOB_NAME)
			 BEGIN -- CHUA TON TAI JOB BACKUP TRONG DB THI TAO MOI
				DECLARE @str nvarchar(500)
				SET @str = 'EXEC [dbo].[SP_BACKUPFULLDB] ' + ''''+ @PATH+ ''''

				EXEC msdb.dbo.sp_add_job
					@job_name = @JOB_NAME;

				EXEC msdb.dbo.sp_add_jobstep
				@job_name = @JOB_NAME,
				@step_name = 'Backup Database Weekly Step',
				@subsystem = N'TSQL',
				@command = @str,
				@database_name = 'TPNT';

				EXEC msdb.dbo.sp_add_jobserver
					@job_name = @JOB_NAME,
					@server_name = N'(local)';
			 END -- ĐÃ TỒN TẠI JOB
		ELSE
			BEGIN
				RAISERROR('Đã có lịch trình Backup này', 16, 1)
				RETURN

			END	
				
	 -- TẠO LỊCH TRÌNH MỚI CHO JOB
		--1 = Sunday
		--2 = Monday
		--4 = Tuesday
		--8 = Wednesday
		--16 = Thursday
		--32 = Friday
		--64 = Saturday

		EXEC msdb.dbo.sp_add_schedule
			@schedule_name = @STRSCHEDULE,
			@freq_type = 8, -- Scheduling type: Weekly
			@freq_interval = @THU,
			@freq_recurrence_factor = 1, -- số tuần giữa các lần chạy
			@active_start_time = @TIME; -- Thời gian bắt đầu (vd: 20:00:00)

		-- them lich cho backup
		EXEC msdb.dbo.sp_attach_schedule
			@job_name = @JOB_NAME,
			@schedule_name = @STRSCHEDULE;

		EXEC msdb.dbo.sp_update_job
			@job_name = @JOB_NAME,
			@enabled = 1;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TPNT'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[SP_TPNT_ChiTietCTL]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_TPNT_ChiTietCTL]
@maCTL nvarchar (10) 
AS
BEGIN
	SELECT MaSoTP,TenTP,NamSangTac,TacGia=(SELECT HOTEN FROM TACGIA WHERE TacGia.MaTacGia = TPNT.MaTacGia)
	FROM TPNT WHERE MaSoTP NOT IN (SELECT MaSoTP FROM CT_CuocTrienLam where MaSoCTL = @maCTL)
END

GO
GRANT EXECUTE ON [dbo].[SP_TPNT_ChiTietCTL] TO [KHACH] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_BST]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_BST] 
@ma nvarchar(10), @ten nvarchar(200),
@hinhThuc nvarchar(20), @moTa ntext,
@diaChi nvarchar(100), @nguoiGD nvarchar(50),
@sdt nchar(10)
AS
BEGIN
	UPDATE BoSuuTap
	SET Ten = @ten, 
	HinhThuc = @hinhThuc,
	MoTa = @moTa,
	DiaChi = @diaChi,
	NguoiGD = @nguoiGD,
	SDT = @sdt
	WHERE MaBST = @ma
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_LOAIDIMUON]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_LOAIDIMUON]
@ma nvarchar(10), @ngayMuon date, @ngayTra date
AS
BEGIN
	UPDATE LoaiDiMuon 
	SET NgayMuon = @ngayMuon, NgayTra = @ngayTra
	WHERE MaSoTP = @ma
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_TPNT]
@ma nvarchar(10),@ten nvarchar(100), @hinhAnh nvarchar(255), @nam int, @chude nvarchar(50), 
@quocgia nvarchar(20), @thoiDai nvarchar(50),
@loiDienGiai ntext, @maTacGia nvarchar(10)
AS
	BEGIN
		UPDATE TPNT
		SET TenTP=@ten,HinhAnh=@hinhAnh, NamSangTac = @nam, ChuDe = @chude, QuocGia = @quocgia, ThoiDai = @thoiDai, LoiDienGiai = @loiDienGiai, MaTacGia = @maTacGia
		WHERE MaSoTP = @ma
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCuocTrienLam]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_UpdateCuocTrienLam]
@maCTL nvarchar(10), @Ten nvarchar( 200),@NgayBD DateTime , @NgayKT DateTime
AS
BEGIN 
	UPDATE CuocTrienLam
	SET Ten = @Ten,
		NgayBD = @NgayBD,
		NgayKT = @NgayKT
	WHERE MaSoCTL = @maCTL 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateDieuKhacVaTacTuong]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_UpdateDieuKhacVaTacTuong]
@maTPNT nvarchar(10), @KhoiLuong float,@VatLieu nvarchar(50) , @ChieuCao float, @PhongCach nvarchar(50)
AS
BEGIN 
	UPDATE DieuKhacVaTacTuong 
	SET KhoiLuong = @KhoiLuong,
		VatLieu = @VatLieu,
		ChieuCao = @ChieuCao,
		PhongCach = @PhongCach
	WHERE MaSoTP = @maTPNT 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATEHOIHOA]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATEHOIHOA]
	@maTP nvarchar(10), @vatlieu nvarchar(50), @chatlieu nvarchar(50), @truongphai nvarchar(50)
AS
BEGIN
	UPDATE HoiHoa
	SET VatLieu = @vatlieu, ChatLieu = @chatlieu, TruongPhai = @truongphai
	WHERE MaSoTP = @maTP
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATELHK]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATELHK]
	@maTP nvarchar(10), @theLoai nvarchar(50), @phongCach nvarchar(50)
AS
BEGIN
	UPDATE LoaiHinhKhac
	SET MaSoTP = @maTP, TheLoai = @theLoai, PhongCach = @phongCach
	WHERE MaSoTP = @maTP
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateLoaiSoHuu]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_UpdateLoaiSoHuu]
@maTPNT nvarchar(10) , @NgaySoHuu DateTime,@TinhTrang nvarchar(50) ,@TriGia Int
AS
BEGIN 
	UPDATE LoaiSoHuu 
	SET NgaySoHuu = @NgaySoHuu,
		TinhTrang = @TinhTrang,
		TriGia = @TriGia
	WHERE MaSoTP = @maTPNT 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATETG]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATETG]
	@maTGCu nvarchar(10), @maTGMoi nvarchar(10), @hoTen nvarchar(50), @ngaySinh date,
	@ngayMat nvarchar(10), @quocTich nvarchar(20), @dienGiai ntext,
	@phongCach ntext, @hinhAnh nvarchar(255), @thoiDai ntext
AS
BEGIN
	UPDATE TacGia
	SET MaTacGia = @maTGMoi, HoTen = @hoTen, NgaySinh = @ngaySinh,
		NgayMat = CASE WHEN @ngayMat = '' THEN NULL ELSE CONVERT(date, @ngayMat) END,
		QuocTich = @quocTich, DienGiai = @dienGiai, PhongCach = @phongCach,
		HinhAnh = @hinhAnh, ThoiDai = @thoiDai
	WHERE MaTacGia = @maTGCu
END

GO
/****** Object:  Trigger [dbo].[TR_BEFORE_DELETE_BST]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_DELETE_BST] ON [dbo].[BoSuuTap]
	INSTEAD OF DELETE
AS
	BEGIN
		BEGIN TRAN
		IF EXISTS (SELECT 1 FROM deleted D INNER JOIN LoaiDiMuon L ON D.MaBST = L.MaBST)
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể xoá bộ sưu tập này vì có tác phẩm nghệ thuật đang cho mượn thuộc bộ sưu tập này!',16,1)
			END
		ELSE
		BEGIN
		DELETE FROM BoSuuTap WHERE MaBST = (SELECT MaBST FROM deleted)
		COMMIT TRAN
		END
	END
GO
ALTER TABLE [dbo].[BoSuuTap] ENABLE TRIGGER [TR_BEFORE_DELETE_BST]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_INSERT_BST]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_INSERT_BST] ON [dbo].[BoSuuTap]
	INSTEAD OF INSERT
AS
	BEGIN
		IF EXISTS (SELECT 1 FROM inserted I INNER JOIN BoSuuTap B ON I.MaBST = B.MaBST)
			BEGIN
				ROLLBACK;
				raiserror( N'Không thể thêm bộ sưu tập này vì mã bộ sưu tập này đã tồn tại!',16,1)
			END
		ELSE IF EXISTS (SELECT 1 FROM BoSuuTap B WHERE B.Ten = (SELECT TEN FROM inserted))
			BEGIN
				ROLLBACK;
				raiserror( N'Không thể thêm tên bộ sưu tập này vì tên bộ sưu tập này đã tồn tại!',16,1)
			END
		ELSE
		INSERT INTO BoSuuTap
		SELECT * FROM inserted
	END

GO
ALTER TABLE [dbo].[BoSuuTap] ENABLE TRIGGER [TR_BEFORE_INSERT_BST]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_UPDATE_BST]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_UPDATE_BST] ON [dbo].[BoSuuTap]
	INSTEAD OF UPDATE
AS
	BEGIN
		IF EXISTS (SELECT 1 FROM BoSuuTap B WHERE B.Ten = (SELECT TEN FROM inserted) AND B.MaBST <> (SELECT MaBST FROM inserted))
				BEGIN
						ROLLBACK;
						raiserror( N'Không thể thêm tên bộ sưu tập này vì tên bộ sưu tập này đã tồn tại!',16,1)
				END
		ELSE
		UPDATE BoSuuTap
			SET Ten = (SELECT Ten FROM inserted), 
			HinhThuc = (SELECT HinhThuc FROM inserted),
			MoTa = (SELECT MoTa FROM inserted),
			DiaChi = (SELECT DiaChi FROM inserted),
			NguoiGD = (SELECT NguoiGD FROM inserted),
			SDT = (SELECT SDT FROM inserted)
			WHERE MaBST = (SELECT MaBST FROM inserted)
	END

GO
ALTER TABLE [dbo].[BoSuuTap] ENABLE TRIGGER [TR_BEFORE_UPDATE_BST]
GO
/****** Object:  Trigger [dbo].[CheckCuocTrienLam_CT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckCuocTrienLam_CT]
ON [dbo].[CT_CuocTrienLam]
AFTER INSERT , UPDATE
AS
BEGIN
BEGIN TRANSACTION
    IF EXISTS (
        SELECT 1
        FROM inserted 
        LEFT JOIN CuocTrienLam  ON inserted.MaSoCTL = CuocTrienLam.MaSoCTL
        WHERE CuocTrienLam.MaSoCTL IS NULL)
    BEGIN
        RAISERROR ('Không thể thêm chi tiết khi mã Cuộc triển lãm chưa tồn tại trong bảng Cuộc triển Lãm.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	COMMIT TRAN
END

GO
ALTER TABLE [dbo].[CT_CuocTrienLam] ENABLE TRIGGER [CheckCuocTrienLam_CT]
GO
/****** Object:  Trigger [dbo].[CheckTPNT_CT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckTPNT_CT]
ON [dbo].[CT_CuocTrienLam]
AFTER INSERT , UPDATE
AS
BEGIN
BEGIN TRANSACTION
    IF EXISTS (
        SELECT 1
        FROM inserted 
        LEFT JOIN TPNT  ON inserted.MaSoTP = TPNT.MaSoTP
        WHERE TPNT.MaSoTP IS NULL)
    BEGIN
        RAISERROR ('Không thể thêm chi tiết khi mã số TP chưa tồn tại trong bảng TPNT.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	COMMIT TRAN
END

GO
ALTER TABLE [dbo].[CT_CuocTrienLam] ENABLE TRIGGER [CheckTPNT_CT]
GO
/****** Object:  Trigger [dbo].[Trigger_CheckNgayBD_NgayKT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigger_CheckNgayBD_NgayKT]
ON [dbo].[CuocTrienLam]
AFTER INSERT, UPDATE
AS
BEGIN
	BEGIN TRANSACTION
		IF EXISTS (
			SELECT 1
			FROM inserted
			WHERE NgayBD > NgayKT
		)
		BEGIN
			RAISERROR ('Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.', 16, 1)
			ROLLBACK TRANSACTION

		END
		IF EXISTS (
			SELECT 1
			FROM inserted
			WHERE NgayBD < GETDATE() 
		)
		BEGIN
			RAISERROR ('Ngày bắt đầu và ngày kết thúc phải lớn hơn ngày hiện tại.', 16, 1)
			ROLLBACK TRANSACTION

		END
	COMMIT TRAN
END

GO
ALTER TABLE [dbo].[CuocTrienLam] ENABLE TRIGGER [Trigger_CheckNgayBD_NgayKT]
GO
/****** Object:  Trigger [dbo].[CheckTPNT_DieuKhacTacTuong]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckTPNT_DieuKhacTacTuong]
ON [dbo].[DieuKhacVaTacTuong]
INSTEAD OF INSERT 
AS
BEGIN
BEGIN TRANSACTION
    IF EXISTS (
        SELECT 1
        FROM inserted
        LEFT JOIN TPNT  ON inserted.MaSoTP = TPNT.MaSoTP
        WHERE TPNT.MaSoTP IS NULL)
    BEGIN
        RAISERROR ('Không thể thêm chi tiết khi mã số TP chưa tồn tại trong bảng TPNT.', 16, 1)
        ROLLBACK TRANSACTION

    END
	else if exists (
			 SELECT 1
				FROM inserted AS I WHERE I.ChieuCao <= 0 or I.KhoiLuong <= 0
			)
			BEGIN
			   RAISERROR ('Chiều cao và Khối lượng không thể bé hơn bằng 0.', 16, 1)
				ROLLBACK TRANSACTION
			END
	ELSE
	INSERT INTO DieuKhacVaTacTuong
	SELECT * FROM inserted
	COMMIT TRAN
END

GO
ALTER TABLE [dbo].[DieuKhacVaTacTuong] ENABLE TRIGGER [CheckTPNT_DieuKhacTacTuong]
GO
/****** Object:  Trigger [dbo].[CheckTPNT_DieuKhacTacTuong_UPDATE]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckTPNT_DieuKhacTacTuong_UPDATE]
ON [dbo].[DieuKhacVaTacTuong]
for UPDATE
AS
BEGIN

     if exists (
			 SELECT 1
				FROM inserted AS I WHERE I.ChieuCao <= 0 or I.KhoiLuong <= 0
			)
			BEGIN
			   RAISERROR ('Chiều cao và Khối lượng không thể bé hơn bằng 0.', 16, 1)
				ROLLBACK TRANSACTION
			END
	--ELSE
	--UPDATE DieuKhacVaTacTuong
	--SET ChieuCao = (SELECT ChieuCao From inserted) ,KhoiLuong = (SELECT KhoiLuong From inserted) , VatLieu = (SELECT VatLieu From inserted), PhongCach = (SELECT PhongCach From inserted)

END

GO
ALTER TABLE [dbo].[DieuKhacVaTacTuong] ENABLE TRIGGER [CheckTPNT_DieuKhacTacTuong_UPDATE]
GO
/****** Object:  Trigger [dbo].[TG_MATP]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_MATP]
ON [dbo].[HoiHoa]
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @CHECK1 INT
	SET @CHECK1 = 0
	DECLARE @CHECK2 INT
	SET @CHECK2 = 0
	IF EXISTS (SELECT 1 FROM INSERTED I WHERE I.MaSoTP NOT IN (SELECT MaSoTP FROM TPNT))
	BEGIN
		SET @CHECK1 = 1
	END

	IF @CHECK1 = 0
	BEGIN
		IF EXISTS (SELECT 1 FROM INSERTED I WHERE I.MaSoTP IN (SELECT MaSoTP FROM DieuKhacVaTacTuong) OR I.MaSoTP IN (SELECT MaSoTP FROM LoaiHinhKhac))
			BEGIN
				SET @CHECK2 = 1
			END
	END

	IF @CHECK1 = 1
	BEGIN
		RAISERROR('Chưa tồn tại tác phẩm này', 16, 1)
	END

	IF @CHECK2 = 1
	BEGIN
		RAISERROR('Tác phẩm này đã tồn tại ở loại hình khác', 16, 1)
	END

	IF @CHECK1 = 0 AND @CHECK2 = 0
	BEGIN
		INSERT INTO HoiHoa
		SELECT * FROM INSERTED
	END
END
GO
ALTER TABLE [dbo].[HoiHoa] ENABLE TRIGGER [TG_MATP]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_INSERT_LDM]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_INSERT_LDM] ON [dbo].[LoaiDiMuon]
	INSTEAD OF INSERT
AS
	BEGIN
		BEGIN TRAN
		IF  NOT EXISTS (SELECT 1 FROM inserted I INNER JOIN TPNT T ON I.MaSoTP = T.MaSoTP)
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể mượn tác phẩm này vì mã tác phẩm này không tồn tại!',16,1)
			END
		ELSE If  not exists(SELECT 1 FROM inserted I INNER JOIN BoSuuTap B ON I.MaBST = B.MaBST )
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể mượn tác phẩm này vì bộ sưu tập này không tồn tại!',16,1)
			END
		ELSE If  exists(SELECT 1 FROM inserted WHERE NgayTra < NgayMuon)
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể mượn tác phẩm này vì ngày trả không thể nhỏ hơn ngày mượn!',16,1)
			END
		ELSE
		INSERT INTO LoaiDiMuon
		SELECT * FROM inserted
		COMMIT TRAN
	END

GO
ALTER TABLE [dbo].[LoaiDiMuon] ENABLE TRIGGER [TR_BEFORE_INSERT_LDM]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_UPDATE_LDM]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_UPDATE_LDM] ON [dbo].[LoaiDiMuon]
	INSTEAD OF UPDATE
AS
	BEGIN
		BEGIN TRAN
		If  exists(SELECT 1 FROM inserted WHERE NgayTra < NgayMuon)
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể mượn tác phẩm này vì ngày trả không thể nhỏ hơn ngày mượn!',16,1)
			END
		ELSE
		UPDATE LoaiDiMuon SET
		NgayMuon = (SELECT NgayMuon FROM inserted),
		NgayTra = (SELECT NgayTra FROM inserted)
		WHERE MaSoTP = (SELECT MaSoTP FROM inserted)
		COMMIT TRAN
	END

GO
ALTER TABLE [dbo].[LoaiDiMuon] ENABLE TRIGGER [TR_BEFORE_UPDATE_LDM]
GO
/****** Object:  Trigger [dbo].[TG_MATP_LHK]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_MATP_LHK]
ON [dbo].[LoaiHinhKhac]
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @CHECK1 INT
	SET @CHECK1 = 0
	DECLARE @CHECK2 INT
	SET @CHECK2 = 0
	IF EXISTS (SELECT 1 FROM INSERTED I WHERE I.MaSoTP NOT IN (SELECT MaSoTP FROM TPNT))
	BEGIN
		SET @CHECK1 = 1
	END

	IF @CHECK1 = 0
	BEGIN
		IF EXISTS (SELECT 1 FROM INSERTED I WHERE I.MaSoTP IN (SELECT MaSoTP FROM DieuKhacVaTacTuong) OR I.MaSoTP IN (SELECT MaSoTP FROM HoiHoa))
			BEGIN
				SET @CHECK2 = 1
			END
	END

	IF @CHECK1 = 1
	BEGIN
		RAISERROR('Chưa tồn tại tác phẩm này', 16, 1)
	END

	IF @CHECK2 = 1
	BEGIN
		RAISERROR('Tác phẩm này đã tồn tại ở loại hình khác', 16, 1)
	END

	IF @CHECK1 = 0 AND @CHECK2 = 0
	BEGIN
		INSERT INTO LoaiHinhKhac
		SELECT * FROM INSERTED
	END
END
GO
ALTER TABLE [dbo].[LoaiHinhKhac] ENABLE TRIGGER [TG_MATP_LHK]
GO
/****** Object:  Trigger [dbo].[Trigger_Check_LoaiSoHuu]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigger_Check_LoaiSoHuu]
ON [dbo].[LoaiSoHuu]
INSTEAD OF INSERT
AS
BEGIN
BEGIN TRANSACTION
	IF EXISTS (
        SELECT 1
        FROM inserted
        LEFT JOIN TPNT  ON inserted.MaSoTP = TPNT.MaSoTP
        WHERE TPNT.MaSoTP IS NULL)
		BEGIN
        RAISERROR ('Không thể thêm chi tiết khi mã số TP chưa tồn tại trong bảng TPNT.', 16, 1)
        ROLLBACK TRANSACTION
		END
	ELSE IF EXISTS (
			SELECT 1
			FROM inserted
        WHERE NgaySoHuu > GETDATE() 
    )
    BEGIN
        RAISERROR ('Ngày sở hữu phải nhỏ hơn hoặc bằng ngày hiện tại.', 16, 1)
        ROLLBACK TRANSACTION 
    END
	ELSE IF EXISTS (
			SELECT 1
			FROM inserted
        WHERE TriGia <= 0
    )
    BEGIN
        RAISERROR ('Trị giá phải lớn hơn 0!.', 16, 1)
        ROLLBACK TRANSACTION 
    END
	ELSE
	INSERT INTO LoaiSoHuu
	SELECT * FROM inserted
	COMMIT TRAN
END

GO
ALTER TABLE [dbo].[LoaiSoHuu] ENABLE TRIGGER [Trigger_Check_LoaiSoHuu]
GO
/****** Object:  Trigger [dbo].[Trigger_CheckUpdate_LoaiSoHuu]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigger_CheckUpdate_LoaiSoHuu]
ON [dbo].[LoaiSoHuu]
FOR UPDATE
AS
BEGIN
 BEGIN TRANSACTION
	IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE NgaySoHuu > GETDATE() 
    )
    BEGIN
        RAISERROR ('Ngày sở hữu phải nhỏ hơn hoặc bằng ngày hiện tại.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	  IF EXISTS (
			SELECT 1
			FROM inserted
        WHERE TriGia <= 0
				)
		BEGIN
        RAISERROR ('Trị giá phải lớn hơn 0!.', 16, 1)
        ROLLBACK TRANSACTION 
		END
	COMMIT TRAN
END

GO
ALTER TABLE [dbo].[LoaiSoHuu] ENABLE TRIGGER [Trigger_CheckUpdate_LoaiSoHuu]
GO
/****** Object:  Trigger [dbo].[TRG_NGAYMAT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRG_NGAYMAT]
ON [dbo].[TacGia]
FOR INSERT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM INSERTED I WHERE I.NgayMat <= I.NgaySinh)
	BEGIN
		RAISERROR('Ngày mất không được nhỏ hơn ngày sinh', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
END

GO
ALTER TABLE [dbo].[TacGia] ENABLE TRIGGER [TRG_NGAYMAT]
GO
/****** Object:  Trigger [dbo].[TRG_NGAYMAT_UPDATE]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRG_NGAYMAT_UPDATE]
ON [dbo].[TacGia]
FOR UPDATE
AS
BEGIN
	IF EXISTS (SELECT 1 FROM INSERTED I WHERE I.NgayMat <= I.NgaySinh)
	BEGIN
		RAISERROR('Ngày mất không được nhỏ hơn ngày sinh', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
END

GO
ALTER TABLE [dbo].[TacGia] ENABLE TRIGGER [TRG_NGAYMAT_UPDATE]
GO
/****** Object:  Trigger [dbo].[TRG_TENTG]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRG_TENTG]
ON [dbo].[TacGia]
AFTER INSERT
AS
BEGIN
	IF EXISTS (
        SELECT 1
        FROM TacGia T
        INNER JOIN INSERTED I ON T.HoTen = I.HoTen
        GROUP BY T.HoTen
        HAVING COUNT(*) > 1
    )
	BEGIN
		RAISERROR('Tên tác giả không được trùng', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
END

GO
ALTER TABLE [dbo].[TacGia] ENABLE TRIGGER [TRG_TENTG]
GO
/****** Object:  Trigger [dbo].[TRG_TENTG_UPDATE]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRG_TENTG_UPDATE]
ON [dbo].[TacGia]
AFTER UPDATE
AS
BEGIN
	IF EXISTS (
        SELECT 1
        FROM TacGia T
        INNER JOIN INSERTED I ON T.HoTen = I.HoTen
        GROUP BY T.HoTen
        HAVING COUNT(*) > 1
    )
	BEGIN
		RAISERROR('Tên tác giả không được trùng', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
END

GO
ALTER TABLE [dbo].[TacGia] ENABLE TRIGGER [TRG_TENTG_UPDATE]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_DELETE_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_DELETE_TPNT] ON [dbo].[TPNT]
 INSTEAD OF DELETE
 AS
 BEGIN
		BEGIN TRAN
	IF EXISTS (SELECT 1 FROM LoaiDiMuon L INNER JOIN deleted D ON L.MaSoTP = D.MaSoTP)
		BEGIN 
			ROLLBACK TRAN;
			raiserror( N'Không thể xoá tác phẩm nghệ thuật vì tác phẩm này đã tồn tại trong danh sách mượn!',16,1)
		END
	ELSE IF EXISTS (SELECT 1 FROM LoaiSoHuu L INNER JOIN deleted D ON L.MaSoTP = D.MaSoTP)
		BEGIN 
			ROLLBACK TRAN;
			raiserror( N'Không thể xoá tác phẩm nghệ thuật vì tác phẩm này đã tồn tại trong danh sách sở hữu!',16,1)
		END
	ELSE IF EXISTS (SELECT 1 FROM CT_CuocTrienLam CT INNER JOIN deleted D ON CT.MaSoTP = D.MaSoTP)
		BEGIN 
			ROLLBACK TRAN;
			raiserror( N'Không thể xoá tác phẩm nghệ thuật vì tác phẩm này đã tồn tại trong danh sách cuộc triển lãm!',16,1)
		END
	ELSE
		BEGIN
				DELETE FROM DieuKhacVaTacTuong WHERE MaSoTP = (SELECT MaSoTP FROM deleted)
				DELETE FROM HoiHoa WHERE MaSoTP = (SELECT MaSoTP FROM deleted)
				DELETE FROM LoaiHinhKhac WHERE MaSoTP = (SELECT MaSoTP FROM deleted)
				DELETE FROM TPNT WHERE MaSoTP = (SELECT MaSoTP FROM deleted)
				COMMIT TRAN
		END
 END
GO
ALTER TABLE [dbo].[TPNT] ENABLE TRIGGER [TR_BEFORE_DELETE_TPNT]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_INSERT_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_INSERT_TPNT] ON [dbo].[TPNT]
	INSTEAD OF INSERT
AS
	BEGIN
	SET XACT_ABORT ON
		BEGIN TRAN
		IF EXISTS (SELECT 1 FROM TPNT, inserted WHERE TPNT.MaSoTP = inserted.MaSoTP)
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể thêm tác phẩm nghệ thuật vì tác phẩm này đã tồn tại!',16,1)
			END
		ELSE If  not exists( Select * from TacGia , inserted
			where TacGia.MaTacGia=inserted.MaTacGia)
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể thêm tác phẩm nghệ thuật vì chưa tồn tại tác giả ứng với mã này!',16,1)
			END
		ELSE If not exists( Select * from inserted
			where inserted.NamSangTac BETWEEN 1 AND YEAR(GETDATE()))
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể thêm tác phẩm nghệ thuật vì năm sáng tác không thể nhỏ hơn hoặc bằng không và không thể lớn hơn năm hiện tại!',16,1)
			END
		ELSE
			INSERT INTO TPNT
			SELECT * FROM inserted
			COMMIT TRAN
	END
GO
ALTER TABLE [dbo].[TPNT] ENABLE TRIGGER [TR_BEFORE_INSERT_TPNT]
GO
/****** Object:  Trigger [dbo].[TR_BEFORE_UPDATE_TPNT]    Script Date: 13/07/2023 6:34:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_BEFORE_UPDATE_TPNT] ON [dbo].[TPNT]
	INSTEAD OF UPDATE
AS
	BEGIN
	SET XACT_ABORT ON
		BEGIN TRAN
		 If  not exists( Select * from TacGia 
			where TacGia.MaTacGia=(SELECT MaTacGia FROM inserted))
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể thêm tác phẩm nghệ thuật vì chưa tồn tại tác giả ứng với mã này!',16,1)
			END
		ELSE If not exists( Select * from inserted
			where inserted.NamSangTac BETWEEN 1 AND YEAR(GETDATE()))
			BEGIN
				ROLLBACK TRAN;
				raiserror( N'Không thể thêm tác phẩm nghệ thuật vì năm sáng tác không thể nhỏ hơn hoặc bằng không và không thể lớn hơn năm hiện tại!',16,1)
			END
		ELSE
			UPDATE TPNT
			SET  TenTP = (SELECT TenTP FROM inserted),
			HinhAnh = (SELECT HinhAnh FROM inserted),
			NamSangTac = (SELECT NamSangTac FROM inserted),
			ChuDe = (SELECT ChuDe FROM inserted),
			QuocGia = (SELECT QuocGia FROM inserted),
			ThoiDai = (SELECT ThoiDai FROM inserted),
			LoiDienGiai = (SELECT LoiDienGiai FROM inserted),
			MaTacGia = (SELECT MaTacGia FROM inserted)
			WHERE MaSoTP = (SELECT MaSoTP FROM inserted)
			COMMIT TRAN
	END
GO
ALTER TABLE [dbo].[TPNT] ENABLE TRIGGER [TR_BEFORE_UPDATE_TPNT]
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BoSuuTap"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_BO_SUU_TAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_BO_SUU_TAP'
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TPNT"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TacGia"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 242
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_SELECTTACPHAM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_SELECTTACPHAM'
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TacGia"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_TAC_GIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_TAC_GIA'
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TPNT"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 5
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_TPNT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_TPNT'
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TPNT"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "DKTT"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 242
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListDieuKhacTacTuong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListDieuKhacTacTuong'
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TPNT"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListTPNT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListTPNT'
GO

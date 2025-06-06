USE [master]
GO
/****** Object:  Database [QLBH_TCH_UNIQLO]    Script Date: 4/17/2025 5:15:41 AM ******/
CREATE DATABASE [QLBH_TCH_UNIQLO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH_TCH_UNIQLO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBH_TCH_UNIQLO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_TCH_UNIQLO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBH_TCH_UNIQLO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH_TCH_UNIQLO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLBH_TCH_UNIQLO]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[MaBaoCao] [int] NOT NULL,
	[TenBaoCao] [nvarchar](100) NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[NgayLap] [datetime] NULL,
	[DoanhThu] [float] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaNhanVien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoPhan](
	[MaBoPhan] [int] NOT NULL,
	[TenBoPhan] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDoiTra]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDoiTra](
	[MaYeuCau] [int] NOT NULL,
	[MaCTSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[TrangThaiSanPham] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaYeuCau] ASC,
	[MaCTSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDonHang] [int] NOT NULL,
	[MaCTSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[MaCTSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[MaCTSanPham] [int] NOT NULL,
	[KichThuoc] [nvarchar](10) NULL,
	[MauSac] [nvarchar](30) NULL,
	[LuongHang] [int] NULL,
	[GiaTien] [float] NULL,
	[MaSanPham] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] NOT NULL,
	[NgayTao] [datetime] NULL,
	[TrangThaiDonHang] [nvarchar](50) NULL,
	[TienHang] [float] NULL,
	[ThueVAT] [float] NULL,
	[MaKhachHang] [int] NULL,
	[MaThanhToan] [int] NULL,
	[MaNhanVien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [nvarchar](15) NULL,
	[GioiTinh] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [int] NOT NULL,
	[TenLoaiSanPham] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NULL,
	[SDT] [nvarchar](15) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[MaBoPhan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[MoTa] [nvarchar](max) NULL,
	[MaLoaiSanPham] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[MaThanhToan] [int] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
	[TienThanhToan] [float] NULL,
	[PhuongThucThanhToan] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhToan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauDoiTra]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauDoiTra](
	[MaYeuCau] [int] NOT NULL,
	[NgayTao] [datetime] NULL,
	[LyDo] [nvarchar](200) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaKhachHang] [int] NULL,
	[MaDonHang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaYeuCau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (1, N'Bán hàng')
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (2, N'Kho')
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (3, N'Quản lý')
GO
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (1, 110, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (2, 121, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (3, 129, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (4, 123, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (5, 123, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (6, 127, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (7, 108, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (8, 112, 1, N'Chưa sử dụng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (9, 172, 5, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (9, 202, 2, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (10, 172, 5, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (10, 202, 2, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (11, 172, 5, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (11, 202, 2, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (12, 110, 4, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (12, 147, 2, N'Trả hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (13, 101, 1, N'Đổi hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (14, 101, 1, N'Đổi hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (15, 101, 1, N'Đổi hàng')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (17, 101, 1, N'')
INSERT [dbo].[ChiTietDoiTra] ([MaYeuCau], [MaCTSanPham], [SoLuong], [TrangThaiSanPham]) VALUES (18, 124, 1, N'Đổi hàng')
GO
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (1, 110, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (1, 127, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (1, 129, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (2, 121, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (3, 126, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (4, 129, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (5, 119, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (5, 123, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (5, 128, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (6, 124, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (7, 116, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (7, 124, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (7, 130, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (8, 102, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (8, 108, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (8, 123, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (9, 106, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (9, 117, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (9, 127, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (10, 121, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (11, 105, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (11, 113, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (12, 115, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (12, 122, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (13, 103, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (13, 122, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (14, 120, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (15, 122, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (16, 125, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (17, 101, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (17, 107, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (17, 116, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (18, 104, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (18, 105, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (19, 108, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (20, 106, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (20, 112, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (26, 120, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (26, 197, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (27, 113, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (27, 216, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (28, 101, 4)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (29, 106, 6)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (30, 101, 4)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (31, 101, 4)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (32, 113, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (33, 156, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (34, 108, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (35, 101, 4)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (36, 110, 4)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (36, 147, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (37, 172, 5)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (37, 202, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (38, 101, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (40, 102, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (41, 101, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (42, 120, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (43, 139, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (44, 101, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (45, 124, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (46, 101, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (47, 159, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (48, 152, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (49, 108, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (50, 139, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (51, 116, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (52, 103, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (53, 121, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (54, 116, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (55, 101, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaCTSanPham], [SoLuong]) VALUES (56, 101, 2)
GO
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (101, N'S', N'Trắng', 28, 466095, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (102, N'S', N'Đen', 23, 656239, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (103, N'S', N'Xanh', 18, 744175, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (104, N'M', N'Trắng', 88, 405606, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (105, N'M', N'Đen', 66, 651248, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (106, N'M', N'Xanh', 28, 545239, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (107, N'L', N'Trắng', 98, 528164, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (108, N'L', N'Đen', 31, 513910, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (109, N'L', N'Xanh', 84, 523308, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (110, N'XL', N'Trắng', 76, 541027, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (111, N'XL', N'Đen', 71, 509016, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (112, N'XL', N'Xanh', 90, 332470, 1)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (113, N'S', N'Trắng', 43, 639869, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (114, N'S', N'Đen', 68, 381480, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (115, N'S', N'Xanh', 98, 795750, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (116, N'M', N'Trắng', 49, 624800, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (117, N'M', N'Đen', 90, 199425, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (118, N'M', N'Xanh', 58, 499850, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (119, N'L', N'Trắng', 46, 649770, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (120, N'L', N'Đen', 88, 536902, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (121, N'L', N'Xanh', 76, 662246, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (122, N'XL', N'Trắng', 74, 423082, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (123, N'XL', N'Đen', 85, 695171, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (124, N'XL', N'Xanh', 36, 287914, 2)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (125, N'S', N'Trắng', 54, 739490, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (126, N'S', N'Đen', 98, 550470, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (127, N'S', N'Xanh', 31, 445277, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (128, N'M', N'Trắng', 59, 434552, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (129, N'M', N'Đen', 45, 353511, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (130, N'M', N'Xanh', 21, 247458, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (131, N'L', N'Trắng', 51, 697216, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (132, N'L', N'Đen', 98, 275365, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (133, N'L', N'Xanh', 78, 633572, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (134, N'XL', N'Trắng', 100, 402880, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (135, N'XL', N'Đen', 69, 717392, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (136, N'XL', N'Xanh', 71, 454836, 3)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (137, N'S', N'Trắng', 38, 204814, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (138, N'S', N'Đen', 33, 644798, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (139, N'S', N'Xanh', 43, 383430, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (140, N'M', N'Trắng', 86, 686115, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (141, N'M', N'Đen', 26, 783482, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (142, N'M', N'Xanh', 51, 326253, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (143, N'L', N'Trắng', 78, 338816, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (144, N'L', N'Đen', 79, 755932, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (145, N'L', N'Xanh', 91, 531711, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (146, N'XL', N'Trắng', 76, 728298, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (147, N'XL', N'Đen', 76, 773485, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (148, N'XL', N'Xanh', 77, 365889, 4)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (149, N'S', N'Trắng', 80, 670932, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (150, N'S', N'Đen', 53, 458249, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (151, N'S', N'Xanh', 55, 745622, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (152, N'M', N'Trắng', 80, 449867, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (153, N'M', N'Đen', 55, 660239, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (154, N'M', N'Xanh', 29, 498607, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (155, N'L', N'Trắng', 50, 483913, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (156, N'L', N'Đen', 61, 534239, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (157, N'L', N'Xanh', 89, 283491, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (158, N'XL', N'Trắng', 37, 357157, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (159, N'XL', N'Đen', 47, 600641, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (160, N'XL', N'Xanh', 39, 423345, 5)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (161, N'S', N'Trắng', 28, 634020, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (162, N'S', N'Đen', 72, 545954, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (163, N'S', N'Xanh', 89, 687557, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (164, N'M', N'Trắng', 73, 264290, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (165, N'M', N'Đen', 46, 639552, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (166, N'M', N'Xanh', 69, 219480, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (167, N'L', N'Trắng', 93, 597858, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (168, N'L', N'Đen', 81, 205182, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (169, N'L', N'Xanh', 65, 512118, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (170, N'XL', N'Trắng', 69, 638375, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (171, N'XL', N'Đen', 88, 771661, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (172, N'XL', N'Xanh', 112, 430251, 6)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (173, N'S', N'Trắng', 82, 429080, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (174, N'S', N'Đen', 54, 656007, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (175, N'S', N'Xanh', 82, 229434, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (176, N'M', N'Trắng', 69, 551457, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (177, N'M', N'Đen', 71, 372061, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (178, N'M', N'Xanh', 79, 332827, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (179, N'L', N'Trắng', 99, 759069, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (180, N'L', N'Đen', 23, 612160, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (181, N'L', N'Xanh', 95, 790807, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (182, N'XL', N'Trắng', 23, 287025, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (183, N'XL', N'Đen', 74, 341291, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (184, N'XL', N'Xanh', 79, 389556, 7)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (185, N'S', N'Trắng', 26, 471793, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (186, N'S', N'Đen', 68, 542254, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (187, N'S', N'Xanh', 47, 675786, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (188, N'M', N'Trắng', 61, 552894, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (189, N'M', N'Đen', 68, 490773, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (190, N'M', N'Xanh', 73, 463525, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (191, N'L', N'Trắng', 30, 692152, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (192, N'L', N'Đen', 22, 764621, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (193, N'L', N'Xanh', 26, 565960, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (194, N'XL', N'Trắng', 48, 270951, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (195, N'XL', N'Đen', 25, 231537, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (196, N'XL', N'Xanh', 51, 408044, 8)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (197, N'S', N'Trắng', 20, 358784, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (198, N'S', N'Đen', 50, 331352, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (199, N'S', N'Xanh', 80, 318946, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (200, N'M', N'Trắng', 92, 427552, 9)
GO
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (201, N'M', N'Đen', 79, 467690, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (202, N'M', N'Xanh', 73, 374939, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (203, N'L', N'Trắng', 97, 319096, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (204, N'L', N'Đen', 40, 525147, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (205, N'L', N'Xanh', 33, 225925, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (206, N'XL', N'Trắng', 59, 592537, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (207, N'XL', N'Đen', 70, 406963, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (208, N'XL', N'Xanh', 29, 453646, 9)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (209, N'S', N'Trắng', 33, 515232, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (210, N'S', N'Đen', 96, 325935, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (211, N'S', N'Xanh', 92, 242064, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (212, N'M', N'Trắng', 64, 757623, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (213, N'M', N'Đen', 74, 587571, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (214, N'M', N'Xanh', 28, 729538, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (215, N'L', N'Trắng', 63, 212266, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (216, N'L', N'Đen', 72, 713013, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (217, N'L', N'Xanh', 33, 653582, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (218, N'XL', N'Trắng', 66, 681071, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (219, N'XL', N'Đen', 39, 655641, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (220, N'XL', N'Xanh', 42, 746091, 10)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (221, N'S', N'Trắng', 54, 763315, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (222, N'S', N'Đen', 81, 686455, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (223, N'S', N'Xanh', 75, 480433, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (224, N'M', N'Trắng', 61, 456420, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (225, N'M', N'Đen', 31, 491477, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (226, N'M', N'Xanh', 77, 454709, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (227, N'L', N'Trắng', 79, 796530, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (228, N'L', N'Đen', 98, 596399, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (229, N'L', N'Xanh', 63, 229094, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (230, N'XL', N'Trắng', 83, 539802, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (231, N'XL', N'Đen', 43, 710233, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (232, N'XL', N'Xanh', 47, 571060, 11)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (233, N'S', N'Trắng', 53, 555871, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (234, N'S', N'Đen', 55, 488688, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (235, N'S', N'Xanh', 91, 209644, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (236, N'M', N'Trắng', 86, 399337, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (237, N'M', N'Đen', 30, 452080, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (238, N'M', N'Xanh', 72, 711311, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (239, N'L', N'Trắng', 91, 450997, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (240, N'L', N'Đen', 80, 713663, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (241, N'L', N'Xanh', 77, 217080, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (242, N'XL', N'Trắng', 31, 507528, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (243, N'XL', N'Đen', 48, 623045, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (244, N'XL', N'Xanh', 51, 520080, 12)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (245, N'S', N'Trắng', 94, 585945, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (246, N'S', N'Đen', 80, 779358, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (247, N'S', N'Xanh', 87, 559455, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (248, N'M', N'Trắng', 74, 776124, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (249, N'M', N'Đen', 62, 567900, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (250, N'M', N'Xanh', 78, 483076, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (251, N'L', N'Trắng', 59, 462615, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (252, N'L', N'Đen', 49, 325516, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (253, N'L', N'Xanh', 44, 529876, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (254, N'XL', N'Trắng', 35, 760894, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (255, N'XL', N'Đen', 43, 399845, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (256, N'XL', N'Xanh', 47, 706719, 13)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (257, N'S', N'Trắng', 55, 749121, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (258, N'S', N'Đen', 96, 495745, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (259, N'S', N'Xanh', 32, 402547, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (260, N'M', N'Trắng', 57, 437533, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (261, N'M', N'Đen', 66, 387158, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (262, N'M', N'Xanh', 58, 213835, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (263, N'L', N'Trắng', 88, 331731, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (264, N'L', N'Đen', 55, 246726, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (265, N'L', N'Xanh', 26, 779238, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (266, N'XL', N'Trắng', 57, 331413, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (267, N'XL', N'Đen', 82, 306570, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (268, N'XL', N'Xanh', 21, 497151, 14)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (269, N'S', N'Trắng', 80, 700968, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (270, N'S', N'Đen', 76, 556256, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (271, N'S', N'Xanh', 43, 252872, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (272, N'M', N'Trắng', 52, 699935, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (273, N'M', N'Đen', 34, 267517, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (274, N'M', N'Xanh', 71, 714633, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (275, N'L', N'Trắng', 29, 255213, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (276, N'L', N'Đen', 39, 355445, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (277, N'L', N'Xanh', 92, 517594, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (278, N'XL', N'Trắng', 30, 459247, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (279, N'XL', N'Đen', 35, 784181, 15)
INSERT [dbo].[ChiTietSanPham] ([MaCTSanPham], [KichThuoc], [MauSac], [LuongHang], [GiaTien], [MaSanPham]) VALUES (280, N'XL', N'Xanh', 73, 435650, 15)
GO
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (1, CAST(N'2025-03-23T12:01:00.000' AS DateTime), N'Đã hủy', 2326119, 232611.9, 18, 1, 16)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (2, CAST(N'2025-03-27T12:49:00.000' AS DateTime), N'Đã trả hàng', 1324492, 132449.2, 22, 2, 27)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (3, CAST(N'2025-03-22T10:40:00.000' AS DateTime), N'Đã nhận hàng', 550470, 55047, 11, 3, 24)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (4, CAST(N'2025-03-19T13:46:00.000' AS DateTime), N'Đã hủy', 353511, 35351.1, 20, 4, 16)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (5, CAST(N'2025-03-06T11:08:00.000' AS DateTime), N'Đã trả hàng', 2863815, 286381.5, 15, 5, 21)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (6, CAST(N'2025-03-24T13:51:00.000' AS DateTime), N'Đã nhận hàng', 575828, 57582.8, 21, 6, 21)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (7, CAST(N'2025-03-28T14:54:00.000' AS DateTime), N'Đã nhận hàng', 1695544, 169554.4, 27, 7, 16)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (8, CAST(N'2025-03-15T13:43:00.000' AS DateTime), N'Đã hủy', 3730640, 373064, 4, 8, 15)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (9, CAST(N'2025-03-01T17:56:00.000' AS DateTime), N'Đã hủy', 1635218, 163521.8, 25, 9, 7)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (10, CAST(N'2025-03-04T10:02:00.000' AS DateTime), N'Đã nhận hàng', 1324492, 132449.2, 23, 10, 21)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (11, CAST(N'2025-03-08T16:08:00.000' AS DateTime), N'Đã nhận hàng', 2582234, 258223.4, 24, 11, 27)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (12, CAST(N'2025-03-14T09:53:00.000' AS DateTime), N'Đã nhận hàng', 2437664, 243766.4, 5, 12, 11)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (13, CAST(N'2025-03-15T15:15:00.000' AS DateTime), N'Đã nhận hàng', 1590339, 159033.9, 3, 13, 15)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (14, CAST(N'2025-03-13T12:12:00.000' AS DateTime), N'Đã nhận hàng', 1073804, 107380.4, 26, 14, 9)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (15, CAST(N'2025-03-02T13:15:00.000' AS DateTime), N'Đã nhận hàng', 423082, 42308.2, 7, 15, 12)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (16, CAST(N'2025-03-19T11:52:00.000' AS DateTime), N'Đã nhận hàng', 1478980, 147898, 19, 16, 10)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (17, CAST(N'2025-03-09T10:08:00.000' AS DateTime), N'Đã nhận hàng', 2243859, 224385.9, 14, 17, 18)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (18, CAST(N'2025-03-12T11:37:00.000' AS DateTime), N'Đã nhận hàng', 1056854, 105685.4, 8, 18, 21)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (19, CAST(N'2025-03-24T14:33:00.000' AS DateTime), N'Đã trả hàng', 513910, 51391, 28, 19, 15)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (20, CAST(N'2025-03-17T17:06:00.000' AS DateTime), N'Đã hủy', 877709, 87770.9, 2, 20, 12)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (26, CAST(N'2025-03-13T15:46:00.000' AS DateTime), N'Đã nhận hàng', 1791372, 179137.2, 4, 21, 18)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (27, CAST(N'2025-03-12T11:43:00.000' AS DateTime), N'Đã nhận hàng', 1352882, 135288.2, 30, 22, 27)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (28, CAST(N'2025-04-15T03:26:11.633' AS DateTime), N'Chờ thanh toán', 466095, 46610, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (29, CAST(N'2025-04-15T03:27:54.213' AS DateTime), N'Chờ thanh toán', 545239, 54524, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (30, CAST(N'2025-04-15T04:31:25.517' AS DateTime), N'Chờ thanh toán', 466095, 46610, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (31, CAST(N'2025-04-15T04:34:18.107' AS DateTime), N'Chờ thanh toán', 466095, 46610, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (32, CAST(N'2025-04-15T05:29:40.430' AS DateTime), N'Chờ thanh toán', 639869, 63987, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (33, CAST(N'2025-04-15T05:51:10.177' AS DateTime), N'Đã nhận hàng', 534239, 53424, 1, 23, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (34, CAST(N'2025-04-15T06:00:00.937' AS DateTime), N'Đã nhận hàng', 513910, 51391, 1, 24, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (35, CAST(N'2025-04-15T12:51:59.003' AS DateTime), N'Đã nhận hàng', 466095, 46610, 1, 25, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (36, CAST(N'2025-04-16T04:18:28.547' AS DateTime), N'Đã hoàn tiền', 1314512, 131451, 1, 26, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (37, CAST(N'2025-04-16T04:19:06.190' AS DateTime), N'Đã hoàn tiền', 805190, 80519, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (38, CAST(N'2025-04-16T06:32:31.523' AS DateTime), N'Đã nhận hàng', 932190, 93219, 1, 28, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (39, CAST(N'2025-04-16T06:33:31.510' AS DateTime), N'Chờ thanh toán', 0, 0, 1, NULL, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (40, CAST(N'2025-04-16T06:34:42.543' AS DateTime), N'Đã nhận hàng', 1312478, 131248, 1, 29, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (41, CAST(N'2025-04-16T06:42:11.727' AS DateTime), N'Đã hoàn tiền', 466095, 46610, 1, 30, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (42, CAST(N'2025-04-16T13:44:11.263' AS DateTime), N'Đã thanh toán', 1073804, 107380, 1, 31, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (43, CAST(N'2025-04-16T13:46:21.740' AS DateTime), N'Đã thanh toán', 1150290, 115029, 1, 32, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (44, CAST(N'2025-04-16T18:39:55.500' AS DateTime), N'Đã thanh toán', 466095, 46610, 1, 33, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (45, CAST(N'2025-04-17T00:11:43.607' AS DateTime), N'Đã thanh toán', 575828, 57583, 1, 34, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (46, CAST(N'2025-04-17T00:12:51.403' AS DateTime), N'Đã nhận hàng', 466095, 46610, 1, 35, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (47, CAST(N'2025-04-17T00:15:23.890' AS DateTime), N'Đã thanh toán', 1201282, 120128, 1, 36, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (48, CAST(N'2025-04-17T00:17:05.230' AS DateTime), N'Đã thanh toán', 899734, 89973, 1, 37, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (49, CAST(N'2025-04-17T00:21:16.847' AS DateTime), N'Đã thanh toán', 1027820, 102782, 1, 38, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (50, CAST(N'2025-04-17T00:22:23.507' AS DateTime), N'Đã thanh toán', 766860, 76686, 1, 39, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (51, CAST(N'2025-04-17T00:25:08.360' AS DateTime), N'Đã thanh toán', 1874400, 187440, 1, 40, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (52, CAST(N'2025-04-17T00:32:22.050' AS DateTime), N'Đã thanh toán', 744175, 74418, 1, 41, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (53, CAST(N'2025-04-17T00:39:17.160' AS DateTime), N'Đã thanh toán', 662246, 66225, 1, 42, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (54, CAST(N'2025-04-17T00:41:52.110' AS DateTime), N'Đã thanh toán', 1874400, 187440, 1, 43, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (55, CAST(N'2025-04-17T00:42:34.007' AS DateTime), N'Đã thanh toán', 466095, 46610, 1, 44, 5)
INSERT [dbo].[DonHang] ([MaDonHang], [NgayTao], [TrangThaiDonHang], [TienHang], [ThueVAT], [MaKhachHang], [MaThanhToan], [MaNhanVien]) VALUES (56, CAST(N'2025-04-17T04:31:01.980' AS DateTime), N'Đã thanh toán', 932190, 93219, 1, 45, 5)
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (1, N'Khách hàng vãng lai', NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (2, N'Trần Thị Cúc', N'tranthicuc@uniqlo.vn', N'48 Đường Trần Hưng Đạo, Q.3', N'0945496015', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (3, N'Lê Hoàng Dũng', N'lehoangdung@uniqlo.vn', N'24 Đường Trần Hưng Đạo, Q.12', N'0984252420', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (4, N'Phạm Thị Hương', N'phamthihuong@uniqlo.vn', N'29 Đường Lê Lợi, Q.5', N'0991178885', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (5, N'Hoàng Văn Khánh', N'hoangvankhanh@uniqlo.vn', N'36 Đường Lê Lợi, Q.4', N'0995125977', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (6, N'Đỗ Thị Lan', N'dothilan@uniqlo.vn', N'43 Đường Hai Bà Trưng, Q.5', N'0916818112', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (7, N'Nguyễn Đức Long Chun', N'nguyenduclong@uniqlo.vn', N'21 Đường Hai Bà Trưng, Q.5', N'0915917225', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (8, N'Bùi Thị Mai', N'buithimai@uniqlo.vn', N'10 Đường Lê Lợi, Q.3', N'0995511909', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (9, N'Vũ Văn Nam', N'vuvannam@uniqlo.vn', N'43 Đường Nguyễn Trãi, Q.12', N'0969302158', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (10, N'Trịnh Thị Ngọc', N'trinhthingoc@uniqlo.vn', N'80 Đường Hai Bà Trưng, Q.9', N'0911297845', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (11, N'Lê Minh Nhật', N'leminhnhat@uniqlo.vn', N'24 Đường Trần Hưng Đạo, Q.12', N'0930005727', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (12, N'Phan Thị Oanh', N'phanthioanh@uniqlo.vn', N'79 Đường Trần Hưng Đạo, Q.6', N'0988183110', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (13, N'Ngô Văn Phát', N'ngovanphat@uniqlo.vn', N'80 Đường Nguyễn Trãi, Q.7', N'0927105448', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (14, N'Đinh Thị Quyên', N'dinhthiquyen@uniqlo.vn', N'15 Đường Lê Lợi, Q.6', N'0915354599', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (15, N'Trần Văn Sang', N'tranvansang@uniqlo.vn', N'55 Đường Nguyễn Trãi, Q.11', N'0943491314', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (16, N'Lưu Thị Trang', N'luuthitrang@uniqlo.vn', N'95 Đường Trần Hưng Đạo, Q.6', N'0985146293', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (17, N'Nguyễn Văn Thành', N'nguyenvanthanh@uniqlo.vn', N'62 Đường Nguyễn Trãi, Q.4', N'0931810617', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (18, N'Vũ Thị Uyên', N'vuthiuyen@uniqlo.vn', N'32 Đường Hai Bà Trưng, Q.1', N'0934073380', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (19, N'Đặng Minh Vũ', N'dangminhvu@uniqlo.vn', N'52 Đường Hai Bà Trưng, Q.11', N'0943308443', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (20, N'Hồ Thị Xuân', N'hothixuan@uniqlo.vn', N'44 Đường Nguyễn Trãi, Q.12', N'0924508349', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (21, N'Đỗ Văn An', N'dovanan@uniqlo.vn', N'58 Đường Trần Hưng Đạo, Q.8', N'0939854548', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (22, N'Trần Thị Bình', N'tranthibinh@uniqlo.vn', N'35 Đường Hai Bà Trưng, Q.6', N'0950962024', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (23, N'Lê Văn Cường', N'levancuong@uniqlo.vn', N'39 Đường Nguyễn Trãi, Q.1', N'0998588154', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (24, N'Nguyễn Thị Diễm', N'nguyenthidiem@uniqlo.vn', N'34 Đường Hai Bà Trưng, Q.6', N'0947393469', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (25, N'Phạm Văn Giang', N'phamvangiang@uniqlo.vn', N'18 Đường Lê Lợi, Q.6', N'0996098221', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (26, N'Bùi Thị Hiền', N'buithihien@uniqlo.vn', N'75 Đường Hai Bà Trưng, Q.11', N'0981969657', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (27, N'Vũ Quang Huy', N'vuquanghuy@uniqlo.vn', N'52 Đường Trần Hưng Đạo, Q.2', N'0945059710', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (28, N'Ngô Thị Kim', N'ngothikim@uniqlo.vn', N'32 Đường Lê Lợi, Q.1', N'0924549543', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (29, N'Trần Văn Lực', N'tranvanluc@uniqlo.vn', N'86 Đường Hai Bà Trưng, Q.6', N'0952101056', N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Email], [DiaChi], [SDT], [GioiTinh]) VALUES (30, N'Nguyễn Thị Mai', N'nguyenthimai@uniqlo.vn', N'65 Đường Trần Hưng Đạo, Q.7', N'0987388337', N'Nữ')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (1, N'Áo thun nam')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (2, N'Áo thun nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (3, N'Áo sơ mi nam')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (4, N'Áo sơ mi nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (5, N'Áo khoác gió')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (6, N'Áo giữ nhiệt')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (7, N'Quần jeans nam')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (8, N'Quần jeans nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (9, N'Quần short nam')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (10, N'Quần legging nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (11, N'Chân váy nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (12, N'Đầm liền nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (13, N'Áo len nam')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (14, N'Áo len nữ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (15, N'Áo bra thể thao nữ')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (2, N'Trần Hữu Bảo', N'tranhuubao@uniqlo.vn', N'matkhau123', N'44 Đường Nguyễn Huệ, Q.2', N'tranhuubao@uniqlo.vn', N'0949392920', CAST(N'2001-03-15T00:00:00.000' AS DateTime), N'Nam', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (5, N'Hoàng Quốc Đạt', N'hoangquocdat@uniqlo.vn', N'matkhau123', N'10 Đường Nguyễn Huệ, Q.8', N'hoangquocdat@uniqlo.vn', N'0912614124', CAST(N'1996-06-27T00:00:00.000' AS DateTime), N'Nam', 3)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (7, N'Đặng Tuấn Hùng', N'dangtuanhung@uniqlo.vn', N'matkhau123', N'18 Đường Trần Hưng Đạo, Q.3', N'dangtuanhung@uniqlo.vn', N'0998550256', CAST(N'2002-09-06T00:00:00.000' AS DateTime), N'Nam', 3)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (9, N'Bùi Văn Lực', N'buivanluc@uniqlo.vn', N'matkhau123', N'95 Đường Nguyễn Huệ, Q.8', N'buivanluc@uniqlo.vn', N'0979467853', CAST(N'2002-02-08T00:00:00.000' AS DateTime), N'Nam', 2)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (10, N'Huỳnh Ngọc Minh', N'huynhngocminh@uniqlo.vn', N'matkhau1234', N'18 Đường Nguyễn Huệ, Q.1', N'huynhngocminh@uniqlo.vn', N'0988961459', CAST(N'2003-04-19T00:00:00.000' AS DateTime), N'Nam', 3)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (11, N'Nguyễn Văn Nam', N'nguyenvannam@uniqlo.vn', N'matkhau123', N'10 Đường Lê Lợi, Q.12', N'nguyenvannam@uniqlo.vn', N'0994705205', CAST(N'1995-04-03T00:00:00.000' AS DateTime), N'Nam', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (12, N'Trần Anh Quân', N'trananhquan@uniqlo.vn', N'matkhau123', N'52 Đường Lê Lợi, Q.9', N'trananhquan@uniqlo.vn', N'0941944441', CAST(N'1999-11-16T00:00:00.000' AS DateTime), N'Nam', 2)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (15, N'Vũ Minh Trí', N'vuminhtri@uniqlo.vn', N'matkhau123', N'62 Đường Hai Bà Trưng, Q.12', N'vuminhtri@uniqlo.vn', N'0917270733', CAST(N'2005-11-21T00:00:00.000' AS DateTime), N'Nam', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (16, N'Nguyễn Thị Ánh Nhi', N'nguyenthianh@uniqlo.vn', N'matkhau123', N'17 Đường Hai Bà Trưng, Q.12', N'nguyenthianh@uniqlo.vn', N'0955540424', CAST(N'1996-04-07T00:00:00.000' AS DateTime), N'Nữ', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (17, N'Trần Thị Bích', N'tranthibich@uniqlo.vn', N'matkhau123', N'78 Đường Hai Bà Trưng, Q.3', N'tranthibich@uniqlo.vn', N'0966623995', CAST(N'1997-05-15T00:00:00.000' AS DateTime), N'Nữ', 2)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (18, N'Lê Thị Cẩm', N'lethicam@uniqlo.vn', N'matkhau123', N'19 Đường Hai Bà Trưng, Q.9', N'lethicam@uniqlo.vn', N'0923141087', CAST(N'1995-11-18T00:00:00.000' AS DateTime), N'Nữ', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (21, N'Ngô Thị Hà', N'ngothiha@uniqlo.vn', N'matkhau123', N'46 Đường Hai Bà Trưng, Q.12', N'ngothiha@uniqlo.vn', N'0984593961', CAST(N'2005-12-16T00:00:00.000' AS DateTime), N'Nữ', 2)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (22, N'Đặng Thị Hồng', N'dangthihong@uniqlo.vn', N'matkhau123', N'34 Đường Nguyễn Huệ, Q.4', N'dangthihong@uniqlo.vn', N'0917849494', CAST(N'2004-12-18T00:00:00.000' AS DateTime), N'Nữ', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (24, N'Bùi Thị Lệ', N'buithile@uniqlo.vn', N'matkhau123', N'30 Đường Lê Lợi, Q.9', N'buithile@uniqlo.vn', N'0920752378', CAST(N'1997-02-20T00:00:00.000' AS DateTime), N'Nữ', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (26, N'Nguyễn Thị Ngọc', N'nguyenthingoc@uniqlo.vn', N'matkhau123', N'15 Đường Lê Lợi, Q.7', N'nguyenthingoc@uniqlo.vn', N'0998231132', CAST(N'2004-10-17T00:00:00.000' AS DateTime), N'Nữ', 3)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (27, N'Trần Thị Quỳnh', N'tranthiquynh@uniqlo.vn', N'matkhau123', N'43 Đường Trần Hưng Đạo, Q.11', N'tranthiquynh@uniqlo.vn', N'0952169044', CAST(N'1998-05-13T00:00:00.000' AS DateTime), N'Nữ', 2)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (29, N'Phan Thị Trang', N'phanthitrang@uniqlo.vn', N'matkhau123', N'82 Đường Lê Lợi, Q.2', N'phanthitrang@uniqlo.vn', N'0982160068', CAST(N'1998-09-09T00:00:00.000' AS DateTime), N'Nữ', 2)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [DiaChi], [Email], [SDT], [NgaySinh], [GioiTinh], [MaBoPhan]) VALUES (30, N'ok', N'123', N'123', N'', N'', N'123', CAST(N'2025-04-15T19:27:27.087' AS DateTime), N'Nữ', 2)
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (1, N'Áo thun cổ tròn nam DRY', N'Chất liệu nhanh khô, co giãn thoải mái', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (2, N'Áo thun nữ AIRism', N'Thoáng khí, mát mẻ cho mùa hè', 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (3, N'Áo sơ mi nam oxford', N'Vải cotton dày, form chuẩn công sở', 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (4, N'Áo sơ mi nữ chiffon', N'Chất liệu nhẹ, mềm mại', 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (5, N'Áo khoác gió chống nước', N'Cản gió và nước, siêu nhẹ', 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (6, N'Áo giữ nhiệt HEATTECH cổ tròn', N'Giữ ấm tối ưu mùa đông', 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (7, N'Quần jeans nam skinny', N'Ôm dáng, co giãn tốt', 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (8, N'Quần jeans nữ suông', N'Form ống rộng hiện đại', 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (9, N'Quần short nam thể thao', N'Vải nhanh khô, năng động', 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (10, N'Quần legging nữ dáng ôm', N'Co giãn tốt, thoải mái khi vận động', 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (11, N'Chân váy xếp ly dài', N'Phong cách nữ tính, dễ phối đồ', 11)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (12, N'Đầm liền cổ vuông nữ', N'Thiết kế tinh tế, chất liệu mềm mại', 12)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (13, N'Áo len nam cổ tròn', N'Chất len mềm mịn, thoáng khí', 13)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (14, N'Áo len nữ cổ tim', N'Dáng vừa, nhẹ nhàng', 14)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (15, N'Áo bra thể thao nữ AIRism', N'Thoáng khí, hỗ trợ vận động', 15)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [MaLoaiSanPham]) VALUES (16, N'sdsfd', N'cadcaca', 6)
GO
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (1, CAST(N'2025-03-23T13:28:00.000' AS DateTime), 2558730.9, N'Tiền mặt')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (2, CAST(N'2025-03-27T13:32:00.000' AS DateTime), 1456941.2, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (3, CAST(N'2025-03-22T11:34:00.000' AS DateTime), 605517, N'MOMO')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (4, CAST(N'2025-03-19T14:38:00.000' AS DateTime), 388862.1, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (5, CAST(N'2025-03-06T11:55:00.000' AS DateTime), 3150196.5, N'MOMO')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (6, CAST(N'2025-03-24T14:15:00.000' AS DateTime), 633410.8, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (7, CAST(N'2025-03-28T15:10:00.000' AS DateTime), 1865098.4, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (8, CAST(N'2025-03-15T14:11:00.000' AS DateTime), 4103704, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (9, CAST(N'2025-03-01T19:10:00.000' AS DateTime), 1798739.8, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (10, CAST(N'2025-03-04T11:20:00.000' AS DateTime), 1456941.2, N'Tiền mặt')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (11, CAST(N'2025-03-08T17:32:00.000' AS DateTime), 2840457.4, N'MOMO')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (12, CAST(N'2025-03-14T10:12:00.000' AS DateTime), 2681430.4, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (13, CAST(N'2025-03-15T16:39:00.000' AS DateTime), 1749372.9, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (14, CAST(N'2025-03-13T12:38:00.000' AS DateTime), 1181184.4, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (15, CAST(N'2025-03-02T13:38:00.000' AS DateTime), 465390.2, N'ZaloPay')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (16, CAST(N'2025-03-19T12:25:00.000' AS DateTime), 1626878, N'ZaloPay')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (17, CAST(N'2025-03-09T10:26:00.000' AS DateTime), 2468244.9, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (18, CAST(N'2025-03-12T12:25:00.000' AS DateTime), 1162539.4, N'Tiền mặt')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (19, CAST(N'2025-03-24T15:48:00.000' AS DateTime), 565301, N'MOMO')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (20, CAST(N'2025-03-17T18:27:00.000' AS DateTime), 965479.9, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (21, CAST(N'2025-03-13T16:38:00.000' AS DateTime), 1970509.2, N'Thẻ tín dụng')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (22, CAST(N'2025-03-12T11:58:00.000' AS DateTime), 1488170.2, N'Tiền mặt')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (23, CAST(N'2025-04-15T05:51:44.010' AS DateTime), 587663, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (24, CAST(N'2025-04-15T06:00:22.830' AS DateTime), 565301, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (25, CAST(N'2025-04-15T12:52:17.603' AS DateTime), 512705, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (26, CAST(N'2025-04-16T04:18:55.123' AS DateTime), 1445963, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (27, CAST(N'2025-04-16T04:23:30.883' AS DateTime), 3581864, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (28, CAST(N'2025-04-16T06:32:47.647' AS DateTime), 1025409, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (29, CAST(N'2025-04-16T06:34:59.507' AS DateTime), 1443726, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (30, CAST(N'2025-04-16T06:42:24.723' AS DateTime), 512705, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (31, CAST(N'2025-04-16T13:44:36.217' AS DateTime), 1181184, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (32, CAST(N'2025-04-16T13:46:40.323' AS DateTime), 1265319, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (33, CAST(N'2025-04-16T18:40:09.403' AS DateTime), 512705, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (34, CAST(N'2025-04-17T00:12:06.087' AS DateTime), 633411, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (35, CAST(N'2025-04-17T00:13:04.967' AS DateTime), 512705, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (36, CAST(N'2025-04-17T00:15:38.333' AS DateTime), 1321410, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (37, CAST(N'2025-04-17T00:17:17.503' AS DateTime), 989707, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (38, CAST(N'2025-04-17T00:21:28.870' AS DateTime), 1130602, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (39, CAST(N'2025-04-17T00:22:35.823' AS DateTime), 843546, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (40, CAST(N'2025-04-17T00:25:17.817' AS DateTime), 2061840, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (41, CAST(N'2025-04-17T00:32:32.380' AS DateTime), 818593, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (42, CAST(N'2025-04-17T00:39:27.237' AS DateTime), 728471, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (43, CAST(N'2025-04-17T00:42:03.020' AS DateTime), 2061840, N'Ví điện tử')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (44, CAST(N'2025-04-17T00:42:49.080' AS DateTime), 512705, N'Chuyển khoản')
INSERT [dbo].[ThanhToan] ([MaThanhToan], [NgayThanhToan], [TienThanhToan], [PhuongThucThanhToan]) VALUES (45, CAST(N'2025-04-17T04:31:11.390' AS DateTime), 1025409, N'Ví điện tử')
GO
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (0, CAST(N'2025-04-16T04:49:34.167' AS DateTime), N'', N'Trả hàng', 1, 36)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (1, CAST(N'2025-03-25T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 18, 1)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (2, CAST(N'2025-03-28T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 22, 2)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (3, CAST(N'2025-03-22T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 20, 4)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (4, CAST(N'2025-03-09T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 15, 5)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (5, CAST(N'2025-03-17T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 4, 8)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (6, CAST(N'2025-03-02T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 25, 9)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (7, CAST(N'2025-03-27T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 28, 19)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (8, CAST(N'2025-03-18T00:00:00.000' AS DateTime), N'Không vừa size', N'Đã xử lý', 2, 20)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (9, CAST(N'2025-04-16T05:42:31.360' AS DateTime), N'', N'Trả hàng', 1, 37)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (10, CAST(N'2025-04-16T05:55:04.117' AS DateTime), N'', N'Trả hàng', 1, 37)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (11, CAST(N'2025-04-16T05:55:22.480' AS DateTime), N'', N'Trả hàng', 1, 37)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (12, CAST(N'2025-04-16T05:55:31.073' AS DateTime), N'', N'Trả hàng', 1, 36)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (13, CAST(N'2025-04-16T06:13:28.797' AS DateTime), N'', N'Đổi hàng', 1, 31)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (14, CAST(N'2025-04-16T06:43:05.563' AS DateTime), N'', N'Đổi hàng', 1, 41)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (15, CAST(N'2025-04-16T06:43:31.070' AS DateTime), N'', N'Đổi hàng', 1, 41)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (16, CAST(N'2025-04-16T07:04:49.060' AS DateTime), N'', N'Trả hàng', 1, 41)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (17, CAST(N'2025-04-16T07:12:00.783' AS DateTime), N'', N'Trả hàng', 1, 41)
INSERT [dbo].[YeuCauDoiTra] ([MaYeuCau], [NgayTao], [LyDo], [TrangThai], [MaKhachHang], [MaDonHang]) VALUES (18, CAST(N'2025-04-17T00:57:27.280' AS DateTime), N'', N'Đổi hàng', 1, 45)
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChiTietDoiTra]  WITH CHECK ADD FOREIGN KEY([MaCTSanPham])
REFERENCES [dbo].[ChiTietSanPham] ([MaCTSanPham])
GO
ALTER TABLE [dbo].[ChiTietDoiTra]  WITH CHECK ADD FOREIGN KEY([MaYeuCau])
REFERENCES [dbo].[YeuCauDoiTra] ([MaYeuCau])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaCTSanPham])
REFERENCES [dbo].[ChiTietSanPham] ([MaCTSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaThanhToan])
REFERENCES [dbo].[ThanhToan] ([MaThanhToan])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaBoPhan])
REFERENCES [dbo].[BoPhan] ([MaBoPhan])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[YeuCauDoiTra]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[YeuCauDoiTra]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHoaDonByMaDonHang]    Script Date: 4/17/2025 5:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetHoaDonByMaDonHang]
    @MaDonHang INT
AS
BEGIN
    SELECT 
        dh.MaDonHang,
        sp.TenSanPham,
        sp.MaSanPham,
        ctdh.SoLuong,
        ctsp.GiaTien AS GiaXuat,
        nv.TenNhanVien AS HoVaTenNhanVien,
        kh.TenKhachHang AS HoVaTenKhachHang,
        dh.NgayTao
    FROM DonHang dh
    JOIN ChiTietDonHang ctdh ON dh.MaDonHang = ctdh.MaDonHang
    JOIN ChiTietSanPham ctsp ON ctdh.MaCTSanPham = ctsp.MaCTSanPham
    JOIN SanPham sp ON ctsp.MaSanPham = sp.MaSanPham
    JOIN NhanVien nv ON dh.MaNhanVien = nv.MaNhanVien
    JOIN KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang
    WHERE dh.MaDonHang = @MaDonHang
END
GO
USE [master]
GO
ALTER DATABASE [QLBH_TCH_UNIQLO] SET  READ_WRITE 
GO

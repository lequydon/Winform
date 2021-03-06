USE [master]
GO
/****** Object:  Database [nhacungcap]    Script Date: 8/7/2020 3:56:31 PM ******/
CREATE DATABASE [nhacungcap]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nhacungcap', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\nhacungcap.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'nhacungcap_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\nhacungcap_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [nhacungcap] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nhacungcap].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nhacungcap] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nhacungcap] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nhacungcap] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nhacungcap] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nhacungcap] SET ARITHABORT OFF 
GO
ALTER DATABASE [nhacungcap] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [nhacungcap] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nhacungcap] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nhacungcap] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nhacungcap] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nhacungcap] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nhacungcap] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nhacungcap] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nhacungcap] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nhacungcap] SET  ENABLE_BROKER 
GO
ALTER DATABASE [nhacungcap] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nhacungcap] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nhacungcap] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nhacungcap] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nhacungcap] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nhacungcap] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nhacungcap] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nhacungcap] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [nhacungcap] SET  MULTI_USER 
GO
ALTER DATABASE [nhacungcap] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nhacungcap] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nhacungcap] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nhacungcap] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [nhacungcap] SET DELAYED_DURABILITY = DISABLED 
GO
USE [nhacungcap]
GO
/****** Object:  Table [dbo].[dangkycungcap]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangkycungcap](
	[madkcc] [nvarchar](50) NOT NULL,
	[maloaidv] [nvarchar](50) NULL,
	[kyhieudongxe] [nvarchar](50) NULL,
	[mamp] [nvarchar](50) NULL,
	[ngaybatdaucungcap] [date] NULL,
	[ngayketthuccongcap] [date] NULL,
	[soluongxedangky] [int] NULL,
	[manhacungcap] [nvarchar](50) NULL,
 CONSTRAINT [PK__dangkycu__A8CA8E742B08C6E6] PRIMARY KEY CLUSTERED 
(
	[madkcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dongxe]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dongxe](
	[kyhieudongxe] [nvarchar](50) NOT NULL,
	[hangxe] [nvarchar](50) NULL,
	[sochongoi] [int] NULL,
 CONSTRAINT [PK__dongxe__344F2895B3E7A1F4] PRIMARY KEY CLUSTERED 
(
	[kyhieudongxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loaidichvu]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaidichvu](
	[maloaidv] [nvarchar](50) NOT NULL,
	[tenloaidichvu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maloaidv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mucphi]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mucphi](
	[mamp] [nvarchar](50) NOT NULL,
	[dongia] [money] NULL,
	[mota] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[mamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[manhacungcap] [nvarchar](50) NOT NULL,
	[tennhacungcap] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sodt] [nvarchar](50) NULL,
	[masothue] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[dangkycungcap] ([madkcc], [maloaidv], [kyhieudongxe], [mamp], [ngaybatdaucungcap], [ngayketthuccongcap], [soluongxedangky], [manhacungcap]) VALUES (N'd01', N'dv01', N'vios', N'mp1', CAST(N'2016-01-15' AS Date), CAST(N'2016-12-31' AS Date), 10, N'cc01')
INSERT [dbo].[dangkycungcap] ([madkcc], [maloaidv], [kyhieudongxe], [mamp], [ngaybatdaucungcap], [ngayketthuccongcap], [soluongxedangky], [manhacungcap]) VALUES (N'd02', N'dv01', N'grand-i10', N'mp2', CAST(N'2016-03-01' AS Date), CAST(N'2016-12-31' AS Date), 5, N'cc02')
INSERT [dbo].[dangkycungcap] ([madkcc], [maloaidv], [kyhieudongxe], [mamp], [ngaybatdaucungcap], [ngayketthuccongcap], [soluongxedangky], [manhacungcap]) VALUES (N'd03', N'dv01', N'forte', N'mp3', CAST(N'2016-03-01' AS Date), CAST(N'2017-12-31' AS Date), 10, N'cc02')
INSERT [dbo].[dangkycungcap] ([madkcc], [maloaidv], [kyhieudongxe], [mamp], [ngaybatdaucungcap], [ngayketthuccongcap], [soluongxedangky], [manhacungcap]) VALUES (N'd04', N'dv02', N'hieace', N'mp3', CAST(N'2015-01-01' AS Date), CAST(N'2018-12-31' AS Date), 12, N'cc03')
INSERT [dbo].[dangkycungcap] ([madkcc], [maloaidv], [kyhieudongxe], [mamp], [ngaybatdaucungcap], [ngayketthuccongcap], [soluongxedangky], [manhacungcap]) VALUES (N'd05', N'dv01', N'vios', N'mp1', CAST(N'2016-01-01' AS Date), CAST(N'2016-12-31' AS Date), 4, N'cc03')
INSERT [dbo].[dongxe] ([kyhieudongxe], [hangxe], [sochongoi]) VALUES (N'forte', N'kia', 7)
INSERT [dbo].[dongxe] ([kyhieudongxe], [hangxe], [sochongoi]) VALUES (N'grand-i10', N'huyndai', 4)
INSERT [dbo].[dongxe] ([kyhieudongxe], [hangxe], [sochongoi]) VALUES (N'hieace', N'toyota', 16)
INSERT [dbo].[dongxe] ([kyhieudongxe], [hangxe], [sochongoi]) VALUES (N'vios', N'toyota', 5)
INSERT [dbo].[loaidichvu] ([maloaidv], [tenloaidichvu]) VALUES (N'dv01', N'dịch vụ thuê xe tự lái')
INSERT [dbo].[loaidichvu] ([maloaidv], [tenloaidichvu]) VALUES (N'dv02', N'cho thuê xe theo hợp đồng')
INSERT [dbo].[mucphi] ([mamp], [dongia], [mota]) VALUES (N'mp1', 10000.0000, N'áp dụng từ ngày 1/2016')
INSERT [dbo].[mucphi] ([mamp], [dongia], [mota]) VALUES (N'mp2', 12000.0000, N'áp dụng từ ngày 4/2016')
INSERT [dbo].[mucphi] ([mamp], [dongia], [mota]) VALUES (N'mp3', 15000.0000, N'áp dụng từ 4/2016')
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodt], [masothue]) VALUES (N'cc01', N'công ty atn', N'22 lê lợi', N'0543854789', N'301-214-547')
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodt], [masothue]) VALUES (N'cc02', N'ông lê chí hải', N'102 trần phú', N'0543826987', N'301-558-987')
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodt], [masothue]) VALUES (N'cc03', N'công ty ames', N'47 hải phòng', N'0543814578', N'301-580-366')
ALTER TABLE [dbo].[dangkycungcap]  WITH CHECK ADD  CONSTRAINT [FK_dangkycungcap_dongxe] FOREIGN KEY([kyhieudongxe])
REFERENCES [dbo].[dongxe] ([kyhieudongxe])
GO
ALTER TABLE [dbo].[dangkycungcap] CHECK CONSTRAINT [FK_dangkycungcap_dongxe]
GO
ALTER TABLE [dbo].[dangkycungcap]  WITH CHECK ADD  CONSTRAINT [FK_dangkycungcap_loaidichvu] FOREIGN KEY([maloaidv])
REFERENCES [dbo].[loaidichvu] ([maloaidv])
GO
ALTER TABLE [dbo].[dangkycungcap] CHECK CONSTRAINT [FK_dangkycungcap_loaidichvu]
GO
ALTER TABLE [dbo].[dangkycungcap]  WITH CHECK ADD  CONSTRAINT [FK_dangkycungcap_mucphi] FOREIGN KEY([mamp])
REFERENCES [dbo].[mucphi] ([mamp])
GO
ALTER TABLE [dbo].[dangkycungcap] CHECK CONSTRAINT [FK_dangkycungcap_mucphi]
GO
ALTER TABLE [dbo].[dangkycungcap]  WITH CHECK ADD  CONSTRAINT [FK_dangkycungcap_nhacungcap] FOREIGN KEY([manhacungcap])
REFERENCES [dbo].[nhacungcap] ([manhacungcap])
GO
ALTER TABLE [dbo].[dangkycungcap] CHECK CONSTRAINT [FK_dangkycungcap_nhacungcap]
GO
/****** Object:  StoredProcedure [dbo].[proc_DangKyCungCap_Insert]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DangKyCungCap_Insert]
(
	@madkcc	nvarchar(50),
	@maloaidv	nvarchar(50),
	@kyhieudongxe	nvarchar(50),
	@mamp	nvarchar(50),
	@ngaybatdaucungcap	date,
	@ngayketthuccongcap	date,
	@soluongxedangky	int,
	@manhacungcap	nvarchar(50)
)
as
begin
	if not exists (select * from loaidichvu where maloaidv=@maloaidv)
		return
	insert into dangkycungcap values (@madkcc,@maloaidv,@kyhieudongxe,@mamp,@ngaybatdaucungcap,@ngayketthuccongcap,@soluongxedangky,@manhacungcap)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_MucPhi_DeleteUnUsed]    Script Date: 8/7/2020 3:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_MucPhi_DeleteUnUsed]
as
begin
	delete mucphi 
	where mucphi.mamp not in(select dangkycungcap.mamp from dangkycungcap)
end
GO
USE [master]
GO
ALTER DATABASE [nhacungcap] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [QLDTDD]    Script Date: 11/3/2019 2:42:45 PM ******/
CREATE DATABASE [QLDTDD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDTDD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLDTDD.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDTDD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLDTDD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDTDD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDTDD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDTDD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDTDD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDTDD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDTDD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDTDD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDTDD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDTDD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDTDD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDTDD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDTDD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDTDD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDTDD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDTDD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDTDD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDTDD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDTDD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDTDD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDTDD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDTDD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDTDD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDTDD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDTDD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDTDD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDTDD] SET  MULTI_USER 
GO
ALTER DATABASE [QLDTDD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDTDD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDTDD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDTDD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLDTDD]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[accID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](20) NULL,
	[password] [nvarchar](20) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[accID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[empID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[phone] [nchar](10) NULL,
	[state] [nchar](10) NULL,
	[position] [nchar](10) NULL,
	[accID] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[empID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportCoupon]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportCoupon](
	[impID] [int] IDENTITY(1,1) NOT NULL,
	[impdetailDate] [date] NULL,
	[empID] [int] NULL,
	[total] [money] NULL,
 CONSTRAINT [PK_ImportCoupon] PRIMARY KEY CLUSTERED 
(
	[impID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportCouponDetail]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportCouponDetail](
	[impdetaiID] [int] IDENTITY(1,1) NOT NULL,
	[quantity] [int] NULL,
	[price] [money] NULL,
	[total] [money] NULL,
	[impID] [int] NULL,
 CONSTRAINT [PK_ImportCouponDetail] PRIMARY KEY CLUSTERED 
(
	[impdetaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[orderID] [int] IDENTITY(1,1) NOT NULL,
	[total] [money] NULL,
	[cusName] [nvarchar](50) NULL,
	[orderDate] [date] NULL,
	[state] [nchar](10) NULL,
	[empName] [nchar](10) NULL,
	[empID] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[detailID] [int] IDENTITY(1,1) NOT NULL,
	[unitprice] [money] NULL,
	[amount] [money] NULL,
	[orderID] [int] NULL,
	[teleID] [int] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[detailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telephone]    Script Date: 11/3/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telephone](
	[teleID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[impdetaiID] [int] NULL,
	[price] [money] NULL,
	[provider] [nchar](10) NULL,
	[state] [nchar](10) NULL,
 CONSTRAINT [PK_Telephone] PRIMARY KEY CLUSTERED 
(
	[teleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (1, N'ky', N'123')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (2, N'nhu', N'456')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (3, N'nguyen', N'789')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (4, N'ka', N'012')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (5, N'khai', N'khai')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (8, N'canh', N'canh')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (9, N'tu', N'tu')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (10, N'tung', N'tung')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (11, N'Kiet', N'kiet')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (12, N'phat', N'phat')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (13, N'j', N'j')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (14, N'1', N'1')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (15, N'2', N'2')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (16, N'kythanh', N'kythanh')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (18, N'f', N'f')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (19, N'1', N'1')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (20, N'hh', N'hh')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (21, N'f', N'f')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (22, N'5', N'5')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (23, N'g', N'g')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (24, N'y', N'y')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (25, N'y', N'y')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (26, N'24', N'24')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (33, N'1', N'1')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (34, N'yy', N'yy')
INSERT [dbo].[Account] ([accID], [username], [password]) VALUES (35, N'hth', N'thth')
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (7, N'Ky', N'1211', N'09078901  ', N'Danglam   ', N'banhang   ', 1)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (8, N'Nhu', N'324', N'08897875  ', N'Danglam   ', N'banhang   ', 2)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (9, N'Nguyen', N'523', N'09127841  ', N'Danglam   ', N'quanly    ', 3)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (38, N'ka', N'125 a', N'091251255 ', N'danglam   ', N'banhang   ', 4)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (39, N'tu', N'12 tu', N'01859712  ', N'danglam   ', N'banhang   ', 9)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (40, N'tung', N'12 ah', N'018249812 ', N'danglam   ', N'banhang   ', 10)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (41, N'keit', N'123', N'01850218  ', N'danglam   ', N'banhang   ', 11)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (42, N'phat', N'12khk', N'01808510  ', N'danglam   ', N'banhang   ', 12)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (43, N'j', N'22', N's         ', N'd         ', N'2         ', 13)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (44, N'1', N'1', N'1         ', N'1         ', N'12        ', 14)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (45, N'2', N'2', N'2         ', N'2         ', N'2         ', 15)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (46, N'kythanh', N'123', N'0923975   ', N'danglam   ', N'quanly    ', 16)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (48, N'h', N'132j', N'09108897  ', N'dangban   ', N'banhang   ', 20)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (49, N'1', N'123', N'089908    ', N'f         ', N'g         ', 18)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (50, N'ok', N'00', N'098979    ', N'a         ', N'a         ', 22)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (51, N'y', N'12', N'0987997   ', N'11        ', N'1         ', 24)
INSERT [dbo].[Employee] ([empID], [name], [address], [phone], [state], [position], [accID]) VALUES (52, N'12', N'23', N'24        ', N'256       ', N'464       ', 26)
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[ImportCoupon] ON 

INSERT [dbo].[ImportCoupon] ([impID], [impdetailDate], [empID], [total]) VALUES (1, CAST(N'2019-02-02' AS Date), 7, 1000000.0000)
INSERT [dbo].[ImportCoupon] ([impID], [impdetailDate], [empID], [total]) VALUES (2, CAST(N'2019-03-03' AS Date), 8, 19999999.0000)
INSERT [dbo].[ImportCoupon] ([impID], [impdetailDate], [empID], [total]) VALUES (3, CAST(N'2019-02-09' AS Date), 7, 20000000.0000)
SET IDENTITY_INSERT [dbo].[ImportCoupon] OFF
SET IDENTITY_INSERT [dbo].[ImportCouponDetail] ON 

INSERT [dbo].[ImportCouponDetail] ([impdetaiID], [quantity], [price], [total], [impID]) VALUES (1, 12, 120000.0000, 3200000.0000, 1)
INSERT [dbo].[ImportCouponDetail] ([impdetaiID], [quantity], [price], [total], [impID]) VALUES (2, 5, 2000000000.0000, 200000000000.0000, 2)
INSERT [dbo].[ImportCouponDetail] ([impdetaiID], [quantity], [price], [total], [impID]) VALUES (3, 5, 3000000000.0000, 2300000000.0000, 2)
SET IDENTITY_INSERT [dbo].[ImportCouponDetail] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([orderID], [total], [cusName], [orderDate], [state], [empName], [empID]) VALUES (2, 10000000.0000, N'Kiet', CAST(N'2019-02-10' AS Date), N'oke       ', N'Nhu       ', 7)
INSERT [dbo].[Order] ([orderID], [total], [cusName], [orderDate], [state], [empName], [empID]) VALUES (3, 20000000.0000, N'Canh', CAST(N'2019-12-12' AS Date), N'oke       ', N'Kt        ', 8)
INSERT [dbo].[Order] ([orderID], [total], [cusName], [orderDate], [state], [empName], [empID]) VALUES (4, 3000000000.0000, N'Heu', CAST(N'2019-10-10' AS Date), N'oke       ', N'Ky        ', 8)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([detailID], [unitprice], [amount], [orderID], [teleID]) VALUES (2, 1000000.0000, 100.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([detailID], [unitprice], [amount], [orderID], [teleID]) VALUES (3, 100000000.0000, 10.0000, 2, 2)
INSERT [dbo].[OrderDetail] ([detailID], [unitprice], [amount], [orderID], [teleID]) VALUES (4, 2000000.0000, 10000.0000, 3, 3)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Telephone] ON 

INSERT [dbo].[Telephone] ([teleID], [name], [impdetaiID], [price], [provider], [state]) VALUES (1, N'ip6', 1, 200000.0000, N'ad1211    ', N'dang ma   ')
INSERT [dbo].[Telephone] ([teleID], [name], [impdetaiID], [price], [provider], [state]) VALUES (2, N'samsung 10plus', 1, 2000000.0000, N'as1       ', N'dang ma   ')
INSERT [dbo].[Telephone] ([teleID], [name], [impdetaiID], [price], [provider], [state]) VALUES (3, N'xiaomi red 5', 2, 20000000.0000, N'aswf      ', N'dang ma   ')
SET IDENTITY_INSERT [dbo].[Telephone] OFF
/****** Object:  Index [UQ__Employee__A471AFFB0154A407]    Script Date: 11/3/2019 2:42:45 PM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[accID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Employee__A471AFFB160962FF]    Script Date: 11/3/2019 2:42:45 PM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[accID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__OrderDet__F81685A93EA658E3]    Script Date: 11/3/2019 2:42:45 PM ******/
ALTER TABLE [dbo].[OrderDetail] ADD UNIQUE NONCLUSTERED 
(
	[teleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__OrderDet__F81685A9C8A9805C]    Script Date: 11/3/2019 2:42:45 PM ******/
ALTER TABLE [dbo].[OrderDetail] ADD UNIQUE NONCLUSTERED 
(
	[teleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Account] FOREIGN KEY([accID])
REFERENCES [dbo].[Account] ([accID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Account]
GO
ALTER TABLE [dbo].[ImportCoupon]  WITH CHECK ADD  CONSTRAINT [FK_ImportCoupon_Employee] FOREIGN KEY([empID])
REFERENCES [dbo].[Employee] ([empID])
GO
ALTER TABLE [dbo].[ImportCoupon] CHECK CONSTRAINT [FK_ImportCoupon_Employee]
GO
ALTER TABLE [dbo].[ImportCouponDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportCouponDetail_ImportCoupon] FOREIGN KEY([impID])
REFERENCES [dbo].[ImportCoupon] ([impID])
GO
ALTER TABLE [dbo].[ImportCouponDetail] CHECK CONSTRAINT [FK_ImportCouponDetail_ImportCoupon]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([empID])
REFERENCES [dbo].[Employee] ([empID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([orderID])
REFERENCES [dbo].[Order] ([orderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Telephone] FOREIGN KEY([teleID])
REFERENCES [dbo].[Telephone] ([teleID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Telephone]
GO
ALTER TABLE [dbo].[Telephone]  WITH CHECK ADD  CONSTRAINT [FK_Telephone_ImportCouponDetail] FOREIGN KEY([impdetaiID])
REFERENCES [dbo].[ImportCouponDetail] ([impdetaiID])
GO
ALTER TABLE [dbo].[Telephone] CHECK CONSTRAINT [FK_Telephone_ImportCouponDetail]
GO
USE [master]
GO
ALTER DATABASE [QLDTDD] SET  READ_WRITE 
GO

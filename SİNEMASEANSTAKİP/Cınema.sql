USE [MOVIETICKETS]
GO
/****** Object:  Table [dbo].[belle]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[belle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NULL,
	[Saat] [nvarchar](10) NULL,
 CONSTRAINT [PK_belle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[galaksi]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[galaksi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NULL,
	[Saat] [nvarchar](10) NULL,
 CONSTRAINT [PK_galaksi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hizliveofkeli]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hizliveofkeli](
	[Id] [int] NULL,
	[datetime] [datetime] NULL,
	[clock] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hzlvefkl]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hzlvefkl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[datetimee] [date] NULL,
	[clock] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mstrlr]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mstrlr](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](10) NULL,
	[Soyad] [nvarchar](10) NULL,
	[Tarih] [datetime] NULL,
	[Saat] [nvarchar](10) NULL,
	[Koltuk] [nvarchar](10) NULL,
 CONSTRAINT [PK_Mstrlr] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriler]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](10) NULL,
	[Soyad] [nvarchar](10) NULL,
	[Film] [nvarchar](20) NULL,
	[Tarih] [datetime] NULL,
	[Saat] [nvarchar](10) NULL,
	[Koltuk] [nvarchar](10) NULL,
 CONSTRAINT [PK_musteriler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[umut]    Script Date: 13.05.2023 08:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[umut](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NULL,
	[Saat] [nvarchar](10) NULL,
 CONSTRAINT [PK_umut] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[belle] ON 

INSERT [dbo].[belle] ([Id], [Tarih], [Saat]) VALUES (1, CAST(N'2023-05-18T00:00:00.000' AS DateTime), N'19.00')
INSERT [dbo].[belle] ([Id], [Tarih], [Saat]) VALUES (2, CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'18.00')
SET IDENTITY_INSERT [dbo].[belle] OFF
GO
SET IDENTITY_INSERT [dbo].[galaksi] ON 

INSERT [dbo].[galaksi] ([Id], [Tarih], [Saat]) VALUES (1, CAST(N'2023-05-10T00:00:00.000' AS DateTime), N'19.00')
SET IDENTITY_INSERT [dbo].[galaksi] OFF
GO
INSERT [dbo].[hizliveofkeli] ([Id], [datetime], [clock]) VALUES (1, CAST(N'2023-05-18T00:00:00.000' AS DateTime), N'19.05')
INSERT [dbo].[hizliveofkeli] ([Id], [datetime], [clock]) VALUES (2, CAST(N'2023-05-17T00:00:00.000' AS DateTime), N'17.05')
GO
SET IDENTITY_INSERT [dbo].[hzlvefkl] ON 

INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (1, CAST(N'2023-05-17' AS Date), N'18.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (2, CAST(N'2023-05-17' AS Date), N'21.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (3, CAST(N'2023-05-18' AS Date), N'14.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (4, CAST(N'2023-05-18' AS Date), N'22.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (5, CAST(N'2023-05-19' AS Date), N'19.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (6, CAST(N'2023-05-19' AS Date), N'20.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (7, CAST(N'2023-05-20' AS Date), N'13.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (8, CAST(N'2023-05-20' AS Date), N'16.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (9, CAST(N'2023-05-20' AS Date), N'22.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (10, CAST(N'2023-05-21' AS Date), N'15.00')
INSERT [dbo].[hzlvefkl] ([Id], [datetimee], [clock]) VALUES (11, CAST(N'2023-05-21' AS Date), N'21.00')
SET IDENTITY_INSERT [dbo].[hzlvefkl] OFF
GO
SET IDENTITY_INSERT [dbo].[Mstrlr] ON 

INSERT [dbo].[Mstrlr] ([Id], [Ad], [Soyad], [Tarih], [Saat], [Koltuk]) VALUES (1, N'eren', N'köroğlu', CAST(N'2023-05-17T00:00:00.000' AS DateTime), N'18.00', N'A4')
INSERT [dbo].[Mstrlr] ([Id], [Ad], [Soyad], [Tarih], [Saat], [Koltuk]) VALUES (2, N'emir', N'kalburcu', CAST(N'2023-05-17T00:00:00.000' AS DateTime), N'18.00', N'B5')
INSERT [dbo].[Mstrlr] ([Id], [Ad], [Soyad], [Tarih], [Saat], [Koltuk]) VALUES (3, N'elif', N'köroğlu', CAST(N'2023-05-18T00:00:00.000' AS DateTime), N'19.05', N'A1')
INSERT [dbo].[Mstrlr] ([Id], [Ad], [Soyad], [Tarih], [Saat], [Koltuk]) VALUES (4, N'sehriye', N'köroğlu', CAST(N'2023-05-17T00:00:00.000' AS DateTime), N'18.00', N'B3')
SET IDENTITY_INSERT [dbo].[Mstrlr] OFF
GO
SET IDENTITY_INSERT [dbo].[musteriler] ON 

INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (1, N'Eren', N'Köroğlu', N'HIZLI VE ÖFKELİ', CAST(N'2023-05-19T00:00:00.000' AS DateTime), N'20.00', N'A4')
INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (3, N'Emir', N'Kalburcu', N'BELLE VE SEBASTIAN', CAST(N'2023-05-18T00:00:00.000' AS DateTime), N'19.00', N'B4')
INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (4, N'Sehriye', N'Köroğlu', N'HIZLI VE ÖFKELİ', CAST(N'2023-05-19T00:00:00.000' AS DateTime), N'19.00', N'B3')
INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (5, N'Recep', N'Köroğlu', N'BİR UMUT', CAST(N'2023-06-05T00:00:00.000' AS DateTime), N'22.00', N'B1')
INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (6, N'Satiye', N'Kalburcu', N'BİR UMUT', CAST(N'2023-05-25T00:00:00.000' AS DateTime), N'18.00', N'A3')
INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (7, N'Burak', N'Yılmaz', N'GALAKSİNİN', CAST(N'2023-05-10T00:00:00.000' AS DateTime), N'19.00', N'A3')
INSERT [dbo].[musteriler] ([Id], [Ad], [Soyad], [Film], [Tarih], [Saat], [Koltuk]) VALUES (10, N'Yüksel', N'Kalburcu', N'BELLE VE SEBASTIAN', CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'18.00', N'A3')
SET IDENTITY_INSERT [dbo].[musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[umut] ON 

INSERT [dbo].[umut] ([Id], [Tarih], [Saat]) VALUES (1, CAST(N'2023-05-25T00:00:00.000' AS DateTime), N'18.00')
INSERT [dbo].[umut] ([Id], [Tarih], [Saat]) VALUES (2, CAST(N'2023-06-05T00:00:00.000' AS DateTime), N'22.00')
SET IDENTITY_INSERT [dbo].[umut] OFF
GO

USE [NesneTabanlıVeriTabani]
GO
/****** Object:  Table [dbo].[Tbl_Personel]    Script Date: 30.03.2021 16:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Personel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](15) NULL,
	[SOYAD] [varchar](20) NULL,
	[ŞEHİR] [varchar](15) NULL,
	[MAAŞ] [money] NULL,
	[MEDENİ_HAL] [varchar](5) NULL,
	[MESLEK] [varchar](25) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_PersonelGiris]    Script Date: 30.03.2021 16:26:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PersonelGiris](
	[KulaniciAd] [varchar](20) NULL,
	[KullaniciSifre] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Personel] ON 

INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (1, N'Serkan', N'Uyar', N'Ordu', 5000.0000, N'BEKAR', N'Bilgisayar Teknikeri')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (6, N'Baki', N'Has', N'Trabzon', 5700.0000, N'BEKAR', N' Öğretmen')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (10, N'Selçuk', N'Şahin', N'İstanbull', 6000.0000, N'BEKAR', N'Polis')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (11, N'Serap', N'Akkaya', N'Ordu', 6000.0000, N'EVLİ', N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (12, N'Zafer', N'Düzen', N'Sinop', 6000.0000, N'EVLİ', N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (13, N'Nurdan', N'Yavuz', N'Trabzon', 5500.0000, N'BEKAR', N'Öğretmen')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (1002, N'Beyza', N'Kızılkaya', N'İstanbull', 5000.0000, N'BEKAR', N'Bilgisayar Teknikeri')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (7, N'Yusuf', N'Küçük', N'Trabzon', 6000.0000, N'BEKAR', N' Psikolog')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (8, N'Kaan', N'Güneri', N'Sivas', 5500.0000, N'BEKAR', N'Bilgisayar Teknikeri')
INSERT [dbo].[Tbl_Personel] ([ID], [AD], [SOYAD], [ŞEHİR], [MAAŞ], [MEDENİ_HAL], [MESLEK]) VALUES (9, N'Mehmet can', N'Uyar', N'Antalya', 6000.0000, N'BEKAR', N'Psikolog')
SET IDENTITY_INSERT [dbo].[Tbl_Personel] OFF
GO
INSERT [dbo].[Tbl_PersonelGiris] ([KulaniciAd], [KullaniciSifre]) VALUES (N'Admin1', 1234)
INSERT [dbo].[Tbl_PersonelGiris] ([KulaniciAd], [KullaniciSifre]) VALUES (N'Admin2', 1234)
GO

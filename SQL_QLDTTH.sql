USE [QLDHSTH]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaHS] [nvarchar](50) NOT NULL,
	[MaMH] [nvarchar](50) NOT NULL,
	[Diem_Mieng] [float] NULL,
	[Diem_KT1T] [float] NULL,
	[Diem_ThiHK] [float] NULL,
	[Diem_TB] [float] NULL,
	[manh] [nchar](10) NULL,
	[makh] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [nvarchar](50) NOT NULL,
	[HoTenGV] [nvarchar](255) NULL,
	[Ngaysinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Diachi] [nvarchar](255) NULL,
	[Chucvu] [nvarchar](50) NULL,
	[BoMonGD] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocky]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocky](
	[mahk] [nchar](10) NOT NULL,
	[tenhk] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[mahk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [nvarchar](10) NOT NULL,
	[Diachi] [nvarchar](255) NULL,
	[Malop] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[Malop] [nvarchar](50) NOT NULL,
	[Tenlop] [nvarchar](50) NULL,
	[Siso] [int] NULL,
	[MaGVCN] [nvarchar](50) NULL,
	[TenGVCN] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nvarchar](50) NOT NULL,
	[TenMH] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[namhoc]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[namhoc](
	[manh] [nchar](10) NOT NULL,
	[tennh] [nchar](10) NOT NULL,
 CONSTRAINT [PK_namhoc] PRIMARY KEY CLUSTERED 
(
	[manh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Tennguoidung] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Tennguoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuHuynh]    Script Date: 5/14/2024 10:20:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuHuynh](
	[MaPH] [nvarchar](50) NOT NULL,
	[MaHS] [nvarchar](50) NULL,
	[Hoten] [nvarchar](255) NULL,
	[Ngaysinh] [date] NULL,
	[nghenghiep] [nvarchar](50) NULL,
	[diachi] [nvarchar](255) NULL,
	[Sdt] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Diem] ([MaHS], [MaMH], [Diem_Mieng], [Diem_KT1T], [Diem_ThiHK], [Diem_TB], [manh], [makh]) VALUES (N'HS0001', N'MH0001', 10, 10, 10, 10, N'NH2023    ', N'hk1       ')
INSERT [dbo].[Diem] ([MaHS], [MaMH], [Diem_Mieng], [Diem_KT1T], [Diem_ThiHK], [Diem_TB], [manh], [makh]) VALUES (N'HS0003', N'MH0001', 9, 9, 7, 8.3333333333333339, N'NH2023    ', N'hk1       ')
INSERT [dbo].[Diem] ([MaHS], [MaMH], [Diem_Mieng], [Diem_KT1T], [Diem_ThiHK], [Diem_TB], [manh], [makh]) VALUES (N'HS0004', N'MH0001', 10, 10, 9, 9.6666666666666661, N'NH2023    ', N'hk1       ')
INSERT [dbo].[Diem] ([MaHS], [MaMH], [Diem_Mieng], [Diem_KT1T], [Diem_ThiHK], [Diem_TB], [manh], [makh]) VALUES (N'HS0006', N'MH0001', 9, 9, 7, 8.3333333333333339, N'NH2023    ', N'hk1       ')
INSERT [dbo].[Diem] ([MaHS], [MaMH], [Diem_Mieng], [Diem_KT1T], [Diem_ThiHK], [Diem_TB], [manh], [makh]) VALUES (N'HS0001', N'MH0002', 10, 9, 10, 9.6666666666666661, N'NH2023    ', N'hk1       ')
INSERT [dbo].[Diem] ([MaHS], [MaMH], [Diem_Mieng], [Diem_KT1T], [Diem_ThiHK], [Diem_TB], [manh], [makh]) VALUES (N'HS0006', N'MH0002', 8, 7, 10, 8.3333333333333339, N'NH2023    ', N'hk1       ')
GO
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0001', N'Nguyen Van A', CAST(N'2000-01-01' AS Date), N'Nam', N'123 ABC Street', N'Hieu Truong', N'Vat Ly')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0002', N'Tran Thi Nhi Hue', CAST(N'1985-02-15' AS Date), N'Nữ', N'456 DEF Street', N'Giao Vien', N'Toan')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0003', N'Le Van C', CAST(N'1978-08-30' AS Date), N'Nam', N'789 GHI Street', N'Pho Hieu Truong', N'Hoa Hoc')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0004', N'Pham Thi D', CAST(N'1982-11-21' AS Date), N'Nu', N'101 JKL Street', N'Giao Vien', N'Sinh Hoc')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0005', N'Hoang Van E', CAST(N'1990-05-19' AS Date), N'Nam', N'202 MNO Street', N'Giao Vien', N'Lich Su')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0006', N'Nguyen Thi F', CAST(N'1975-03-28' AS Date), N'Nu', N'303 PQR Street', N'Giao Vien', N'Dia Ly')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0007', N'Bui Van G', CAST(N'1988-07-13' AS Date), N'Nam', N'404 STU Street', N'Giao Vien', N'The Duc')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0008', N'Vu Thi H', CAST(N'1993-09-17' AS Date), N'Nu', N'505 VWX Street', N'Giao Vien', N'Am Nhac')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0009', N'Tran Van I', CAST(N'1980-12-25' AS Date), N'Nam', N'606 YZA Street', N'Giao Vien', N'My Thuat')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0010', N'Le Thi J', CAST(N'1995-04-10' AS Date), N'Nu', N'707 BCD Street', N'Giao Vien', N'Tieng Anh')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0011', N'Pham Van K', CAST(N'1979-06-05' AS Date), N'Nam', N'808 EFG Street', N'Giao Vien', N'Tieng Phap')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0012', N'Hoang Thi L', CAST(N'1986-10-14' AS Date), N'Nu', N'909 HIJ Street', N'Giao Vien', N'Tieng Duc')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0013', N'Nguyen Van M', CAST(N'1991-01-23' AS Date), N'Nam', N'111 KLM Street', N'Giao Vien', N'Tieng Nhat')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0014', N'Bui Thi N', CAST(N'1983-03-16' AS Date), N'Nu', N'212 NOP Street', N'Giao Vien', N'Tieng Han')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0016', N'Tran Thi P', CAST(N'1987-09-29' AS Date), N'Nu', N'414 TUV Street', N'Giao Vien', N'Tieng Trung')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0017', N'Le Van Q', CAST(N'1992-04-18' AS Date), N'Nam', N'515 WXY Street', N'Giao Vien', N'Khoa Hoc Tu Nhien')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0018', N'Pham Thi R', CAST(N'1984-05-27' AS Date), N'Nu', N'616 ZAB Street', N'Giao Vien', N'Khoa Hoc Xa Hoi')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0019', N'Hoang Van S', CAST(N'1996-07-08' AS Date), N'Nam', N'717 CDE Street', N'Giao Vien', N'Cong Nghe')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0020', N'Nguyen Thi T', CAST(N'1989-08-20' AS Date), N'Nu', N'818 FGH Street', N'Giao Vien', N'Giao Duc Cong Dan')
INSERT [dbo].[GiaoVien] ([MaGV], [HoTenGV], [Ngaysinh], [GioiTinh], [Diachi], [Chucvu], [BoMonGD]) VALUES (N'GV0022', N'Nguyễn Văn Khang', CAST(N'2024-04-23' AS Date), N'Nam', N' Mỹ Phước ,Long Xuyên', N'Giáo Viên Bộ Môn', N'Tiếng Anh')
GO
INSERT [dbo].[hocky] ([mahk], [tenhk]) VALUES (N'hk1       ', N'Học Kỳ I')
INSERT [dbo].[hocky] ([mahk], [tenhk]) VALUES (N'hk2       ', N'Học Kỳ II')
GO
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0001', N'Nguyen Hoang Thien An', CAST(N'2003-04-01' AS Date), N'Nu', N'123 ABC Street', N'L0001')
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0003', N'Thái Minh Mẩn ', CAST(N'2024-02-26' AS Date), N'Nữ', N'Khánh Hòa, Châu Phú, An Giang', N'L0001')
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0004', N'Trần Quốc An', CAST(N'2024-04-01' AS Date), N'Nam', N'Mỹ Hòa,Long Xuyên', N'L0001')
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0005', N'Nguyễn Thị Bé Ba', CAST(N'2024-04-10' AS Date), N'Nữ', N'Đông Xuyên,Long Xuyên', N'L0002')
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0006', N'Nguyễn Thanh Nguyên', CAST(N'2024-04-17' AS Date), N'Nam', N'Đông Xuyên,Long Xuyên', N'L0010')
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0007', N'Dương Minh Tiến', CAST(N'2024-04-01' AS Date), N'Nam', N'Tân Châu,Long Xuyên', N'L0002')
INSERT [dbo].[HocSinh] ([MaHS], [HoTen], [Ngaysinh], [Gioitinh], [Diachi], [Malop]) VALUES (N'HS0008', N'Nguyen Thi Dieu Hien', CAST(N'2024-05-13' AS Date), N'Nữ', N'Chau Phu, An GIang', N'L0002')
GO
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0001', N'2C', 31, N'GV0001', N'Nguyen Van A')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0002', N'1A', 30, N'GV0002', N'Tran Thi B')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0003', N'1B', 28, N'GV0003', N'Le Van C')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0004', N'4C', 32, N'GV0004', N'Pham Thi D')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0005', N'4B', 29, N'GV0005', N'Hoang Van E')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0006', N'3D', 31, N'GV0006', N'Nguyen Thi F')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0007', N'2B', 33, N'GV0007', N'Bui Van G')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0008', N'2A', 27, N'GV0008', N'Vu Thi H')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0009', N'5B', 30, N'GV0010', N'Le Thi J')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0010', N'3A', 28, N'GV0001', N'Nguyen Van A')
INSERT [dbo].[Lop] ([Malop], [Tenlop], [Siso], [MaGVCN], [TenGVCN]) VALUES (N'L0011', N'4A', 31, N'GV0011', N'Pham Van K')
GO
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (N'MH0001', N'Toan')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (N'MH0002', N'Tiếng Việt')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (N'MH0003', N'Đạo Đức ')
GO
INSERT [dbo].[namhoc] ([manh], [tennh]) VALUES (N'NH2023    ', N'2023-2024 ')
INSERT [dbo].[namhoc] ([manh], [tennh]) VALUES (N'NH2024    ', N'2024-2025 ')
GO
INSERT [dbo].[NguoiDung] ([Tennguoidung], [Matkhau], [Quyen]) VALUES (N'nhanvien', N'a4904dbf3975743ac5973d27c6889d14', N'2')
INSERT [dbo].[NguoiDung] ([Tennguoidung], [Matkhau], [Quyen]) VALUES (N'quantri', N'0192023a7bbd73250516f069df18b500', N'1')
GO
INSERT [dbo].[PhuHuynh] ([MaPH], [MaHS], [Hoten], [Ngaysinh], [nghenghiep], [diachi], [Sdt]) VALUES (N'PH0001', N'HS0001', N'Nguyen Thanh Sang', CAST(N'2003-02-02' AS Date), N' Giam doc', N'Tang 81 tao nha lanmark 81', N'0583130289')
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_hocky] FOREIGN KEY([makh])
REFERENCES [dbo].[hocky] ([mahk])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_hocky]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_namhoc] FOREIGN KEY([manh])
REFERENCES [dbo].[namhoc] ([manh])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_namhoc]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([Malop])
REFERENCES [dbo].[Lop] ([Malop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaGVCN])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[PhuHuynh]  WITH CHECK ADD FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [Diem_KT1T] CHECK  (([Diem_KT1T]>=(0) AND [Diem_KT1T]<=(10)))
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [Diem_KT1T]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [Diem_Mieng] CHECK  (([Diem_Mieng]>=(0) AND [Diem_Mieng]<=(10)))
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [Diem_Mieng]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [Diem_TB] CHECK  (([Diem_TB]>=(0) AND [Diem_TB]<=(10)))
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [Diem_TB]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [Diem_ThiHK] CHECK  (([Diem_ThiHK]>=(0) AND [Diem_ThiHK]<=(10)))
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [Diem_ThiHK]
GO

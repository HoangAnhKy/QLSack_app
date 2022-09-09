Create database [QLSACHZZ]
GO
USE [QLSACHZZ]
GO

CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](50) not null,
	[TenSach] [nvarchar](50) not null,
	[MaLoaiSach] [nvarchar](50) not null,
	[SoLuong] [int] not null,
	[MaTacGia] [nvarchar](50) not null,

 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [nvarchar](50) not null,
	[SDT] [nvarchar](10) not null,
	[GioiTinh][bit]  null,
	[DiaChi] [nvarchar](100) not null,
	[HoTen] [nvarchar](100) not null,
	[NgaySinh] [date] not null,

 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) not null,
	[SDT] [nvarchar](10) not null,
	[GioiTinh][bit]  null,
	[DiaChi] [nvarchar](100) not null,
	[HoTen] [nvarchar](100) not null,
	[NgaySinh][date] not null,
	[name] [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [nvarchar](50) not null,
	[TenTacgia][nvarchar](50) NULL,
	[DiaChi][nvarchar](100) NULL,
	
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[MaLoaiSach] [nvarchar](50) NOT NULL,
	[TheLoai][nvarchar](50) NULL,
	
 CONSTRAINT [PK_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[name] [nvarchar](50) NOT NULL,
	[pass][nvarchar](50) NULL,
	[quyen][nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tra](
	[MaTra] [nvarchar](50) NOT NULL,
	[NgayTra][date] not null,
	[MaNhanVien] [nvarchar](50) not null,
	[MaMuon] [nvarchar](50) NOT NULL UNIQUE,
	
 CONSTRAINT [PK_Tra] PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muon](
	[MaMuon] [nvarchar](50) NOT NULL,
	[MaDocGia] [nvarchar](50) NOT NULL,
	[MaSach][nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayMuon][date] not null,
	[NgayHenTra][date] not null,
	[MaNhanVien] [nvarchar](50) not null,
 CONSTRAINT [PK_Muon] PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
Go

--Tạo view--------------------------------------------------
CREATE VIEW view_Muon AS
SELECT m.MaMuon,dg.MaDocGia,'Họ Tên Người Mượn' = dg.HoTen,s.MaSach, s.TenSach,tg.MaTacGia,tg.TenTacgia,ls.TheLoai, m.NgayMuon, m.NgayHenTra,m.SoLuong,nv.MaNhanVien,'Tên Nhân Viên' = nv.HoTen
FROM NhanVien as nv,DocGia as dg, Sach as s , Muon as m, LoaiSach as ls, TacGia as tg
WHERE nv.MaNhanVien = m.MaNhanVien and m.MaSach = s.MaSach and m.MaDocGia = dg.MaDocGia and ls.MaLoaiSach = s.MaLoaiSach and s.MaTacGia = tg.MaTacGia
Go 


CREATE VIEW view_Tra AS
select 'Tên Sinh Viên' = dg.HoTen, S.TenSach, m.SoLuong, m.NgayMuon, m.NgayHenTra, t.NgayTra, 'Tên Nhân Viên' = nv.HoTen
FROM NhanVien as nv, Sach as s, Muon as m, DocGia as dg, Tra as t
where nv.MaNhanVien = t.MaNhanVien and m.MaMuon = t.MaMuon and m.MaSach = s.MaSach and dg.MaDocGia = m.MaDocGia
Go

CREATE VIEW view_Tra_Report AS
select dg.HoTen, S.TenSach, m.SoLuong, m.NgayMuon, m.NgayHenTra, t.NgayTra, nv.MaNhanVien
FROM NhanVien as nv, Sach as s, Muon as m, DocGia as dg, Tra as t
where nv.MaNhanVien = t.MaNhanVien and m.MaMuon = t.MaMuon and m.MaSach = s.MaSach and dg.MaDocGia = m.MaDocGia
Go

CREATE VIEW view_Muon_report AS
SELECT dg.MaDocGia,dg.HoTen,s.MaSach, s.TenSach,tg.MaTacGia,tg.TenTacgia,ls.TheLoai, m.NgayMuon, m.NgayHenTra,m.SoLuong,nv.MaNhanVien
FROM NhanVien as nv,DocGia as dg, Sach as s , Muon as m, LoaiSach as ls, TacGia as tg
WHERE nv.MaNhanVien = m.MaNhanVien and m.MaSach = s.MaSach and m.MaDocGia = dg.MaDocGia and ls.MaLoaiSach = s.MaLoaiSach and s.MaTacGia = tg.MaTacGia


CREATE VIEW view_Sach AS
SELECT s.MaSach, s.TenSach,ls.MaLoaiSach, ls.TheLoai, s.SoLuong, tg.TenTacgia , tg.MaTacGia
FROM TacGia as tg, LoaiSach as ls,Sach as s
WHERE tg.MaTacGia = s.MaTacGia and ls.MaLoaiSach = s.MaLoaiSach

go

CREATE VIEW view_DSNo AS
Select Muon.MaMuon From Muon
Except
Select Tra.MaMuon From Tra
go

CREATE VIEW view_DSChuaTraSach AS
Select m.MaMuon,dg.HoTen,s.TenSach,m.SoLuong,m.NgayMuon,m.NgayHenTra, nv.MaNhanVien From view_DSNo as v,Muon as m, DocGia as dg, Sach as s, NhanVien as nv, TacGia as tg, LoaiSach as ls
where v.MaMuon = m.MaMuon and m.MaDocGia = dg.MaDocGia and s.MaTacGia = tg.MaTacGia and s.MaLoaiSach = ls.MaLoaiSach and nv.MaNhanVien = m.MaNhanVien and m.MaSach = s.MaSach
go

-------------------------------------------------------

ALTER TABLE [dbo].[Tra] WITH CHECK ADD  CONSTRAINT [FK_Muon_Tra] FOREIGN KEY([MaMuon])
REFERENCES [dbo].[Muon] ([MaMuon])

ALTER TABLE [dbo]. [Tra] WITH CHECK ADD  CONSTRAINT [FK_Tra_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo]. [NhanVien] ([MaNhanVien])

ALTER TABLE [dbo]. [Muon] WITH CHECK ADD  CONSTRAINT [FK_Muon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo]. [NhanVien] ([MaNhanVien])

ALTER TABLE [dbo]. [Muon] WITH CHECK ADD  CONSTRAINT [FK_Muon_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo]. [DocGia] ([MaDocGia])

ALTER TABLE [dbo]. [Muon] WITH CHECK ADD  CONSTRAINT [FK_Sach_Muon] FOREIGN KEY([MaSach])
REFERENCES [dbo]. [Sach] ([MaSach])

ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSach_Sach] FOREIGN KEY([MaLoaiSach])
REFERENCES [dbo].[LoaiSach] ([MaLoaiSach])

ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])

ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_TaiKhoan] FOREIGN KEY([name])
REFERENCES [dbo].[Taikhoan] ([name])

--- tài khoản
---------------------------------------------------
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('hoanganhky','1','master')
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('nguyenvansan','1','staff')
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('duynhat','1','staff')
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('ledaiduong','1','master')
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('ud','1','staff')

INSERT [dbo].[TacGia] ([MaTacGia],[TenTacgia],[DiaChi]) VALUES ('111',N'Tô Hoài',N'Long Khánh')
INSERT [dbo].[TacGia] ([MaTacGia],[TenTacgia],[DiaChi]) VALUES ('112',N'Tố Hữu',N'Biên Hòa')
INSERT [dbo].[TacGia] ([MaTacGia],[TenTacgia],[DiaChi]) VALUES ('113',N'CEO Hằng',N'Long Khánh')

INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('211',N'Lịch Sử')
INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('212',N'Văn Học')
INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('213',N'Vật Lí')
INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('214',N'Toán Học')
INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('215',N'Địa Lí')
INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('216',N'Sinh Học')
INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES ('217',N'Tâm Lí')

INSERT [dbo].[SACH] ([MaSach],[TenSach],[MaLoaiSach],[SoLuong],[MaTacGia]) VALUES ('311',N'Đại Việt Sử Kí Toàn Thư','211','8','111')
INSERT [dbo].[SACH] ([MaSach],[TenSach],[MaLoaiSach],[SoLuong],[MaTacGia]) VALUES ('312',N'100 Bài Toán Lãi Xuất','214','19','113')
INSERT [dbo].[SACH] ([MaSach],[TenSach],[MaLoaiSach],[SoLuong],[MaTacGia]) VALUES ('313',N'Chuyển Động Học','213','24','112')
INSERT [dbo].[SACH] ([MaSach],[TenSach],[MaLoaiSach],[SoLuong],[MaTacGia]) VALUES ('314',N'Tâm Lí Tội Phạm','217','35','113')

INSERT [dbo].[DocGia] ([MaDocGia],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh]) VALUES ('411','0987768122','true',N'Long Khánh',N'Nguyễn Văn A','01/01/2001')
INSERT [dbo].[DocGia] ([MaDocGia],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh]) VALUES ('412','0987768122','false',N'Đồng Nai',N'Nguyễn Thị B','01/01/2001')
INSERT [dbo].[DocGia] ([MaDocGia],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh]) VALUES ('413','0987768122','true',N'Biên Hòa',N'Nguyễn Văn C','01/01/2001')
INSERT [dbo].[DocGia] ([MaDocGia],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh]) VALUES ('414','0987768122','false',N'Dầu Giây',N'Nguyễn Thị E','01/01/2001')

INSERT [dbo].[NhanVien] ([MaNhanVien],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh],[name]) VALUES('NV01','0123456789','true',N'Biên Hòa',N'Nguyễn Văn San','10-10-2001','nguyenvansan')
INSERT [dbo].[NhanVien] ([MaNhanVien],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh],[name]) VALUES('NV02','0123456789', N'true',N'Biên Hòa',N'Trần Nguyễn Nhất Duy','10-10-2001','duynhat')

INSERT [dbo].[Muon] ([MaMuon],[MaDocGia],[MaSach],[SoLuong],[NgayMuon],[NgayHenTra],[MaNhanVien]) VALUES('7547535','411', '311','3','01/01/2019','01/01/2020','NV01')
INSERT [dbo].[Muon] ([MaMuon],[MaDocGia],[MaSach],[SoLuong],[NgayMuon],[NgayHenTra],[MaNhanVien]) VALUES('8695351','412', '312','5','01/02/2018','01/02/2019','NV02')
INSERT [dbo].[Muon] ([MaMuon],[MaDocGia],[MaSach],[SoLuong],[NgayMuon],[NgayHenTra],[MaNhanVien]) VALUES('6872157','413', '313','7','03/03/2018','09/09/2019','NV02')
INSERT [dbo].[Muon] ([MaMuon],[MaDocGia],[MaSach],[SoLuong],[NgayMuon],[NgayHenTra],[MaNhanVien]) VALUES('9869543','414', '314','2','05/04/2017','05/04/2019','NV01')

INSERT [dbo].[Tra] ([MaTra],[NgayTra],[MaNhanVien],[MaMuon]) VALUES('5246','12/12/2019','NV02','7547535')
INSERT [dbo].[Tra] ([MaTra],[NgayTra],[MaNhanVien],[MaMuon]) VALUES('7532','3/3/2019','NV01','8695351')
-----------------------------------------------------------------------------
/*
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('nguyenvansan','1','staff')
INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('duynhat','1','staff')

INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES('phamhongquan','1','client')

-- nhân viên 
INSERT [dbo].[NhanVien] ([MaNhanVien],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh],[name]) VALUES('NV01','0123456789',N'true',N'Biên Hòa',N'Nguyễn Văn San','10-10-2001','nguyenvansan')
INSERT [dbo].[NhanVien] ([MaNhanVien],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh],[name]) VALUES('NV02','0123456789', N'true',N'Biên Hòa',N'Trần Nguyễn Nhất Duy','10-10-2001','duynhat')


-- client
INSERT [dbo].[DocGia] ([MaDocGia],[SDT],[GioiTinh],[DiaChi],[HoTen],[NgaySinh]) VALUES('DG01','0123456789',N'true',N'Biên Hòa',N'Phạm Hồng Quân','10-10-2001')

*/

--select quyen from TaiKhoan where name = 'hoanganhky' and pass = '1'

select  NV.HoTen from NhanVien as NV, TaiKhoan as TK where NV.name = TK.name and TK.name = 'duynhat'
--select DATEDIFF(DAY,'1-1-2022','1-1-2021')
select * from NhanVien
select * from TaiKhoan

Select dg.MaDocGia,'Tên Độc Giả' = dg.HoTen,s.MaSach, s.TenSach,tg.MaTacGia,tg.TenTacgia,ls.TheLoai, m.NgayMuon, m.NgayHenTra,m.SoLuong,nv.MaNhanVien,'Tên Nhân Viên' = nv.HoTen 
From  NhanVien as nv,DocGia as dg, Sach as s , Muon as m, LoaiSach as ls, TacGia as tg
where nv.MaNhanVien = m.MaNhanVien and m.MaSach = s.MaSach and m.MaDocGia = dg.MaDocGia and ls.MaLoaiSach = s.MaLoaiSach and s.MaTacGia = tg.MaTacGia  


Select * From view_Muon

select * from TacGia
select * from LoaiSach
select SoLuong-2 from Sach where MaSach = '312'
select * from DocGia
select * from view_Sach
select count(*) from view_Sach where TenSach = N'101 Cách Giải Ngân'
select MaSach, TenSach, TheLoai, SoLuong, TenTacgia from view_Sach where TenSach = N'101 Cách Giải Ngân'

	




select [Họ Tên Người Mượn],TenSach,SoLuong, NgayMuon,NgayHenTra,[Tên Nhân Viên]  from View_Muon
select * from Muon
select  NV.MaNhanVien from NhanVien as NV, TaiKhoan as TK where NV.name = TK.name and TK.name = 'duynhat'
INSERT [dbo].[Muon] ([MaMuon],[MaDocGia],[MaSach],[SoLuong],[NgayMuon],[NgayHenTra],[MaNhanVien]) VALUES('Muon03','412', '312','5','01/02/2018','01/02/2019','NV02')

select GETDATE()

select m.MaMuon from Muon as m,DocGia as dg where m.MaDocGia = dg.MaDocGia and dg.HoTen = N'Nguyễn Thị B' and m.NgayMuon = '2018-01-02'
select * From Muon
INSERT [dbo].[Tra] ([MaTra],[NgayTra],[MaNhanVien],[MaMuon]) 
INSERT into Tra VALUES('Tra03','2021-06-11 04:14:54.740','NV01','1557040')
select * from Tra
DELETE from Tra where MaTra = 'Tra03'
select * from view_Tra
/*
select 'Tên Sinh Viên' = dg.HoTen, S.TenSach, m.SoLuong, m.NgayMuon, m.NgayHenTra, t.NgayTra, 'Tên Nhân Viên' = nv.HoTen
FROM NhanVien as nv, Sach as s, Muon as m, DocGia as dg, Tra as t
where nv.MaNhanVien = t.MaNhanVien and m.MaMuon = t.MaMuon and m.MaSach = s.MaSach and dg.MaDocGia = m.MaDocGia*/


select MaSach from Sach where TenSach = N'Đại Việt Sử Kí Toàn Thư'



Select * From view_Muon_report



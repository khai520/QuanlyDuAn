USE QLBDS
GO
CREATE TABLE TkDangNhap(
	Chucdanh varchar(10) null,
	IDtk int identity(1,1) Primary key not null,
	Tdn nvarchar(max) not null,
	Mk nvarchar(max) not null,
	HoTen nvarchar(max) not null,
	Gt char(5) not null,
	Ns date not null,
	Gmail nvarchar(max) null,
	Sdt nvarchar(10) null
)
GO
CREATE TABLE DuAnChuaDuyet(
	IDda int identity(1,1) Primary key not null,
	TenDuAn nvarchar(max) not null,
	Diachi nvarchar(max) not null,
	Mota nvarchar(max) null,
	Gia int null,
	Dientich float null,
	IDtk int not null,
	Foreign key (IDtk) references TkDangNhap(IDtk)
)
GO
Create table DuAnDaDuyet(
	IDda int identity(1,1) not null,
	TenDuAn nvarchar(max) not null,
	Diachi nvarchar(max) not null,
	Mota nvarchar(max) null,
	Gia int null,
	Dientich float null,
	IDtk int not null,
	Foreign key (IDtk) references TkDangNhap(IDtk)
)


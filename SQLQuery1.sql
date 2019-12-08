create DATABASE qltv
go

use qltv

create table Sach
	(MaSach varchar(10) not null primary key,
	Tensach nvarchar(50),
	MaTL varchar(10) not null,
	MaTG varchar(10) not null,
	MaNXB varchar(10) not null,
	NamXB int not null
	);

create table tacgia
(
 MaTG varchar(10) not null primary key,
 Tentacgia nvarchar(50) not null,
 Ghichu nvarchar(50) null
);

create table theloai
(
MaTL varchar(10) not null primary key,
TenTL nvarchar (50) not null
);

create table nxb
(
MaNXB varchar(10) not null primary key,
TenNXB nvarchar(20) not null,
DChi nvarchar(50) not null,
Email nvarchar(50) not null,
SoDT varchar(10) not null
);

create table taikhoan
	(TenDN varchar(10) not null primary key,
	Matkhau int not null,
	quyen nvarchar(10),
	);

create table docgia
 (Madocgia varchar(10) not null primary key,
  tendocgia nvarchar(50) not null,
  diachi nvarchar(20) not null,
  sdt varchar(10) not null,	
  sothe varchar(10) not null,
  );

create table NhanVien
(
MaNV varchar(10) not null primary key,
Hoten nvarchar(50) not null,
NgSinh date not null,
sdt int not null
);

create table thethuvien
(
Sothe varchar(10) not null primary key,
NgBD date not null,
NgKT date not null
);

create table ctmuontra
(
 Mamt varchar(10),
 Masach varchar(10) not null,
 CONSTRAINT Datra CHECK (NgTra <> null),
 NgTra date null,
 CONSTRAINT pk_department PRIMARY KEY (Mamt),
);

create table muontra
(
Mamt varchar(10) not null primary key,
Sothe varchar(10) not null,
MaNV varchar(10) not null,
NgMuon date not null

);
	
alter table sach
	with nocheck add constraint fk_sach
	foreign key (MaTG) references tacgia(MaTG),
	foreign key (MaNXB) references nxb(MaNXB);

alter table docgia
	with nocheck add constraint fk_dg
	foreign key (Sothe) references thethuvien(Sothe);

alter table muontra
	with nocheck add constraint fk_mt
	foreign key (Sothe) references thethuvien(Sothe),
	foreign key (MaNV) references NhanVien(MaNV);

alter table ctmuontra
	with nocheck add constraint fk_ct
	foreign key (Mamt) references muontra(mamt),
	foreign key (Masach) references sach(Masach);

alter table nhanvien
	with nocheck add constraint fk_nv
	foreign key (TenDN) references taikhoan(TenDN);


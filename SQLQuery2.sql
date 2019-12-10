use qltv
go

--dangnhap
If OBJECT_ID('dangnhap') IS NOT NULL
	DROP PROC dangnhap;
go
create proc dangnhap
(
@tentaikhoan varchar(10),
@Matkhau int,
@quyen nvarchar(10)
)
as
select * from taikhoan 
where TenDN = @tentaikhoan and Matkhau = @Matkhau and quyen = @quyen;

--themtaikhoan
If OBJECT_ID('themtaikhoan') IS NOT NULL
	DROP PROC themtaikhoan;
go
create proc themtaikhoan
(
@tenDN varchar(10),
@Matkhau int,
@quyen nvarchar(10)
)
as
begin
insert into taikhoan
	values(@tenDN, @Matkhau, @quyen);
end

--thong tin tai khoan
If OBJECT_ID('thongtintaikhoan') IS NOT NULL
	DROP PROC thongtintaikhoan;
go
create proc thongtintaikhoan
as
begin
select * from taikhoan where quyen = 'user';
end
--suataikhoan
If OBJECT_ID('suataikhoan') IS NOT NULL
	DROP PROC suataikhoan;
go
create proc suataikhoan
(
@tenDN varchar(10),
@Matkhau int
)
as
update taikhoan
set Matkhau = @Matkhau
where tenDN = @tenDN;

--xoataikhoan
If OBJECT_ID('xoataikhoan') IS NOT NULL
	DROP PROC xoataikhoan;
go
create proc xoataikhoan
(
@tenDN varchar(10)
)
as
delete from taikhoan where TenDN = @tenDN;
--tim kiem
If OBJECT_ID('timkiemtaikhoan') IS NOT NULL
	DROP PROC timkiemtaikhoan;
go
create proc timkiemtaikhoan
(
@tenDN varchar(10)
)
as
select * from taikhoan where TenDN LiKE @tenDN +'%';

--tim kiem docgia theo tendocgia
If OBJECT_ID('timkiemdocgia1') IS NOT NULL
	DROP PROC timkiemdocgia1;
go
create proc timkiemdocgia1
(
@Tendocgia varchar(50)
)
as
select madocgia, tendocgia, diachi, sdt, sothe
from docgia
where tendocgia LIKe @Tendocgia +'%';
go
--thong tin docgia
If OBJECT_ID('thongtindocgia') IS NOT NULL
	DROP PROC thongtindocgia;
go
create proc thongtindocgia
as
begin
select * from docgia;
end
--xoa docgia
If OBJECT_ID('xoadocgia') IS NOT NULL
	DROP PROC xoadocgia;
go
create proc xoadocgia
(
@Madocgia varchar(10)
)
as
delete from docgia where Madocgia = @Madocgia;
--tim kiem docgia theo ma doc gia
IF OBJECT_ID('timkiemdocgia2') IS NOT NULL
	DROP PROC timkiemdocgia2;
go
CREATE PROC timkiemdocgia2
(
@Madocgia varchar(10)
)
as
select madocgia, tendocgia, diachi, sdt, sothe
from docgia
where Madocgia LIKe @Madocgia +'%';
go

-- tim kiem docgia theo so the
IF OBJECT_ID('timkiemdocgia3') IS NOT NULL
	DROP PROC timkiemdocgia3;
go
CREATE PROC timkiemdocgia3
(
@sothe varchar(10)
)
as
select madocgia, tendocgia, diachi, sdt, sothe
from docgia
where sothe LIKe @sothe+'%';
go
--updatedocgia
If OBJECT_ID('updatedocgia') IS NOT NULL
	DROP PROC updatedocgia;
go
create proc updatedocgia
			@diachi nvarchar(20), @sdt varchar(10), @madocgia varchar(10)
as
update docgia set diachi = @diachi, sdt = @sdt where Madocgia = @madocgia

--them docgia
If OBJECT_ID('themdocgia') IS NOT NULL
	DROP PROC themdocgia;
go
create proc themdocgia
(@madocgia varchar(10),
@tendocgia nvarchar(50),
@diachi nvarchar(20), 
@sdt varchar(10),
@sothe varchar(10)
)
as
insert into docgia
	values(@madocgia, @tendocgia, @diachi, @sdt, @sothe);

--thong tin nxb

If OBJECT_ID('ttnxb') IS NOT NULL
	DROP PROC ttnxb;
go

create proc ttnxb
as
select * from nxb

--them nxb
IF OBJECT_ID('themnxb') IS NOT NULL
	DROP PROC themnxb;
go
create proc themnxb
(
@MaNXB varchar(10),
@TenNXB varchar(20),
@Dchi varchar(50),
@Email varchar(50),
@sothe varchar(10)
)
as
insert into nxb
	values(@MaNXB, @TenNXB, @Dchi, @Email, @sothe);

--sua thong tin nxb
If OBJECT_ID('suanxb') IS NOT NULL
	DROP PROC suanxb;
go
create proc suanxb
			@MaNXB varchar(10), @Dchi varchar(50), @Email varchar(50), @SDT varchar(10)
as
update nxb set DChi = @Dchi, Email = @Email, SoDT = @SDT where MaNXB = @MaNXB;
--thong tin sach
IF OBJECT_ID('xemttsach') IS NOT NULL
	DROP PROC xemttsach;
go
create proc xemttsach
(
@masach varchar(10)
)
as
select masach, Tensach, TenNXB, Tentacgia, MaTL, Soluong, NamXB
from sach, tacgia, nxb
where sach.MaTG = tacgia.MaTG and sach.MaNXB = nxb.MaNXB
 and MaSach = @masach;

 --liet ke nhung doc giả đang muon sach
 IF OBJECT_ID('docgiamuonsach') IS NOT NULL
	DROP PROC docgiamuonsach;
go
create proc docgiamuonsach
as
begin
select Madocgia, tendocgia
from docgia, muontra, ctmuontra, thethuvien
where docgia.sothe = thethuvien.Sothe and muontra.Sothe = thethuvien.Sothe
and muontra.Mamt = ctmuontra.Mamt and ctmuontra.NgTra <> null;
end 

--liệt kê nhũng độc giả mượn sách quá hạn
 IF OBJECT_ID('docgiaquahan') IS NOT NULL
	DROP PROC docgiaquahan;
go
create proc docgiaquahan
(
@ngayhientai date
)
as 
begin
select Madocgia, tendocgia
from docgia, muontra, ctmuontra, thethuvien
where docgia.sothe = thethuvien.Sothe and muontra.Sothe = thethuvien.Sothe
and muontra.Mamt = ctmuontra.Mamt and ctmuontra.NgTra <> null
and @ngayhientai - muontra.NgMuon > 90;
end

--thêm nxb moi
If OBJECT_ID('themsachmoi') IS NOT NULL
	DROP PROC themsachmoi;


	select top 1 *
	from docgia ;

INSERT INTO taikhoan Values('nguyen3',1,'user')
PRINT @@IDENTITY;
Delete taikhoandeleted where STT = MAX(STT);


set A = select max(stt) as abc From taikhoandeleted;
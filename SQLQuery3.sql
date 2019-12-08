use qltv;

go

IF OBJECT_ID('Invoices_DELETE') IS NOT NULL
	DROP TRIGGER Invoices_DELETE;
go

CREATE TRIGGER Invoices_DELETE
ON taikhoan
AFTER DELETE
AS
INSERT INTO taikhoandeleted
(tenDN, MatKau, quyen)
SELECT tenDN, Matkhau, quyen
FROM Deleted;

--lay ma nhan vien theo user
IF OBJECT_ID('manvtheouser') IS NOT NULL
	DROP proc manvtheouser;
go

create proc manvtheouser
(@tendangnhap varchar(10))
as
select MaNV
from NhanVien
where TenDN = @tendangnhap;


IF OBJECT_ID('xemthongtinuser') IS NOT NULL
	DROP proc xemthongtinuser;
go

create proc xemthongtinuser
(@manhanvien varchar(10))
as
select taikhoan.TenDN, Matkhau, MaNV, Hoten, NgSinh, sdt
from NhanVien join taikhoan on NhanVien.TenDN = taikhoan.TenDN
where taikhoan.TenDN = @manhanvien;

If OBJECT_ID('chinhsuathongtinuser') is not null
	drop proc chinhsuathongtinuser
go

create proc chinhsuathongtinuser
(
@tendangnhap varchar(10), 
@Manhanvien varchar(10),
@Hoten nvarchar(50),
@SDT int,
@NgSinh Date
)
as
update NhanVien
set MaNV = @Manhanvien, Hoten = @Hoten,  NgSinh = @NgSinh, sdt = @SDT
where tenDN = @tendangnhap;

If OBJECT_ID('timkiemsachmasach') is not null
	drop proc timkiemsachmasach
go
create proc timkiemsachmasach
(
@masach varchar(10)
)
as
select *
from Sach
where MaSach = @masach;
--
If OBJECT_ID('timkiemsachtensach') is not null
	drop proc timkiemsachtensach
go
create proc timkiemsachtensach
(
@tensach nvarchar(50)
)
as
select *
from Sach
where Tensach = @tensach;

If OBJECT_ID('timkiemsachtheloai') is not null
	drop proc timkiemsachtheloai
go
create proc timkiemsachtheloai
(
@theloai varchar(10)
)
as
select *
from Sach
where MaTL = @theloai;


If OBJECT_ID('themsach') is not null
	drop proc themsach
go
create proc themsach
(
@masach varchar(10),
@tensach nvarchar(50),
@theloai varchar(10),
@matg varchar(10),
@manxb varchar(10),
@namxb int,
@soluong int
)
as
insert into Sach
	values(@masach, @tensach, @theloai, @manxb, @matg, @namxb, @soluong);

If OBJECT_ID('ttsach') is not null
	drop proc ttsach
go
create proc ttsach
as
select *
from Sach

If OBJECT_ID('updatesach') IS NOT NULL
	DROP PROC updatesach;
go
create proc updatesach
			@tensach nvarchar(50), @namxb int, @soluong int, @matl varchar(10), @manxb varchar(10), @matg varchar(10)
as
update Sach set Tensach = @tensach, NamXB = @namxb, Soluong = @soluong, Matg = @matg, MaTL = @matl, MaNXB = @manxb;

if OBJECT_ID('ttuser') is not null
	drop view ttuser
go
create view ttuser
as 
select NhanVien.TenDN, Matkhau, MaNV, Hoten, NgSinh, sdt
from taikhoan join NhanVien on taikhoan.TenDN = NhanVien.TenDN
go
if OBJECT_ID('xemttuser') is not null
	drop proc xemttuser
go
create proc xemttuser
(@manv varchar(10))
as 
select TenDN, Matkhau, MaNV, Hoten, NgSinh, sdt
from ttuser
where MaNV = @manv;
go

if OBJECT_ID('ttuser_update') is not null
	drop trigger ttuser_update
 go
 create trigger ttuser_update on ttuser
 instead of update
 as
 declare @Tendn varchar(10), @matkhau int, @hoten nvarchar(50), @Ngsinh date, @sdt int, @count int;
 select @count = count(*) from inserted;
 if @count = 1
	begin
		select @Tendn = TenDN, @matkhau = Matkhau, @hoten = Hoten, @Ngsinh = NgSinh, @sdt = sdt
		from inserted
		if (@Tendn is not null and @matkhau is not null and @hoten is not null and @Ngsinh is not null and @sdt is not null)
		begin 
			update taikhoan
			set Matkhau = @matkhau
			where tenDN = @tenDN;
			update NhanVien
			set Hoten = @hoten, NgSinh = @Ngsinh, sdt = @sdt 
			where TenDN = @Tendn 
		end
	end

if OBJECT_ID('suattuser') is not null
	drop proc suattuser
go

create proc suattuser
(@Tendn varchar(10), @matkhau int, @manv varchar(10), @hoten nvarchar(50), @Ngsinh date, @sdt int)
as
begin 
update ttuser
set TenDN = @Tendn, Matkhau = @matkhau, Hoten = @hoten, NgSinh = @Ngsinh, sdt = @sdt
where TenDN = @Tendn 
end

declare @A date
select @A = convert(date,'2019-12-05')

if OBJECT_ID('ttmuontra') IS NOT NULL
	DROP view ttmuontra;
go

create view ttmuontra
as
select muontra.Mamt, Sothe, MaNV, Masach, NgMuon, NgTra
from muontra join ctmuontra on muontra.Mamt = ctmuontra.Mamt

If OBJECT_ID('ttmuontrasach') is not null
	drop proc ttmuontrasach
go
create proc ttmuontrasach
as
select Mamt, Sothe, MaNV, Masach, NgMuon, NgTra
from ttmuontra;

If OBJECT_ID('ttctmuontra') is not null
	drop proc ttctmuontra
go
create proc ttctmuontra
as
select *
from ctmuontra;

If OBJECT_ID('xemmuontra') is not null
	drop proc xemmuontra
go
create proc xemmuontra
as
select *
from muontra;

If OBJECT_ID('trasach') is not null
	drop proc trasach
go
create proc trasach
(@mamt varchar(10), @NgTra date)
as
update ctmuontra
set NgTra = @NgTra
where NgTra is not null and Mamt = @mamt;


DECLARE @sql AS NVARCHAR(1000);
DECLARE @table AS int=0;
DECLARE @table1 AS int=0;
SELECT @sql = 'SELECT *
				FROM '
				+ CASE
				WHEN @table = 1 THEN  'dbo.xemmuontra'   
				When @table = 2 then 'dbo.ttmuontrasach'
			  END +'		 			   
			   ';
 EXEC sp_executesql
 @sql
go

if OBJECT_ID('ttmuontra_Insert') is not null
	drop trigger ttmuontra_Insert;
go
create trigger ttmuontra_Insert
	on ttmuontra
	instead of insert
as
declare @Mamt varchar(10), @Sothe varchar(10), @MaNV varchar(10), @Masach varchar(10), @NgMuon Date, @NgTra Date, @Test int;

select @Test = count(*) from inserted
if (@Test = 1)
begin 
	select @Mamt = Mamt, @Sothe = Sothe, @MaNV = MaNV, @Masach = Masach, @NgMuon = NgMuon, @NgTra = NgTra
	from inserted

	if (@Mamt is not null and @Sothe is not null and @MaNV is not null and @Masach is not null and @NgMuon is not null)
		begin 
			insert muontra (Mamt, Sothe, MaNV, NgMuon)
			values (@Mamt, @Sothe, @MaNV, @NgMuon)
			insert ctmuontra (Mamt, Masach, NgTra)
			values (@Mamt, @Masach, @NgTra)
		end;
	else throw 50027, 'loi',1;
end;
else throw 50027, 'loi',1;


go

create proc themview
(@mamt varchar(10), @sothe varchar(10), @Manv varchar(10), @Ngmuon date, @Ngtra date, @masach varchar(10))
as
begin 
insert into ttmuontra values (@mamt, @sothe, @Manv, @masach, @Ngmuon, @Ngtra)
end

declare @A date
select @A = convert(date,'2019-12-05')
exec themview '11','st2','NV4', @A, null,'3';

create nonclustered index index_muontra_nhanvien
on muontra(MaNV, Mamt)

select Mamt
from muontra
where MaNV = 'NV3'


If OBJECT_ID('thongtinthe') is not null
	drop proc thongtinthe
go
create proc thongtinthe
as
select *
from thethuvien

If OBJECT_ID('themthe') is not null
	drop proc themthe
go
create proc themthe
(
@sothe varchar(10), @NgBD date, @NgKT date
)
as
insert into thethuvien
	values (@Sothe, @NgBD, @NgKT)

If OBJECT_ID('suathe') is not null
	drop proc suathe
go
create proc suathe
(
@sothe varchar(10)
)
as
begin
declare @D int;
declare @M int;
declare @Y int;
declare @NGKT varchar(MAX);
select @D = Convert(int,Day(NgKT)), @M = Convert(int,Month(NgKT)),@Y = CONVERT(int,Year(NgKT))
from thethuvien
where thethuvien.Sothe = @sothe

if(@M > 9)
begin
	set @Y = @Y +  1
	set @M = @M - 9
end
else
begin
	set @M = @M + 3
end
	select @NGKT = CONVERT(Varchar,@Y) + '/' + CONVERT(varchar,@M) + '/' +  Convert(varchar,@D) 
	update thethuvien
	set NgKT = @NGKT
	where Sothe = @sothe
	end
go

exec suathe 'st1'



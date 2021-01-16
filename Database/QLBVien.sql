--USE MASTER
--GO
IF DB_ID('QLBV') IS NOT NULL
	DROP DATABASE QLBV
GO
CREATE DATABASE QLBV
GO
USE QLBV
GO

--CREATE TABLE
CREATE TABLE NGUOIDUNG(
	TenDangNhap nvarchar(100) PRIMARY KEY,
	MatKhau nvarchar(1000) not null default N'123456',
	Loai nvarchar(20)
	)
CREATE TABLE BENHNHAN
(
	MaBN int identity ,
	CMND nvarchar(20),
	HoTenBN NVARCHAR(50),
	NgaySinhBN DATE,
	GioiTinhBN NVARCHAR(3),
	DienThoaiBN NVARCHAR(10),
	DiaChiBN NVARCHAR (100)
	PRIMARY KEY(MaBN)
)
CREATE TABLE BENHAN
(
	MaBA int identity,
	MaBN int,
	TinhTrangTruocNhapVien nvarchar(100),
	TinhTrangSauNhapVien nvarchar(100)
	PRIMARY KEY(MaBA)
)
CREATE TABLE BACSI
(
	MaBS int identity,
	CMND nvarchar(20),
	HoTenBS NVARCHAR(50),
	NgaySinhBS DATE,
	GioiTinhBS NVARCHAR(3),
	DienThoaiBS NVARCHAR(10),
	DiaChiBS NVARCHAR (100),
	MaKhoa int
	PRIMARY KEY(MaBS)
)
CREATE TABLE KHOA
(
	MaKhoa int identity ,
	TenKhoa NVARCHAR(50)
	PRIMARY KEY(MaKhoa)
)
CREATE TABLE PHIEUKHAM
(
	MaPK int identity,
	MaBS int,
	MaBN int,
	NgayKham DATETIME,
	TrieuChung NVARCHAR(50),
	BHYT int
	PRIMARY KEY(MaPK)
)
create TABLE XETNGHIEM
(
	MaXN int identity,
	MaBN INT,
	MaPK int
	PRIMARY KEY(MaXN)
)
CREATE TABLE CT_XETNGHIEM
(
	MaCTXN int identity,
	MaXN INT,
	MaDV INT,
	NgayXetNghiem datetime,
	YeuCauXetNghiem nvarchar(500)
	PRIMARY KEY(MaCTXN)
)
create TABLE KETQUA
(
	MaKQ int identity,
	MaXN INT,
	NgayLapKetQua datetime,
	NoiDung nvarchar(500),
	HuongDieuTri nvarchar(20)
	PRIMARY KEY(MaKQ)
)
CREATE TABLE THUOC
(
	MaThuoc int identity,
	TenThuoc NVARCHAR(50),
	DonVi NVARCHAR(10), --Chai, hop, vien
	DonGia real
	PRIMARY KEY(MaThuoc)
)
CREATE TABLE DONTHUOC
(
	MaDT int identity,
	MAKQ INT,
	MABN INT,
	NgayTao datetime,
	PRIMARY KEY(MaDT)
)
CREATE TABLE CT_DONTHUOC
(
	MaCTDT int identity,
	MaThuoc int,
	MADT int,
	SoLuong int,
	HuongDan nvarchar(50)
	PRIMARY KEY(MaCTDT)
)
CREATE TABLE DICHVU
(
	MaDV int identity,
	TenDV nvarchar(100),
	DonGia real,
	PRIMARY KEY(MaDV)
)
CREATE TABLE CHUYENVIEN
(
	MACV INT IDENTITY,
	MABN INT,
	LYDOCHUYENVIEN NVARCHAR(100),
	TINHTRANGTRUOCKHICHUYEN NVARCHAR(100)
	PRIMARY KEY(MACV)
)
CREATE TABLE HOADON
(
	MAHD INT IDENTITY,
	MABN INT,
	NGAYLAP DATETIME,
	TINHTRANG NVARCHAR(20),
	TONGTIEN REAL
	PRIMARY KEY(MAHD)
)
CREATE TABLE CT_HOADON
(
	MACTHD INT IDENTITY,
	MAHD INT,
	MAXN INT,
	MADT INT
	PRIMARY KEY(MACTHD)
)

--ALTER TABLE
ALTER TABLE PHIEUKHAM
ADD
	CONSTRAINT FK_PHIEUKHAM_BACSI
	FOREIGN KEY(MaBS)
	REFERENCES BACSI,
	CONSTRAINT FK_PHIEUKHAM_BENHNHAN
	FOREIGN KEY(MaBN)
	REFERENCES BENHNHAN
go
ALTER TABLE BACSI
ADD
	CONSTRAINT FK_BACSI_KHOA
	FOREIGN KEY(MaKhoa)
	REFERENCES KHOA
go
ALTER TABLE HOADON
ADD
	CONSTRAINT FK_HOADON_BENHNHAN
	FOREIGN KEY(MaBN)
	REFERENCES BENHNHAN
go
ALTER TABLE CT_HOADON
ADD
	CONSTRAINT FK_CT_HOADON_XETNGHIEM
	FOREIGN KEY(MaXN)
	REFERENCES XETNGHIEM,
	CONSTRAINT FK_CT_HOADON_DONTHUOC
	FOREIGN KEY(MaDT)
	REFERENCES DONTHUOC,
	CONSTRAINT FK_CT_HOADON_HOADON
	FOREIGN KEY(MaHD)
	REFERENCES HOADON
go
ALTER TABLE XETNGHIEM
ADD
	CONSTRAINT FK_XETNGHIEM_PHIEUKHAM
	FOREIGN KEY(MAPK)
	REFERENCES PHIEUKHAM,
	CONSTRAINT FK_XETNGHIEM_BENHNHAN
	FOREIGN KEY(MABN)
	REFERENCES BENHNHAN
GO
ALTER TABLE CT_DONTHUOC
ADD
	CONSTRAINT FK_CT_DONTHUOC_THUOC
	FOREIGN KEY(MATHUOC)
	REFERENCES THUOC,
	CONSTRAINT FK_CT_DONTHUOC_DONTHUOC
	FOREIGN KEY(MADT)
	REFERENCES DONTHUOC

GO
ALTER TABLE DONTHUOC
ADD
	CONSTRAINT FK_DONTHUOC_KETQUA
	FOREIGN KEY(MAKQ)
	REFERENCES KETQUA,
	CONSTRAINT FK_DONTHUOC_BENHNHAN
	FOREIGN KEY(MABN)
	REFERENCES BENHNHAN
GO
ALTER TABLE CT_XETNGHIEM
ADD
	CONSTRAINT FK_CTXETNGHIEM_XETNGHIEM
	FOREIGN KEY(MAXN)
	REFERENCES XETNGHIEM
go
ALTER TABLE KETQUA
ADD
	CONSTRAINT FK_KETQUA_XETNGHIEM
	FOREIGN KEY(MAXN)
	REFERENCES XETNGHIEM
go
ALTER TABLE BENHAN
ADD
	CONSTRAINT FK_BENHAN_BENHNHAN
	FOREIGN KEY(MABN)
	REFERENCES BENHNHAN
	
GO
ALTER TABLE CHUYENVIEN
ADD
	CONSTRAINT FK_CHUYENVIEN_BENHNHAN
	FOREIGN KEY(MABN)
	REFERENCES BENHNHAN
go
--ALTER TABLE CT_XETNGHIEM
--ADD
--	CONSTRAINT FK_CT_XETNGHIEM_DICHVU
--	FOREIGN KEY(MADV)
--	REFERENCES DICHVU
--go
INSERT INTO NGUOIDUNG
VALUES(N'admin',N'admin',N'Admin'),
(N'doctor',N'doctor',N'Bác sĩ')
go
--PROCEDURE
CREATE PROC USP_LOGIN -- HẠN CHẾ LỖI SQL Injection
@username nvarchar(100),@passwork nvarchar(100)
as
begin
	SELECT * FROM DBO.NGUOIDUNG WHERE tendangnhap=@username AND matkhau=@passwork
end
go
CREATE PROC USP_SUAMATKHAU
@username nvarchar(100),@passwork nvarchar(100),@newpasswork nvarchar(100)
as
begin
	declare @IsRigthPass int=0
	select @IsRigthPass = count(*) from dbo.NGUOIDUNG where tendangnhap=@username and matkhau=@passwork
	if(@IsRigthPass =1)
	begin
		if(@newpasswork <> NULL or @newpasswork <> '')
		begin
			UPDATE dbo.NGUOIDUNG set matkhau=@newpasswork where TenDangNhap = @username
		end
	end
end
go
--Function
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000))  --Chuyển ký tự có dấu về không dấu
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
GO
--
insert into BENHNHAN Values('206266333',N'Võ Đức Long','1998/10/10','Nam','0707070707','HCM')

insert into KHOA values
(N'Khoa ngoại'),
(N'Khoa nội'),
(N'Khoa phụ sản'),
(N'Khoa nhi'),
(N'Khoa cấp cứu'),
(N'Khoa hồi sức'),
(N'Khoa ung bướu')
insert into BACSI values('206266331',N'Dương Khả Hân','1999/09/19',N'Nữ','0702707707','HCM',1)
insert into DICHVU values
(N'Chụp X-Quang',300000),
(N'Chụp CT-Scan',1500000)
insert into THUOC values
(N'Paracetamol',N'Viên',10000),
(N'Fucagar',N'Hộp',20000)

--TRIGGER
GO
--CREATE TRIGGER UTG_KIEMTRABENHNHAN -- kiểm tra thêm hoặc sửa BENHNHAN có trùng cmnd không
--ON BENHNHAN FOR INSERT,UPDATE
--AS
--BEGIN
--	DECLARE @CMND nvarchar(20)=(SELECT CMND FROM inserted I)
--	IF EXISTS (SELECT bn.CMND FROM BENHNHAN bn WHERE bn.CMND=@CMND)
--	BEGIN
--		rollback
--	END
--END
--GO
select * from KHOA
select * from BACSI
select * from BENHNHAN
select * from PHIEUKHAM
select * from dichvu
select * from XETNGHIEM
select * from CT_XETNGHIEM
select * from ketqua
select * from THUOC
select * from donthuoc
select * from CT_DONTHUOC
select * from BENHAN
SELECT * FROM CHUYENVIEN
select * from hoadon
select * from CT_HOADON
select * from NGUOIDUNG
select BHYT from PHIEUKHAM where MaBN=1
update hoadon set tinhtrang=N'Chưa thanh toán'
USE MASTER
GO
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
select tendangnhap,loai from NGUOIDUNG
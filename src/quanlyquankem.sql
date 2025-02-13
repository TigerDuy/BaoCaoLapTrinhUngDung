CREATE DATABASE quanlyquankem
GO

USE quanlyquankem
GO

-- Kem
-- Bàn
-- Danh mục Kem
-- Tài khoản
-- Hóa đơn
-- Thông tin hóa đơn

CREATE TABLE ban
(
	id INT IDENTITY PRIMARY KEY,
	ten NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- Trống || Có người
)
GO

CREATE TABLE tai_khoan
(
	ten_nguoi_dung NVARCHAR(100) PRIMARY KEY,
	ten_hien_thi NVARCHAR(100) NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000)NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1: admin && 0: nhân viên
)
GO

CREATE TABLE danh_muc
(
	id INT IDENTITY PRIMARY KEY,
	ten NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE kem
(
	id INT IDENTITY PRIMARY KEY,
	ten NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	id_danh_muc INT NOT NULL,
	gia FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (id_danh_muc) REFERENCES dbo.danh_muc(id)
)
GO

CREATE TABLE hoa_don
(
	id INT IDENTITY PRIMARY KEY,
	ngay_nhan DATE NOT NULL DEFAULT GETDATE(),
	ngay_tra DATE,
	id_ban INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (id_ban) REFERENCES dbo.ban(id)
)
GO

CREATE TABLE thong_tin_hoa_don
(
	id INT IDENTITY PRIMARY KEY,
	id_hoa_don INT NOT NULL,
	id_kem INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (id_hoa_don) REFERENCES dbo.hoa_don(id),
	FOREIGN KEY (id_kem) REFERENCES dbo.kem(id)
)
GO
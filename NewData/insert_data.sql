USE QLLichHen
GO
SET DATEFORMAT DMY
GO
------------INSERT DU LIEU----------------
INSERT INTO NHANVIEN
VALUES 
('NV005', N'Nguyễn Tiến Linh',	'0906876545', '10/02/1990', 'Nam'	, 'HCM'),
('NV002', N'Nguyễn Văn Thanh',	'0908987654', '11/06/2000', 'Nam'	, 'HCM'),
('NV003', N'Phạm Thanh Thảo',	'0908767543', '12/06/2001', N'Nữ'	, 'HCM'),
('NV004', N'Phạm Văn Phú Cường','0907845365', '24/03/2001', 'Nam'	, 'HCM'),
('NV001', N'Trân Tiến',			'0908765723', '12/11/1995', 'Nam'	, 'HCM');
---
GO
INSERT INTO KHACHHANG
VALUES 
('KH0001', N'Nguyễn Thị Thu',	123548697	,	N'Nữ',	'12/06/2001', N'9 Phan Huy Ích', 0903698574),
('KH0002', N'Trần Phú Xuân',	342121231	,	'Nam',	'15/02/2001', N'12 Lạc Long Quân', 0903698574),
('KH0003', N'Lê Thị Hương',		125334231	,	N'Nữ',	'23/01/2001', N'8/9 Nguyễn Trãi', 088965743),
('KH0004', N'Quế Ngọc Hải',		231151312	,	'Nam',	'01/06/2001', N'541/8 Lạc Long Quân', 088741689),
('KH0005', N'Nguyễn Văn Quý',	131214112	,	'Nam',	'07/08/2001', N'789 An Dương Vương-F5-Q.5', 0908756548),
('KH0006', N'Lại Văn Sâm',		514134141	,	'Nam',	'27/05/2001', N'36 Hùng Vương F6 Q.5', 0908759842);
---
GO
INSERT INTO BACSI
VALUES 
('BS005', N'Nguyễn Tiến Dũng',	'0906876545', '10/02/1990', 'Nam'	, 'HCM', N'Đại Học', N'Sức Khoẻ TH', N'Bác sĩ'),
('BS002', N'Nguyễn Khánh Hiệp',	'0908987654', '11/06/2000', 'Nam'	, 'HCM', N'Tiến Sĩ', N'Sức Khoẻ TH', N'Bác sĩ'),
('BS003', N'Phạm Thanh Tâm',	'0908767543', '12/06/2001', N'Nữ'	, 'HCM', N'Giáo sư', N'Mắt', N'Y tá'),
('BS004', N'Phạm Văn Phú',		'0907845365', '24/03/2001', 'Nam'	, 'HCM', N'Tiến Sĩ', N'Tim Mạch', N'Dược sĩ'),
('BS001', N'Trần Tiến Minh',	'0908765723', '12/11/1995', 'Nam'	, 'HCM', N'Đại Học', N'Sức Khoẻ TH', N'Bác sĩ');
----
/*

Thac Sĩ
Tiến Sĩ
Giáo Sư
MSBS CHAR(15)			NOT NULL PRIMARY KEY,
TENBS NVARCHAR(100)		NOT NULL,
DIENTHOAI NVARCHAR(10)	NOT NULL,
NGAYSINH DATETIME		NOT NULL,
PHAI NCHAR(10)			NOT NULL,
DIACHI NVARCHAR(100)	NOT NULL,
TRINHDO NVARCHAR(50)	NOT NULL,
KHOA NVARCHAR(50)		NOT NULL,
CHUCVU NVARCHAR(50)		NULL
*/
GO
INSERT INTO  PHIEUHEN
VALUES 
('PH0001', 'NV002', 'BS001','KH0001' ,'21/11/2022',N'Hẹn khám sức khoẻ','21/12/2022','7h - 9h'),
('PH0002', 'NV003', 'BS003','KH0002' ,'21/11/2022',N'Hẹn tái Khám', '21/12/2022','7h - 9h'),
('PH0003', 'NV004', 'BS001','KH0003' ,'21/11/2022',N'Hẹn tái Khám','21/12/2022','7h - 9h'),
('PH0004', 'NV001', 'BS003','KH0004' ,'21/11/2022',N'Hẹn khám sức khoẻ', '21/12/2022','7h - 9h');
/*
MSPT CHAR(15)	NOT NULL PRIMARY KEY,
MANV CHAR(15)	NOT NULL,
MSBS CHAR(15)	NOT NULL,
MSKH CHAR(15)	NOT NULL,
NGAYLPT DATETIME NOT NULL,
LAKHIEM IKH NOT NULL
*/
SELECT *from PHIEUHEN

USE QLI_VETAU;

-- 1. Tài kho?n dang nh?p
CREATE TABLE TAIKHOAN (
    TenDangNhap VARCHAR(20) PRIMARY KEY,
    MatKhau VARCHAR(50) NOT NULL
);

-- 2. Thông tin khách hàng
CREATE TABLE KHACHHANG (
    TenDangNhap VARCHAR(20) PRIMARY KEY FOREIGN KEY REFERENCES TAIKHOAN(TenDangNhap),
    HoTen NVARCHAR(50) NOT NULL,
    SoDienThoai CHAR(10),
    Email VARCHAR(50)
);

-- 3. Ga tàu
CREATE TABLE GATAU (
    MaGa INT PRIMARY KEY IDENTITY(1,1),
    TenGa NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100)
);

-- 4. L?ch trình tàu gi?a hai ga
CREATE TABLE LICHTRINH (
    MaLichTrinh INT PRIMARY KEY IDENTITY(1,1),
    GaDi INT FOREIGN KEY REFERENCES GATAU(MaGa),
    GaDen INT FOREIGN KEY REFERENCES GATAU(MaGa),
    GioDi DATETIME NOT NULL,
    GioDen DATETIME NOT NULL
);

-- 5. Thông tin tàu
CREATE TABLE TAU (
    MaTau INT PRIMARY KEY IDENTITY(1,1),
    TenTau NVARCHAR(50) NOT NULL,
    SoToa INT NOT NULL
);

-- 6. Chuy?n di c? th?
CREATE TABLE CHUYENDI (
    MaChuyenDi INT PRIMARY KEY IDENTITY(1,1),
    MaLichTrinh INT FOREIGN KEY REFERENCES LICHTRINH(MaLichTrinh),
    MaTau INT FOREIGN KEY REFERENCES TAU(MaTau),
    GiaCoBan MONEY NOT NULL
);

-- 7. Vé tàu
CREATE TABLE VETAU (
    MaVe INT PRIMARY KEY IDENTITY(1,1),
    MaChuyenDi INT FOREIGN KEY REFERENCES CHUYENDI(MaChuyenDi),
    SoGhe VARCHAR(10) NOT NULL,
    GiaVe MONEY NOT NULL,
    DaDat BIT DEFAULT 0,
    KhachHang VARCHAR(20) FOREIGN KEY REFERENCES KHACHHANG(TenDangNhap)
);

-- 1. Insert tài kho?n dang nh?p
INSERT INTO TAIKHOAN (TenDangNhap, MatKhau)
VALUES 
('admin', 'admin123'), 
('customer1', 'password1'),
('customer2', 'password2'),
('customer3', 'password3'),
('customer4', 'password4');

-- 2. Insert thông tin khách hàng
INSERT INTO KHACHHANG (TenDangNhap, HoTen, SoDienThoai, Email)
VALUES 
('customer1', 'Nguyen Van A', '0912345678', 'nguyenvana@gmail.com'),
('customer2', 'Tran Thi B', '0912345679', 'tranthib@gmail.com'),
('customer3', 'Le Thi C', '0912345680', 'lethic@gmail.com'),
('customer4', 'Pham Minh D', '0912345681', 'phamminhd@gmail.com');

-- 3. Insert thông tin ga tàu
INSERT INTO GATAU (TenGa, DiaChi)
VALUES 
('Ga Ha Noi', 'Noi Bai, Hanoi'), 
('Ga Sai Gon', 'Ho Chi Minh City'),
('Ga Da Nang', 'Da Nang City'),
('Ga Hue', 'Thua Thien Hue'),
('Ga Nha Trang', 'Khanh Hoa');

-- 4. Insert l?ch trình tàu
INSERT INTO LICHTRINH (GaDi, GaDen, GioDi, GioDen)
VALUES 
(1, 2, '2025-04-10 08:00', '2025-04-10 14:00'),
(1, 3, '2025-04-11 09:00', '2025-04-11 13:30'),
(2, 4, '2025-04-12 10:00', '2025-04-12 14:00'),
(3, 5, '2025-04-13 11:00', '2025-04-13 15:00');

-- 5. Insert thông tin tàu
INSERT INTO TAU (TenTau, SoToa)
VALUES 
('Tau 1', 10),
('Tau 2', 12),
('Tau 3', 8),
('Tau 4', 15);

-- 6. Insert chuy?n di c? th?
INSERT INTO CHUYENDI (MaLichTrinh, MaTau, GiaCoBan)
VALUES 
(1, 1, 500000),
(1, 2, 600000),
(2, 3, 450000),
(2, 4, 700000),
(3, 1, 550000),
(4, 2, 650000);

-- 7. Insert vé tàu
INSERT INTO VETAU (MaChuyenDi, SoGhe, GiaVe, DaDat, KhachHang)
VALUES 
(1, 'A1', 500000, 0, 'customer1'),
(1, 'A2', 500000, 0, 'customer2'),
(1, 'B1', 500000, 0, 'customer3'),
(2, 'B2', 600000, 0, 'customer4'),
(2, 'B3', 600000, 0, 'customer1'),
(3, 'C1', 450000, 0, 'customer2'),
(3, 'C2', 450000, 0, 'customer3'),
(4, 'D1', 700000, 0, 'customer4'),
(4, 'D2', 700000, 0, 'customer1'),
(5, 'E1', 550000, 1, 'customer2'),
(6, 'F1', 650000, 0, 'customer3');

SELECT * FROM LICHTRINH

CREATE VIEW V_VETAUCHITIET AS
SELECT 
    VETAU.MaVe, 
    VETAU.SoGhe, 
    VETAU.GiaVe, 
    VETAU.DaDat, 
    VETAU.KhachHang,
    CHUYENDI.MaChuyenDi,
    LICHTRINH.GioDi, 
    LICHTRINH.GioDen,
    GADI.TenGa AS GaDi, 
    GADEN.TenGa AS GaDen,
    TAU.TenTau
FROM 
    VETAU, 
    CHUYENDI, 
    LICHTRINH, 
    GATAU GADI, 
    GATAU GADEN, 
    TAU
WHERE 
    VETAU.MaChuyenDi = CHUYENDI.MaChuyenDi AND
    CHUYENDI.MaLichTrinh = LICHTRINH.MaLichTrinh AND
    CHUYENDI.MaTau = TAU.MaTau AND
    LICHTRINH.GaDi = GADI.MaGa AND
    LICHTRINH.GaDen = GADEN.MaGa;

SELECT * FROM V_VETAUCHITIET




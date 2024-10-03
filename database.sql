CREATE DATABASE SANPHAM;
USE SANPHAM;

CREATE TABLE SANPHAM (
    MASP NVARCHAR(50) PRIMARY KEY,
    TENSP NVARCHAR(100),
    SL INT,
    DONGIA INT,
    XUATXU NVARCHAR(100),
    NGAY_HET_HAN DATETIME
);

INSERT INTO SANPHAM (MASP, TENSP, SL, DONGIA, XUATXU, NGAY_HET_HAN) VALUES 
('SP001', N'Bánh Pocky', 100, 25, N'Nhật Bản', '2025-12-31'),
('SP002', N'Mochi Đậu Xanh', 50, 30, N'Nhật Bản', '2025-11-30'),
('SP003', N'Snack Khoai Tây', 200, 20, N'Việt Nam', '2024-10-31'),
('SP004', N'Bánh Xèo', 150, 15, N'Việt Nam', '2025-01-15'),
('SP005', N'Kẹo Dẻo', 120, 10, N'Mỹ', '2025-06-30'),
('SP006', N'Bánh Quy Bơ', 80, 22, N'Hàn Quốc', '2025-03-15'),
('SP007', N'Hạt Dẻ Nướng', 60, 35, N'Trung Quốc', '2025-05-20'),
('SP008', N'Snack Rong Biển', 200, 18, N'Nhật Bản', '2025-09-01'),
('SP009', N'Bánh Gạo', 75, 28, N'Hàn Quốc', '2025-02-10'),
('SP010', N'Kẹo Mút', 90, 12, N'Việt Nam', '2024-12-01'),
('SP011', N'Kẹo Socola', 50, 15, N'Nhật Bản', '2023-09-15'),
('SP012', N'Bánh Bông Lan', 30, 20, N'Việt Nam', '2023-10-01');
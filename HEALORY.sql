create database Healory

CREATE TABLE Dangky (
    UserID INT IDENTITY(1,1) PRIMARY KEY, -- Khóa chính tự tăng
    Username NVARCHAR(50) NOT NULL UNIQUE, -- Tên đăng nhập duy nhất
    FullName NVARCHAR(100) NOT NULL, -- Họ và tên
    Email NVARCHAR(100) NOT NULL UNIQUE, -- Email duy nhất
    Password NVARCHAR(255) NOT NULL -- Mật khẩu
);

CREATE TABLE Thuoc (
    MaThuoc NVARCHAR(20) PRIMARY KEY,         -- Mã thuốc (khóa chính, duy nhất)
    TenThuoc NVARCHAR(100) NOT NULL,          -- Tên thuốc
    DonViTinh NVARCHAR(20),                   -- Đơn vị tính (hộp, vỉ, viên...)
    SoLuong INT DEFAULT 0,                    -- Số lượng tồn kho
    GiaNhap MONEY,                            -- Giá nhập (đơn vị VNĐ)
    GiaBan MONEY,                             -- Giá bán (đơn vị VNĐ)
    HanSuDung DATE,                           -- Hạn sử dụng
    NhaSanXuat NVARCHAR(100),                 -- Tên nhà sản xuất
    GhiChu NVARCHAR(255)                      -- Ghi chú thêm (nếu cần)
);


INSERT INTO Thuoc (MaThuoc, TenThuoc, DonViTinh, SoLuong, GiaNhap, GiaBan, HanSuDung, NhaSanXuat, GhiChu)
VALUES
('TH001', N'Paracetamol 500mg', 'Viên', 200, 500, 1000, '2026-12-31', N'Hapaco', N'Thuốc giảm đau, hạ sốt'),
('TH002', N'Amoxicillin 500mg', 'Viên', 150, 800, 1200, '2025-11-30', N'Mekophar', N'Kháng sinh phổ rộng'),
('TH003', N'Vitamin C 500mg', 'Viên', 300, 400, 700, '2026-08-15', N'DH Pharma', N'Tăng đề kháng'),
('TH004', N'Azithromycin 250mg', 'Viên', 100, 1200, 1800, '2026-03-01', N'Sanofi', N'Diệt khuẩn, viêm hô hấp'),
('TH005', N'Loperamide 2mg', 'Viên', 80, 300, 500, '2026-10-10', N'Triderm', N'Tiêu chảy cấp, mạn'),
('TH006', N'Omeprazol 20mg', 'Viên', 120, 600, 950, '2027-01-01', N'OPV', N'Truyền dịch, dạ dày'),
('TH007', N'Clorpheniramin 4mg', 'Viên', 250, 100, 300, '2025-09-15', N'Mekophar', N'Dị ứng, mẩn ngứa'),
('TH008', N'Cefuroxime 500mg', 'Viên', 70, 2000, 2500, '2026-06-30', N'GSK', N'Kháng sinh thế hệ 2'),
('TH009', N'Metformin 500mg', 'Viên', 130, 700, 1100, '2027-02-28', N'Mekophar', N'Tiểu đường tuýp 2'),
('TH010', N'Losartan 50mg', 'Viên', 140, 800, 1200, '2026-12-01', N'Savi', N'Tăng huyết áp'),
('TH011', N'Aspirin 81mg', 'Viên', 200, 300, 600, '2027-01-10', N'DH Pharma', N'Chống đông, phòng đột quỵ'),
('TH012', N'Rabeprazol 20mg', 'Viên', 100, 900, 1400, '2026-04-01', N'Miramed', N'Dạ dày, trào ngược'),
('TH013', N'Ibuprofen 400mg', 'Viên', 160, 700, 1200, '2026-08-20', N'Opv', N'Giảm đau, hạ sốt'),
('TH014', N'Cetirizine 10mg', 'Viên', 120, 500, 900, '2025-12-10', N'Domesco', N'Dị ứng, hắt hơi'),
('TH015', N'Levocetirizine 5mg', 'Viên', 90, 700, 1100, '2026-03-15', N'Sanofi', N'Dị ứng mãn tính'),
('TH016', N'Diclofenac 50mg', 'Viên', 80, 500, 1000, '2026-09-30', N'Mekophar', N'Viêm khớp, đau cơ'),
('TH017', N'Prednisolon 5mg', 'Viên', 150, 600, 950, '2026-06-01', N'Savi', N'Kháng viêm, dị ứng'),
('TH018', N'Nifedipin 10mg', 'Viên', 60, 400, 700, '2025-11-30', N'Triderm', N'Huyết áp cao'),
('TH019', N'Fluconazole 150mg', 'Viên', 70, 1200, 1700, '2026-10-01', N'GSK', N'Nấm âm đạo, da'),
('TH020', N'Ranitidin 150mg', 'Viên', 130, 500, 900, '2026-05-20', N'Domesco', N'Dạ dày, ợ chua'),
('TH021', N'Glucosamin 1500mg', 'Viên', 70, 2000, 2500, '2027-03-01', N'USA Pharma', N'Hỗ trợ xương khớp'),
('TH022', N'Spiramycin 3MIU', 'Viên', 100, 1000, 1500, '2026-12-10', N'Triderm', N'Kháng sinh'),
('TH023', N'Telfast 180mg', 'Viên', 80, 1300, 1900, '2026-08-08', N'Sanofi', N'Dị ứng thời tiết'),
('TH024', N'Smecta', 'Gói', 150, 600, 900, '2027-04-01', N'Ipsen', N'Tiêu chảy, tiêu hóa'),
('TH025', N'Hydrite', 'Gói', 200, 300, 500, '2026-12-15', N'UniLab', N'Bù nước, điện giải'),
('TH026', N'Oresol', 'Gói', 180, 200, 400, '2027-02-20', N'Savi', N'Mất nước, sốt cao'),
('TH027', N'Dextromethorphan 15mg', 'Viên', 160, 400, 700, '2026-11-11', N'Mekophar', N'Ho khan, cảm lạnh'),
('TH028', N'Terpin codein', 'Viên', 140, 800, 1200, '2027-01-05', N'DH Pharma', N'Ho có đờm'),
('TH029', N'Salbutamol 2mg', 'Viên', 70, 900, 1300, '2026-07-20', N'Sanofi', N'Suyễn, co thắt phế quản'),
('TH030', N'Gaviscon', 'Gói', 90, 1800, 2200, '2027-05-10', N'Reckitt', N'Truyền dịch dạ dày'),
('TH031', N'Skinal', 'Tuýp', 50, 1500, 2000, '2026-08-08', N'Triderm', N'Nấm ngoài da'),
('TH032', N'Medrol 16mg', 'Viên', 70, 1000, 1500, '2026-10-10', N'Pfizer', N'Kháng viêm mạnh'),
('TH033', N'Symbicort', 'Ống hít', 30, 5000, 6500, '2027-01-01', N'AstraZeneca', N'COPD, hen suyễn'),
('TH034', N'Panadol Extra', 'Viên', 100, 1000, 1500, '2026-09-09', N'GSK', N'Giảm đau mạnh hơn'),
('TH035', N'Tylenol', 'Viên', 90, 1200, 1700, '2027-01-01', N'Johnson & Johnson', N'Giảm đau, sốt'),
('TH036', N'Strepsils', 'Viên ngậm', 150, 300, 600, '2026-12-31', N'Reckitt', N'Viêm họng, kháng khuẩn'),
('TH037', N'Sorbitol', 'Gói', 60, 600, 900, '2026-05-05', N'DH Pharma', N'Táo bón, hỗ trợ tiêu hóa'),
('TH038', N'Mucomyst 200mg', 'Gói', 50, 1000, 1500, '2026-04-01', N'Boston', N'Tan đờm'),
('TH039', N'Kremil-S', 'Viên', 100, 500, 800, '2026-07-07', N'United Pharma', N'Dạ dày, khó tiêu'),
('TH040', N'Zinc Gluconate', 'Viên', 110, 400, 600, '2026-06-06', N'Triderm', N'Bổ sung kẽm, đề kháng'),
('TH041', N'Calcium Corbiere', 'Ống uống', 90, 700, 1100, '2026-08-08', N'Sanofi', N'Bổ sung canxi'),
('TH042', N'S-omega 3', 'Viên', 80, 1500, 2000, '2027-01-01', N'Vinut', N'Tăng trí nhớ'),
('TH043', N'Bepanthen', 'Tuýp', 60, 1200, 1600, '2026-12-10', N'Bayer', N'Trái gió trở trời'),
('TH044', N'Sodicloride 0.9%', 'Chai', 100, 500, 800, '2027-03-03', N'Triderm', N'Nước muối sinh lý'),
('TH045', N'Nurofen', 'Viên', 60, 1000, 1600, '2026-09-30', N'Reckitt', N'Hạ sốt, đau đầu'),
('TH046', N'Men tiêu hóa BIOACIMIN', 'Gói', 100, 700, 1000, '2026-12-15', N'Nam Dược', N'Tiêu hóa cho trẻ'),
('TH047', N'Berberin 10mg', 'Viên', 150, 300, 500, '2026-11-11', N'Mekophar', N'Tiêu chảy, lỵ trực khuẩn'),
('TH048', N'Bromhexin 8mg', 'Viên', 90, 400, 700, '2026-08-01', N'Savi', N'Tan đờm, viêm phế quản'),
('TH049', N'Kem nghệ Thorakao', 'Tuýp', 50, 1000, 1300, '2026-10-10', N'Thorakao', N'Mụn, sẹo'),
('TH050', N'Sorbitol + Vitamin C', 'Gói', 80, 600, 900, '2026-07-07', N'Triderm', N'Thải độc, làm đẹp');

CREATE TABLE HoaDonBanThuoc (
    MaHD NVARCHAR(20) NOT NULL,               -- Mã hóa đơn
    NgayBan DATE NOT NULL,                    -- Ngày bán
    Tennhanvien NVARCHAR(20) NOT NULL,        -- Tên nhân viên bán
    TenKhachHang NVARCHAR(100),               -- Tên khách hàng
    MaThuoc NVARCHAR(20) NOT NULL,            -- Mã thuốc
    TenThuoc NVARCHAR(100),                   -- Tên thuốc
    SoLuong INT NOT NULL,                     -- Số lượng thuốc bán
    DonGia MONEY NOT NULL,                    -- Đơn giá bán
    ThanhTien AS (SoLuong * DonGia) PERSISTED,-- Thành tiền (tự tính)
    PRIMARY KEY (MaHD, MaThuoc)               -- Khóa chính kép
);

CREATE TABLE NhanVien (
    MaNV NVARCHAR(20) PRIMARY KEY,            -- Mã nhân viên (khóa chính)
    HoTen NVARCHAR(100) NOT NULL,             -- Họ và tên nhân viên
    GioiTinh NVARCHAR(10),                    -- Giới tính (Nam/Nữ)
    NgaySinh DATE,                            -- Ngày sinh
    DiaChi NVARCHAR(255),                     -- Địa chỉ
    DienThoai NVARCHAR(15),                   -- Số điện thoại
    Email NVARCHAR(100),                      -- Email
    ChucVu NVARCHAR(50),                      -- Chức vụ (Nhân viên bán hàng, quản lý, ...)
    NgayVaoLam DATE,                          -- Ngày bắt đầu làm việc
    Luong DECIMAL(18,2)                       -- Lương (đơn vị VNĐ)
);

INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, ChucVu, NgayVaoLam, Luong)
VALUES
(N'NV001', N'Nguyễn Văn A', N'Nam', '1985-03-15', N'123 Đường Lê Lợi, Hà Nội', '0987654321', 'nguyenvana@example.com', N'Nhân viên bán hàng', '2010-05-01', 8000000.00),
(N'NV002', N'Trần Thị B', N'Nữ', '1990-07-20', N'456 Đường Trần Phú, Hà Nội', '0912345678', 'tranthib@example.com', N'Quản lý kho', '2012-08-15', 10000000.00),
(N'NV003', N'Lê Văn C', N'Nam', '1988-12-05', N'789 Đường Nguyễn Huệ, Hà Nội', '0978123456', 'levanc@example.com', N'Nhân viên bán hàng', '2015-03-10', 7500000.00);

CREATE TABLE CaLam (
    MaCa NVARCHAR(20) PRIMARY KEY,      -- Shift ID
    TenCa NVARCHAR(50) NOT NULL,         -- Shift Name (Morning, Afternoon, ...)
    GioBatDau TIME NOT NULL,              -- Start Time
    GioKetThuc TIME NOT NULL,             -- End Time
    MaNV NVARCHAR(20) NOT NULL,           -- Employee ID for this shift
    NgayLam DATE NOT NULL,                 -- Work Date
    GhiChu NVARCHAR(255) NULL,            -- Additional Notes
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

INSERT INTO CaLam (MaCa, TenCa, GioBatDau, GioKetThuc, MaNV, NgayLam, GhiChu) VALUES
('CA01', N'Ca sáng', '07:00', '11:00', 'NV001', '2025-05-22', N'Ca làm buổi sáng'),
('CA02', N'Ca chiều', '13:00', '17:00', 'NV002', '2025-05-22', N'Ca làm buổi chiều'),
('CA03', N'Ca tối', '18:00', '22:00', 'NV003', '2025-05-22', N'Ca làm buổi tối');

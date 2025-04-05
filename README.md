# QUẢN LÍ VÉ TÀU


Giải thích database:

🧩 1. Bảng TAIKHOAN
Vai trò: Chứa thông tin đăng nhập (tài khoản và mật khẩu).

Cột chính: TenDangNhap – Khóa chính.

Liên kết:

Liên kết 1-1 với bảng KHACHHANG, nghĩa là mỗi khách hàng có đúng 1 tài khoản để đăng nhập.

👤 2. Bảng KHACHHANG
Vai trò: Chứa thông tin cá nhân của người dùng mua vé.

Cột chính: TenDangNhap – Khóa chính và là khóa ngoại đến TAIKHOAN.

Liên kết:

1-1 với TAIKHOAN.

1-n với VETAU: 1 khách hàng có thể đặt nhiều vé.

🏢 3. Bảng GATAU
Vai trò: Lưu danh sách các ga tàu, địa chỉ.

Cột chính: MaGa.

Liên kết:

Dùng trong LICHTRINH để xác định ga đi (GaDi) và ga đến (GaDen).

📅 4. Bảng LICHTRINH
Vai trò: Xác định một lịch trình giữa hai ga, có giờ đi – giờ đến.

Cột chính: MaLichTrinh.

Liên kết:

GaDi và GaDen là khóa ngoại đến GATAU.

Mỗi LICHTRINH có thể gắn với nhiều chuyến (CHUYENDI).

🚆 5. Bảng TAU
Vai trò: Danh sách tàu chạy, tên tàu, số toa.

Cột chính: MaTau.

Liên kết:

Liên kết với CHUYENDI: mỗi chuyến sẽ dùng 1 tàu.

🛤️ 6. Bảng CHUYENDI
Vai trò: Là chuyến tàu cụ thể chạy theo 1 lịch trình với 1 con tàu.

Cột chính: MaChuyenDi.

Liên kết:

MaLichTrinh → LICHTRINH,

MaTau → TAU.

Một CHUYENDI có nhiều vé (VETAU).

🎫 7. Bảng VETAU
Vai trò: Thông tin từng vé: ghế, giá vé, đã đặt hay chưa, của khách nào.

Cột chính: MaVe.

Liên kết:

MaChuyenDi → CHUYENDI.

KhachHang → KHACHHANG.

Các chức năng cần làm:

🔐 1. Quản lý Đăng nhập (Login)
Mục đích: Đảm bảo chỉ người quản lý mới được truy cập hệ thống.

Thao tác chính:

Giao diện nhập Tên đăng nhập + Mật khẩu.

Kiểm tra thông tin với bảng TAIKHOAN.

Nếu đúng → chuyển đến trang Dashboard quản lý chính.

👥 2. Quản lý Khách hàng (KHACHHANG)
Hiển thị danh sách khách hàng.

Thêm / sửa / xóa thông tin khách hàng.

Tìm kiếm khách hàng theo tên / số điện thoại / email.

Liên kết với vé đã đặt từ bảng VETAU.

🚉 3. Quản lý Ga tàu (GATAU)
Hiển thị danh sách các ga tàu.

Thêm mới, sửa tên / địa chỉ, hoặc xóa ga tàu.

Liên kết với LICHTRINH để xác định ga đi/đến.

🚆 4. Quản lý Tàu (TAU)
Danh sách các tàu (tên, số toa).

Thêm / sửa / xóa tàu.

Gán tàu vào các CHUYENDI.

📅 5. Quản lý Lịch trình (LICHTRINH)
Danh sách các lịch trình (ga đi → ga đến, giờ đi → giờ đến).

Thêm / sửa / xóa lịch trình.

Liên kết với CHUYENDI để tạo chuyến đi cụ thể.

🧭 6. Quản lý Chuyến đi (CHUYENDI)
Danh sách chuyến đi (dựa trên lịch trình và tàu).

Gán tàu cụ thể vào lịch trình.

Đặt giá cơ bản cho từng chuyến đi.

Thêm / sửa / xóa chuyến đi.

🎫 7. Quản lý Vé tàu (VETAU)
Hiển thị danh sách vé theo chuyến đi.

Thêm / sửa / xóa vé.

Cập nhật trạng thái đã đặt hay chưa (DaDat).

Tra cứu vé theo khách hàng, chuyến, ghế, thời gian.

📊 8. Thống kê và Doanh thu
Số lượng vé đã bán.

Tổng doanh thu từ vé (cộng giá các vé DaDat = 1).

Lọc theo khoảng thời gian, chuyến đi, tàu.

Có thể vẽ biểu đồ (tùy nền tảng giao diện bạn dùng: C#, Python, JavaFX...).

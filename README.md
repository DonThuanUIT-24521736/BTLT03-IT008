# Simple Paint - Ứng dụng Vẽ hình Đơn giản

Đây là một ứng dụng vẽ cơ bản được xây dựng bằng C# và Windows Forms. Project này được tạo ra như một bài tập cho môn Lập trình Trực quan, minh họa các khái niệm về xử lý sự kiện, đồ họa GDI+ và thiết kế giao diện người dùng.



## ✨ Tính năng (Features)

* **Vẽ nhiều loại hình dạng:** Người dùng có thể chọn vẽ các đối tượng sau:
    * Đường thẳng (Line)
    * Hình chữ nhật (Rectangle)
    * Elip/Hình tròn (Circle/Ellipse)
    * Văn bản (Text)
    * *Chức năng vẽ Tam giác (Triangle) đang được phát triển.*

* **Tùy chỉnh thông số linh hoạt:**
    * 🎨 **Chọn màu:** Mở hộp thoại `ColorDialog` để chọn màu vẽ bất kỳ.
    * 📏 **Độ dày nét vẽ / Kích thước chữ:** Dễ dàng điều chỉnh bằng `NumericUpDown`.
    * ✍️ **Định dạng văn bản:** Hỗ trợ **In đậm**, *In nghiêng*, và _Gạch chân_ (có thể kết hợp nhiều kiểu).

* **Giao diện thông minh:**
    * Giao diện người dùng sẽ tự động ẩn/hiện các tùy chọn liên quan đến văn bản chỉ khi công cụ "Text" được chọn.
    * Sử dụng `ComboBox` để dễ dàng mở rộng thêm các hình vẽ mới trong tương lai.

* **Các công cụ tiện ích:**
    * **Xóa màn hình:** Nút bấm cho phép xóa toàn bộ bản vẽ để bắt đầu lại.
    * **Vẽ "live":** Hiển thị hình ảnh xem trước trực tiếp khi người dùng kéo chuột.
    * **Bản vẽ vĩnh viễn:** Các hình vẽ được lưu lại trên một `Bitmap` trong bộ nhớ, không bị mất khi thay đổi kích thước cửa sổ.

## 🛠️ Công nghệ sử dụng

* **Ngôn ngữ:** C#
* **Nền tảng:** .NET Framework
* **Giao diện:** Windows Forms (WinForms)
* **Đồ họa:** GDI+
* **Môi trường phát triển:** Visual Studio

## 🚀 Hướng dẫn cài đặt và chạy

1.  Clone repository này về máy của bạn:
    ```bash
    git clone [URL-repository-cua-ban]
    ```
2.  Mở file solution (`.sln`) bằng Visual Studio.
3.  Nhấn `F5` hoặc nút "Start" để biên dịch và chạy ứng dụng.

## 💡 Hướng phát triển trong tương lai

* [ ] Hoàn thiện chức năng vẽ Tam giác.
* [ ] Thêm công cụ vẽ tự do (bút vẽ).
* [ ] Thêm chức năng tô màu cho các hình khép kín (chữ nhật, elip).
* [ ] Thêm công cụ tẩy (Eraser).
* [ ] Chức năng Lưu bản vẽ ra file ảnh (PNG, JPG).
* [ ] Thêm các hình vẽ mới (đa giác, ngôi sao...).

---

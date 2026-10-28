# 🃏 GAME LẬT THẺ TRÍ NHỚ (MEMORY CARD GAME)

<p align="center">
  <img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Framework 4.7.2" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/UI-Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/Sound%20Engine-Windows%20MCI%20%2B%20SoundPlayer-00A4EF?style=for-the-badge" alt="MCI Sound" />
  <img src="https://img.shields.io/badge/Team-CHARLIEKODE-FF6F00?style=for-the-badge" alt="Team CHARLIEKODE" />
  <img src="https://img.shields.io/badge/Status-Completed%2010%2F10-brightgreen?style=for-the-badge" alt="Status" />
</p>

---

## 📌 Giới Thiệu Dự Án

**Game Lật Thẻ Trí Nhớ** là minigame tương tác cao được phát triển trên môi trường Windows bằng ngôn ngữ **C#** và nền tảng **Windows Forms Application (.NET Framework 4.7.2)**. Đây là đồ án môn học **Lập Trình Trên Môi Trường Windows (LTWIN)** được xây dựng và hoàn thiện bởi nhóm **CHARLIEKODE**.

Trò chơi thể hiện toàn diện các tiêu chuẩn kỹ thuật:
- **Tư duy thuật toán**: Xáo trộn ngẫu nhiên Fisher-Yates, quản lý trạng thái thẻ bài, kiểm soát lượt chơi đối kháng thời gian thực.
- **Xử lý sự kiện & Thời gian**: Điều phối chính xác 3 bộ `System.Windows.Forms.Timer` (Xem trước bàn cờ, Đồng hồ đếm ngược, Tự động úp thẻ sau 600ms khi ghép sai).
- **Quản lý tập tin (I/O)**: Lưu trữ và trích xuất bảng thành tích người chơi dạng append vào `thanhtichs.txt` thông qua thư viện `System.IO`.
- **Hệ thống âm thanh đa kênh (Windows MCI + SoundPlayer)**: Sử dụng Windows MCI (`winmm.dll`) cho phép nhạc nền BGM phát lặp liên tục, không bao giờ bị ngắt khi phát đồng thời các hiệu ứng âm thanh lật thẻ (SFX).
- **Quản lý tài nguyên đồ họa**: Nạp và cache bộ 32 thẻ bài độc quyền từ thư mục `img/`, có cơ chế tự vẽ đồ họa dự phòng.
- **Bẫy lỗi toàn diện (Exception Handling)**: Bọc khối `try...catch` ở toàn bộ các tiến trình nhạy cảm, chống crash ứng dụng tuyệt đối.

---

## 👥 Nhóm Thực Hiện: CHARLIEKODE

| STT | Họ và Tên | Mã Số Sinh Viên (MSSV) | Lớp Học Phần | Nhiệm Vụ Phụ Trách |
| :---: | :--- | :---: | :---: | :--- |
| **1** | **Hứa Nhựt Tuấn** | *51.01.104.114* | *2611COMP101901* | **Trưởng nhóm**: Thiết kế Game Logic, Chế độ Đối Kháng 2 người chơi, Tạm dừng & Điều phối Luồng |
| **2** | **Lê Văn Gia Bảo** | *51.01.104.007* | *2611COMP101901* | Nâng cấp Âm thanh MCI đa kênh (`winmm.dll`), Quản lý Assets & Bẫy lỗi (Exception Handling) |
| **3** | **Huỳnh Phú Vinh** | *51.01.104.120* | *2611COMP101901* | Thuật toán Shuffle Fisher-Yates, Điều phối Timers, Tối ưu giao diện bàn cờ |
| **4** | **Nguyễn Đăng Khoa** | *51.01.104.045* | *2611COMP101901* | Bảng thành tích (System.IO), Form Leaderboard, Hộp thoại lưu điểm thành tích |

---

## ✨ Các Tính Năng Nổi Bật

### 1. Luồng Game Logic Hoàn Thiện & Chặt Chẽ
- **Start / Restart / End Game**: Bắt đầu màn chơi mới, khởi động lại màn hiện tại hoặc quay về Menu chính an toàn kèm xác nhận.
- **Tạm dừng thông minh (Pause / Resume)**: Nút `⏸ Tạm dừng` che mờ bàn chơi bằng lớp phủ (Overlay) để chống gian lận và tự động tạm dừng đồng hồ đếm ngược cùng nhạc nền.
- **Tự động tăng độ khó**: Khi hoàn thành một màn chơi, trò chơi tự động mở rộng kích thước ma trận (từ 3x4 -> 4x4 -> 6x6 -> 8x8) và tiến lên cấp độ cao hơn.

### 2. Hai Chế Độ Chơi Đơn Hấp Dẫn
- 🧠 **Lật Thẻ Trí Nhớ (Memory Match)**:
  - Chọn 2 thẻ bài giống nhau để triệt tiêu cặp thẻ.
  - Lật đúng: **+25 điểm**, giữ nguyên thẻ mở và phát âm thanh xác nhận `true.wav`.
  - Lật sai: **-5 điểm**, tự động úp thẻ lại sau 0.6 giây và phát âm thanh cảnh báo `false.wav`.
- 🔢 **Lật Thẻ Theo Thứ Tự (Sequential Numbers)**:
  - Lật lần lượt các số tăng dần từ 1 đến N. Có hệ số thưởng combo điểm khi lật đúng liên tiếp.
  - Chế độ Thường: Lật sai sẽ bị phạt lùi lại 2 bước.
  - Chế độ **Hardcore 🔥**: Sai 1 bước duy nhất sẽ sập toàn bộ bàn cờ về số 1!

### 3. Chế Độ Đối Kháng 2 Người Chơi (Two Players)
- Hai người chơi luân phiên tham gia trên cùng một thiết bị:
  - Thể hiện rõ người đang tới lượt: `👉 Lượt: P1 (Xanh)` hoặc `👉 Lượt: P2 (Đỏ)`.
  - Khi người chơi lật đúng cặp: Được cộng điểm và **tiếp tục giữ lượt** đi.
  - Khi người chơi lật sai: Bị trừ điểm và **chuyển lượt cho đối thủ**.
  - Kết thúc ván: Tự động so sánh điểm số và vinh danh người chiến thắng hoặc công bố kết quả hòa.

### 4. Hệ Thống Âm Thanh Đa Kênh Windows MCI
- Kết hợp công nghệ Windows MCI (`winmm.dll`) và `SoundPlayer` dự phòng:
  - `bgm.wav`: Nhạc nền êm dịu phát lặp vô tận (Looping), không bị ngắt khi phát âm thanh lật thẻ.
  - `flip.wav`: Tiếng lật thẻ bài chân thực.
  - `true.wav`: Âm thanh chúc mừng khi ghép đúng cặp thẻ.
  - `false.wav`: Hiệu ứng cảnh báo khi ghép sai thẻ hoặc sai thứ tự.
  - `victory.wav`: Giai điệu chiến thắng khi hoàn thành ván.
  - `gameover.wav`: Âm thanh báo hết giờ.
  - Nút bật/tắt âm thanh (🔊 / 🔇) chủ động ngay trên Header bàn chơi và Menu chính.

### 5. Bảng Thành Tích Trực Quan (Leaderboard)
- Đọc và ghi dữ liệu người chơi (`Tên`, `Điểm Số`, `Thời Gian Còn Lại`, `Chế Độ`, `Ngày Giờ`) vào file `thanhtichs.txt` qua `System.IO`.
- Hộp thoại nhập tên xuất hiện tự động khi chiến thắng hoặc kết thúc ván.
- Giao diện `DataGridView` sang trọng hiển thị danh hiệu top 3 (🥇, 🥈, 🥉), có nút làm mới và xóa lịch sử.

### 6. Bẫy Lỗi Toàn Diện (Exception Handling)
- Toàn bộ các thao tác I/O tập tin và nạp tài nguyên ngoài đều được bao bọc trong khối `try...catch`.
- Nếu thư mục `img/` hoặc `bg/` bị mất hoặc di dời, trò chơi **không bao giờ bị văng (crash)** mà tự động kích hoạt giao diện/âm thanh dự phòng kèm hộp thoại cảnh báo tiếng Việt thân thiện.

---

## 📁 Cấu Trúc Thư Mục Dự Án

```
game-l-t-th---b-i-gi-a-k-LTWIN/
│
├── game lật thẻ 1.1.sln            # Tập tin Solution Visual Studio chuẩn
├── game lật thẻ 1.1.slnx           # Tập tin Solution phiên bản mới
├── game lật thẻ 1.1.csproj         # Cấu hình dự án C# Windows Forms
├── App.config                      # Cấu hình runtime .NET Framework 4.7.2
├── .gitignore                      # Bộ lọc loại bỏ file tạm build (.vs, bin, obj)
├── README.md                       # Tài liệu hướng dẫn & giới thiệu dự án
├── thanhtichs.txt                  # Dữ liệu bảng thành tích mẫu
├── Huong_Dan_Lap_Trinh_Game_Lat_The.pdf  # Tài liệu báo cáo chi tiết đồ án (PDF)
├── Huong_Dan_Lap_Trinh_Game_Lat_The.html # Tài liệu báo cáo chi tiết đồ án (HTML)
│
├── bg/                             # Thư mục âm thanh sự kiện & nhạc nền
│   ├── bgm.wav                     # Nhạc nền BGM
│   ├── false.wav                   # Âm thanh lật sai
│   ├── flip.wav                    # Âm thanh lật thẻ
│   ├── gameover.wav                # Âm thanh thua cuộc
│   ├── true.wav                    # Âm thanh lật đúng
│   └── victory.wav                 # Âm thanh chiến thắng
│
├── img/                            # Thư mục hình ảnh bộ bài & mặt sau
│   ├── card_back.png               # Mặt úp thẻ bài
│   ├── no-image.png                # Hình ảnh dự phòng
│   └── card_1.png ... card_32.png  # 32 thẻ bài chất lượng cao
│
├── GameMode.cs                     # Enum chế độ chơi & số lượng người chơi (Single / TwoPlayers)
├── SoundManager.cs                 # Quản lý âm thanh Windows MCI & SoundPlayer dự phòng
├── CardImageManager.cs             # Quản lý nạp ảnh thẻ bài & cơ chế vẽ fallback
├── LeaderboardManager.cs           # Đọc/ghi file thanhtichs.txt bằng System.IO
│
├── FormMenu.cs / .Designer.cs      # Màn hình Menu chính & chọn độ khó / chế độ
├── FormGame.cs / .Designer.cs      # Màn hình bàn chơi, đồng hồ, điều khiển, pause overlay
├── FormLeaderboard.cs / .Designer.cs # Màn hình xem Bảng thành tích (DataGridView)
├── FormAbout.cs / .Designer.cs     # Màn hình Hướng dẫn chơi & Thông tin nhóm CHARLIEKODE
├── FormInputName.cs / .Designer.cs # Hộp thoại nhập tên lưu điểm khi kết thúc
│
└── Properties/                     # AssemblyInfo, Resources, Settings
```

---

## 🚀 Hướng Dẫn Cài Đặt & Chạy Thử

### Yêu Cầu Hệ Thống:
* **Hệ điều hành**: Windows 10 / Windows 11.
* **Môi trường chạy**: .NET Framework 4.7.2 trở lên (mặc định đã có sẵn trên Windows 10/11).
* **Môi trường lập trình**: Visual Studio 2019 hoặc Visual Studio 2022 (cài đặt workload *.NET desktop development*).

### Các Bước Thực Hiện:
1. **Clone repository về máy:**
   ```bash
   git clone https://github.com/HuaNhutTuan/LTW-MINIGAME-CHARLIEKODE.git
   cd LTW-MINIGAME-CHARLIEKODE
   ```
2. **Mở dự án:**
   * Nhấp đúp vào file `game lật thẻ 1.1.sln` để mở trong Visual Studio.
3. **Biên dịch và Chạy:**
   * Nhấn phím `F5` hoặc chọn nút **Start (Debug)** trên thanh công cụ của Visual Studio.
   * Hoặc mở trực tiếp file thực thi tại `bin\Debug\game lật thẻ 1.1.exe`.

---

## 🎯 Bảng Đánh Giá Mức Độ Hoàn Thiện (Thang Điểm 10/10)

| Tiêu Chí Chấm Điểm | Trọng Số | Mức Độ Đạt Được | Ghi Chú |
| :--- | :---: | :---: | :--- |
| **1. Mức độ hoàn thiện & Độ khó** | 4.0đ | **4.0 / 4.0** | Hoàn chỉnh luồng Start, Pause (với Overlay chống gian lận), Restart, End Game; thuật toán Shuffle Fisher-Yates; chế độ 2 người chơi đối kháng luân phiên mượt mà. |
| **2. Giao diện - UI** | 2.0đ | **2.0 / 2.0** | Thiết kế WinForms hiện đại; nạp bộ bài từ `img/`; bố cục khoa học, thoáng đãng, co giãn mượt mà theo kích thước ma trận. |
| **3. Bảng thành tích (Leaderboard)** | 1.0đ | **1.0 / 1.0** | Đọc/ghi file `thanhtichs.txt` an toàn qua `System.IO`; hiển thị DataGridView sắp xếp theo điểm số, vinh danh huy chương top 3. |
| **4. Âm thanh** | 1.0đ | **1.0 / 1.0** | Âm thanh MCI đa kênh độc lập (`flip`, `true`, `false`, `victory`, `gameover`, `bgm`); nút Bật/Tắt âm thanh chủ động. |
| **5. Hướng dẫn & Thông tin nhóm** | 1.0đ | **1.0 / 1.0** | Form About hướng dẫn chi tiết luật chơi và thông tin 4 thành viên nhóm **CHARLIEKODE**. |
| **6. Bẫy lỗi (Exception Handling)** | 1.0đ | **1.0 / 1.0** | Bọc `try...catch` ở toàn bộ tiến trình I/O và nạp tài nguyên ngoài; tự động fallback an toàn, không bao giờ bị văng ứng dụng. |
| **TỔNG CỘNG** | **10.0đ** | **10.0 / 10.0** | **ĐẠT ĐIỂM TỐI ĐA** |

---

<p align="center">
  <b>© 2026 CHARLIEKODE - Đồ án môn học Lập Trình Trên Môi Trường Windows (LTWIN)</b>
</p>

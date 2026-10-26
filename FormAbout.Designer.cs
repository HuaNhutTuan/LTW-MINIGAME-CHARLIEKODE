namespace game_lật_thẻ_1._1
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabRules = new System.Windows.Forms.TabPage();
            this.txtRules = new System.Windows.Forms.RichTextBox();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.txtTeam = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBanner.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.tabRules.SuspendLayout();
            this.tabTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlBanner.Controls.Add(this.lblHeaderSub);
            this.pnlBanner.Controls.Add(this.lblHeaderTitle);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(640, 85);
            this.pnlBanner.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(640, 35);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "🃏 MINI GAME LẬT THẺ TRÍ NHỚ (MEMORY CARD)";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(0, 49);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(640, 22);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Đồ Án Lập Trình Môi Trường Windows (LTWIN) - C# WinForms";
            this.lblHeaderSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabContent
            // 
            this.tabContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContent.Controls.Add(this.tabRules);
            this.tabContent.Controls.Add(this.tabTeam);
            this.tabContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tabContent.Location = new System.Drawing.Point(20, 100);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(600, 360);
            this.tabContent.TabIndex = 1;
            // 
            // tabRules
            // 
            this.tabRules.Controls.Add(this.txtRules);
            this.tabRules.Location = new System.Drawing.Point(4, 26);
            this.tabRules.Name = "tabRules";
            this.tabRules.Padding = new System.Windows.Forms.Padding(10);
            this.tabRules.Size = new System.Drawing.Size(592, 330);
            this.tabRules.TabIndex = 0;
            this.tabRules.Text = "📖 Hướng Dẫn & Luật Chơi";
            this.tabRules.UseVisualStyleBackColor = true;
            // 
            // txtRules
            // 
            this.txtRules.BackColor = System.Drawing.Color.White;
            this.txtRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRules.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRules.Location = new System.Drawing.Point(10, 10);
            this.txtRules.Name = "txtRules";
            this.txtRules.ReadOnly = true;
            this.txtRules.Size = new System.Drawing.Size(572, 310);
            this.txtRules.TabIndex = 0;
            this.txtRules.Text = "1. MỤC TIÊU TRÒ CHƠI\n" +
                "Lật mở toàn bộ các thẻ bài trên bàn chơi trước khi đồng hồ đếm ngược về 0.\n\n" +
                "2. CÁC CHẾ ĐỘ CHƠI\n" +
                "• Lật Thẻ Trí Nhớ (Memory Match):\n" +
                "   - Lật mở lần lượt 2 thẻ bài. Nếu 2 thẻ giống nhau: thẻ giữ nguyên và được +25 điểm.\n" +
                "   - Nếu 2 thẻ khác nhau: thẻ sẽ tự động úp lại sau 0.6 giây và bị trừ 5 điểm.\n" +
                "• Lật Thẻ Theo Thứ Tự (Sequential Order):\n" +
                "   - Cần lật các thẻ số theo thứ tự tăng dần từ 1 đến N.\n" +
                "   - Lật đúng liên tiếp sẽ được cộng thêm điểm combo thưởng.\n" +
                "   - Chế độ Thường: Lật sai sẽ bị phạt lùi lại 2 bước.\n" +
                "   - Chế độ Hardcore: Lật sai 1 bước sẽ sập toàn bộ bàn cờ về số 1!\n" +
                "• Chế độ Đối Kháng 2 Người Chơi:\n" +
                "   - Hai người chơi lần lượt lật thẻ. Ai ghép đúng cặp sẽ được ghi điểm và được đi tiếp.\n" +
                "   - Người ghép sai sẽ chuyển lượt cho đối thủ. Kết thúc ván, người có điểm cao hơn sẽ thắng.\n\n" +
                "3. TÍNH NĂNG ĐIỀU KHIỂN\n" +
                "• ⏸ Tạm dừng (Pause): Dừng đồng hồ đếm ngược và che bàn cờ khi bận.\n" +
                "• 🔄 Chơi lại (Restart): Khởi động lại màn chơi bất cứ lúc nào.\n" +
                "• 🔊 Bật/Tắt Âm thanh: Điều khiển âm thanh nền và hiệu ứng lật thẻ.\n" +
                "• 🏆 Bảng thành tích: Lưu tên, điểm và thời gian của bạn vào hệ thống.";
            // 
            // tabTeam
            // 
            this.tabTeam.Controls.Add(this.txtTeam);
            this.tabTeam.Location = new System.Drawing.Point(4, 26);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(10);
            this.tabTeam.Size = new System.Drawing.Size(592, 330);
            this.tabTeam.TabIndex = 1;
            this.tabTeam.Text = "👥 Thông Tin Nhóm Thực Hiện";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // txtTeam
            // 
            this.txtTeam.BackColor = System.Drawing.Color.White;
            this.txtTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTeam.Location = new System.Drawing.Point(10, 10);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.ReadOnly = true;
            this.txtTeam.Size = new System.Drawing.Size(572, 310);
            this.txtTeam.TabIndex = 0;
            this.txtTeam.Text = "ĐỒ ÁN PHÁT TRIỂN MINIGAME TRÊN MÔI TRƯỜNG WINDOWS\n" +
                "Môn học: Lập Trình Trên Môi Trường Windows (LTWIN)\n" +
                "Đề tài: MiniGame Lật Thẻ Trí Nhớ (Memory Card Game)\n" +
                "Nhóm thực hiện: CHARLIEKODE\n\n" +
                "═══════════════════════════════════════════════════════════════\n" +
                "THÔNG TIN SINH VIÊN THỰC HIỆN:\n" +
                "═══════════════════════════════════════════════════════════════\n\n" +
                "1. Sinh viên 1: [Họ và Tên Sinh Viên 1]\n" +
                "   • Mã số sinh viên: [MSSV 1]\n" +
                "   • Lớp: [Lớp học phần]\n" +
                "   • Nhiệm vụ: Xây dựng Game Logic, Thuật toán Shuffle, Timer, UI Game\n\n" +
                "2. Sinh viên 2: [Họ và Tên Sinh Viên 2]\n" +
                "   • Mã số sinh viên: [MSSV 2]\n" +
                "   • Lớp: [Lớp học phần]\n" +
                "   • Nhiệm vụ: Bảng thành tích (System.IO), Xử lý Âm thanh & Hình ảnh, Exception Handling\n\n" +
                "═══════════════════════════════════════════════════════════════\n" +
                "Công nghệ sử dụng:\n" +
                "• Ngôn ngữ: C# (.NET Framework 4.7.2)\n" +
                "• Giao diện: Windows Forms Application (Tự thiết kế thủ công)\n" +
                "• Quản lý tệp: System.IO (Đọc/ghi thanhtichs.txt dạng append)\n" +
                "• Âm thanh: System.Media.SoundPlayer (.wav)\n" +
                "• Bẫy lỗi: try...catch toàn diện ở tất cả tiến trình nhạy cảm.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(246)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(500, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đã Hiểu";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(640, 525);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabContent);
            this.Controls.Add(this.pnlBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hướng Dẫn & Thông Tin Nhóm Thực Hiện";
            this.pnlBanner.ResumeLayout(false);
            this.tabContent.ResumeLayout(false);
            this.tabRules.ResumeLayout(false);
            this.tabTeam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.TabPage tabRules;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.RichTextBox txtRules;
        private System.Windows.Forms.RichTextBox txtTeam;
        private System.Windows.Forms.Button btnClose;
    }
}

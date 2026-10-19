namespace game_lật_thẻ_1._1
{
    partial class FormMenu
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
            // === BƯỚC 1: Chọn chế độ chơi ===
            this.pnlStep1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnModeMemory = new System.Windows.Forms.Button();
            this.btnModeSequence = new System.Windows.Forms.Button();
            this.btnExitStep1 = new System.Windows.Forms.Button();

            // === BƯỚC 2: Chọn độ khó / kích thước ===
            this.pnlStep2 = new System.Windows.Forms.Panel();
            this.lblStep2Title = new System.Windows.Forms.Label();
            this.lblChosenMode = new System.Windows.Forms.Label();

            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();

            this.lblCustomSize = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.lblSizeNote = new System.Windows.Forms.Label();

            this.lblTheme = new System.Windows.Forms.Label();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.chkHardcore = new System.Windows.Forms.CheckBox();

            this.btnStart = new System.Windows.Forms.Button();
            this.btnBackStep2 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            this.pnlStep1.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            this.SuspendLayout();

            // =============================================
            // pnlStep1 — Màn hình chọn chế độ chơi
            // =============================================
            this.pnlStep1.BackColor = System.Drawing.Color.FromArgb(247, 250, 253);
            this.pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep1.Controls.Add(this.lblTitle);
            this.pnlStep1.Controls.Add(this.lblSubtitle);
            this.pnlStep1.Controls.Add(this.btnModeMemory);
            this.pnlStep1.Controls.Add(this.btnModeSequence);
            this.pnlStep1.Controls.Add(this.btnExitStep1);
            this.pnlStep1.Name = "pnlStep1";

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 45);
            this.lblTitle.Text = "🃏 GAME LẬT THẺ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 90);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(480, 25);
            this.lblSubtitle.Text = "Chọn chế độ chơi bạn muốn:";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnModeMemory — Nút lớn chế độ Trí nhớ
            this.btnModeMemory.BackColor = System.Drawing.Color.FromArgb(52, 120, 246);
            this.btnModeMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeMemory.FlatAppearance.BorderSize = 0;
            this.btnModeMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeMemory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnModeMemory.ForeColor = System.Drawing.Color.White;
            this.btnModeMemory.Location = new System.Drawing.Point(50, 145);
            this.btnModeMemory.Name = "btnModeMemory";
            this.btnModeMemory.Size = new System.Drawing.Size(380, 80);
            this.btnModeMemory.TabIndex = 0;
            this.btnModeMemory.Text = "🧠  Lật Thẻ Trí Nhớ\r\nTìm các cặp thẻ giống nhau";
            this.btnModeMemory.UseVisualStyleBackColor = false;
            this.btnModeMemory.Click += new System.EventHandler(this.btnModeMemory_Click);

            // btnModeSequence — Nút lớn chế độ Thứ tự
            this.btnModeSequence.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnModeSequence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeSequence.FlatAppearance.BorderSize = 0;
            this.btnModeSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeSequence.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnModeSequence.ForeColor = System.Drawing.Color.White;
            this.btnModeSequence.Location = new System.Drawing.Point(50, 250);
            this.btnModeSequence.Name = "btnModeSequence";
            this.btnModeSequence.Size = new System.Drawing.Size(380, 80);
            this.btnModeSequence.TabIndex = 1;
            this.btnModeSequence.Text = "🔢  Lật Thẻ Theo Thứ Tự\r\nLật từ 1 → 2 → 3 → ... → N";
            this.btnModeSequence.UseVisualStyleBackColor = false;
            this.btnModeSequence.Click += new System.EventHandler(this.btnModeSequence_Click);

            // btnExitStep1
            this.btnExitStep1.BackColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this.btnExitStep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitStep1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnExitStep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitStep1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitStep1.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnExitStep1.Location = new System.Drawing.Point(175, 365);
            this.btnExitStep1.Name = "btnExitStep1";
            this.btnExitStep1.Size = new System.Drawing.Size(130, 40);
            this.btnExitStep1.TabIndex = 2;
            this.btnExitStep1.Text = "Thoát";
            this.btnExitStep1.UseVisualStyleBackColor = false;
            this.btnExitStep1.Click += new System.EventHandler(this.btnExit_Click);

            // =============================================
            // pnlStep2 — Màn hình chọn độ khó & kích thước
            // =============================================
            this.pnlStep2.BackColor = System.Drawing.Color.FromArgb(247, 250, 253);
            this.pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep2.Visible = false;
            this.pnlStep2.Controls.Add(this.lblStep2Title);
            this.pnlStep2.Controls.Add(this.lblChosenMode);
            this.pnlStep2.Controls.Add(this.lblDifficulty);
            this.pnlStep2.Controls.Add(this.btnEasy);
            this.pnlStep2.Controls.Add(this.btnMedium);
            this.pnlStep2.Controls.Add(this.btnHard);
            this.pnlStep2.Controls.Add(this.lblCustomSize);
            this.pnlStep2.Controls.Add(this.lblRows);
            this.pnlStep2.Controls.Add(this.numRows);
            this.pnlStep2.Controls.Add(this.lblX);
            this.pnlStep2.Controls.Add(this.numCols);
            this.pnlStep2.Controls.Add(this.lblSizeNote);
            this.pnlStep2.Controls.Add(this.lblTheme);
            this.pnlStep2.Controls.Add(this.cboTheme);
            this.pnlStep2.Controls.Add(this.chkPreview);
            this.pnlStep2.Controls.Add(this.chkHardcore);
            this.pnlStep2.Controls.Add(this.btnStart);
            this.pnlStep2.Controls.Add(this.btnBackStep2);
            this.pnlStep2.Name = "pnlStep2";

            // lblStep2Title
            this.lblStep2Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStep2Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStep2Title.Location = new System.Drawing.Point(0, 18);
            this.lblStep2Title.Name = "lblStep2Title";
            this.lblStep2Title.Size = new System.Drawing.Size(480, 35);
            this.lblStep2Title.Text = "Chọn Độ Khó";
            this.lblStep2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblChosenMode
            this.lblChosenMode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblChosenMode.ForeColor = System.Drawing.Color.Gray;
            this.lblChosenMode.Location = new System.Drawing.Point(0, 53);
            this.lblChosenMode.Name = "lblChosenMode";
            this.lblChosenMode.Size = new System.Drawing.Size(480, 20);
            this.lblChosenMode.Text = "";
            this.lblChosenMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDifficulty
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblDifficulty.Location = new System.Drawing.Point(30, 88);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(200, 22);
            this.lblDifficulty.Text = "Chọn nhanh:";

            // btnEasy
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEasy.ForeColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(30, 115);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(130, 45);
            this.btnEasy.Text = "Dễ\r\n3 × 4";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);

            // btnMedium
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedium.FlatAppearance.BorderSize = 0;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMedium.ForeColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(175, 115);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(130, 45);
            this.btnMedium.Text = "Trung bình\r\n4 × 4";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);

            // btnHard
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHard.FlatAppearance.BorderSize = 0;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(320, 115);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(130, 45);
            this.btnHard.Text = "Khó\r\n6 × 6";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);

            // lblCustomSize
            this.lblCustomSize.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomSize.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCustomSize.Location = new System.Drawing.Point(30, 180);
            this.lblCustomSize.Name = "lblCustomSize";
            this.lblCustomSize.Size = new System.Drawing.Size(300, 22);
            this.lblCustomSize.Text = "Hoặc tự chọn kích thước:";

            // lblRows
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRows.ForeColor = System.Drawing.Color.Black;
            this.lblRows.Location = new System.Drawing.Point(30, 212);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(50, 20);
            this.lblRows.Text = "Dòng:";

            // numRows
            this.numRows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numRows.Location = new System.Drawing.Point(82, 208);
            this.numRows.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.numRows.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(65, 25);
            this.numRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRows.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.numRows.ValueChanged += new System.EventHandler(this.numMatrix_ValueChanged);

            // lblX
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblX.ForeColor = System.Drawing.Color.Gray;
            this.lblX.Location = new System.Drawing.Point(152, 210);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 22);
            this.lblX.Text = "×";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // numCols
            this.numCols.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numCols.Location = new System.Drawing.Point(180, 208);
            this.numCols.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.numCols.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(65, 25);
            this.numCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCols.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.numCols.ValueChanged += new System.EventHandler(this.numMatrix_ValueChanged);

            // lblSizeNote
            this.lblSizeNote.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblSizeNote.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSizeNote.Location = new System.Drawing.Point(260, 212);
            this.lblSizeNote.Name = "lblSizeNote";
            this.lblSizeNote.Size = new System.Drawing.Size(200, 20);
            this.lblSizeNote.Text = "";

            // lblTheme
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblTheme.Location = new System.Drawing.Point(30, 255);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(120, 22);
            this.lblTheme.Text = "Chủ đề:";

            // cboTheme
            this.cboTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Items.AddRange(new object[] {
                "Động vật",
                "Công nghệ",
                "Trái cây & Đồ ăn",
                "Ký hiệu học thuật",
                "Biểu tượng vui vẻ"
            });
            this.cboTheme.Location = new System.Drawing.Point(150, 253);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(200, 25);

            // chkPreview
            this.chkPreview.AutoSize = true;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPreview.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkPreview.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.chkPreview.Location = new System.Drawing.Point(33, 295);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(250, 21);
            this.chkPreview.Text = "Nhìn trước 2 giây khi bắt đầu";
            this.chkPreview.UseVisualStyleBackColor = true;

            // chkHardcore
            this.chkHardcore.AutoSize = true;
            this.chkHardcore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHardcore.Enabled = false;
            this.chkHardcore.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkHardcore.ForeColor = System.Drawing.Color.DarkRed;
            this.chkHardcore.Location = new System.Drawing.Point(33, 322);
            this.chkHardcore.Name = "chkHardcore";
            this.chkHardcore.Size = new System.Drawing.Size(330, 21);
            this.chkHardcore.Text = "🔥 Hardcore (sai 1 bước = reset toàn bàn)";
            this.chkHardcore.UseVisualStyleBackColor = true;

            // btnStart
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(52, 120, 246);
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(30, 370);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 50);
            this.btnStart.Text = "▶  BẮT ĐẦU CHƠI";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnBackStep2
            this.btnBackStep2.BackColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this.btnBackStep2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackStep2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBackStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackStep2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackStep2.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnBackStep2.Location = new System.Drawing.Point(345, 378);
            this.btnBackStep2.Name = "btnBackStep2";
            this.btnBackStep2.Size = new System.Drawing.Size(105, 40);
            this.btnBackStep2.Text = "← Quay lại";
            this.btnBackStep2.UseVisualStyleBackColor = false;
            this.btnBackStep2.Click += new System.EventHandler(this.btnBackStep2_Click);

            // =============================================
            // FormMenu
            // =============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 250, 253);
            this.ClientSize = new System.Drawing.Size(480, 440);
            this.Controls.Add(this.pnlStep2);
            this.Controls.Add(this.pnlStep1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Lật Thẻ";

            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            this.pnlStep1.ResumeLayout(false);
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Bước 1
        private System.Windows.Forms.Panel pnlStep1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnModeMemory;
        private System.Windows.Forms.Button btnModeSequence;
        private System.Windows.Forms.Button btnExitStep1;

        // Bước 2
        private System.Windows.Forms.Panel pnlStep2;
        private System.Windows.Forms.Label lblStep2Title;
        private System.Windows.Forms.Label lblChosenMode;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblCustomSize;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown numCols;
        private System.Windows.Forms.Label lblSizeNote;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.CheckBox chkHardcore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBackStep2;
    }
}

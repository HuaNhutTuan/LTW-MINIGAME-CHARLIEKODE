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
            this.pnlStep1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.rdoSinglePlayer = new System.Windows.Forms.RadioButton();
            this.rdoTwoPlayers = new System.Windows.Forms.RadioButton();
            this.btnModeMemory = new System.Windows.Forms.Button();
            this.btnModeSequence = new System.Windows.Forms.Button();
            this.btnLeaderboardMenu = new System.Windows.Forms.Button();
            this.btnAboutMenu = new System.Windows.Forms.Button();
            this.btnSoundMenu = new System.Windows.Forms.Button();
            this.btnExitStep1 = new System.Windows.Forms.Button();
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
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.cboTimeLimit = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.chkHardcore = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBackStep2 = new System.Windows.Forms.Button();
            this.pnlStep1.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStep1
            // 
            this.pnlStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.pnlStep1.Controls.Add(this.btnSoundMenu);
            this.pnlStep1.Controls.Add(this.btnAboutMenu);
            this.pnlStep1.Controls.Add(this.btnLeaderboardMenu);
            this.pnlStep1.Controls.Add(this.rdoTwoPlayers);
            this.pnlStep1.Controls.Add(this.rdoSinglePlayer);
            this.pnlStep1.Controls.Add(this.lblPlayerChoice);
            this.pnlStep1.Controls.Add(this.lblTitle);
            this.pnlStep1.Controls.Add(this.lblSubtitle);
            this.pnlStep1.Controls.Add(this.btnModeMemory);
            this.pnlStep1.Controls.Add(this.btnModeSequence);
            this.pnlStep1.Controls.Add(this.btnExitStep1);
            this.pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep1.Location = new System.Drawing.Point(0, 0);
            this.pnlStep1.Name = "pnlStep1";
            this.pnlStep1.Size = new System.Drawing.Size(520, 560);
            this.pnlStep1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🃏 GAME LẬT THẺ TRÍ NHỚ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 62);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(520, 22);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Đồ án Lập Trình Trên Môi Trường Windows";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPlayerChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPlayerChoice.Location = new System.Drawing.Point(60, 95);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(126, 19);
            this.lblPlayerChoice.TabIndex = 2;
            this.lblPlayerChoice.Text = "Số lượng người chơi:";
            // 
            // rdoSinglePlayer
            // 
            this.rdoSinglePlayer.AutoSize = true;
            this.rdoSinglePlayer.Checked = true;
            this.rdoSinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSinglePlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdoSinglePlayer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoSinglePlayer.Location = new System.Drawing.Point(205, 93);
            this.rdoSinglePlayer.Name = "rdoSinglePlayer";
            this.rdoSinglePlayer.Size = new System.Drawing.Size(125, 23);
            this.rdoSinglePlayer.TabIndex = 3;
            this.rdoSinglePlayer.TabStop = true;
            this.rdoSinglePlayer.Text = "👤 1 Người chơi";
            this.rdoSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // rdoTwoPlayers
            // 
            this.rdoTwoPlayers.AutoSize = true;
            this.rdoTwoPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTwoPlayers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdoTwoPlayers.ForeColor = System.Drawing.Color.Crimson;
            this.rdoTwoPlayers.Location = new System.Drawing.Point(345, 93);
            this.rdoTwoPlayers.Name = "rdoTwoPlayers";
            this.rdoTwoPlayers.Size = new System.Drawing.Size(128, 23);
            this.rdoTwoPlayers.TabIndex = 4;
            this.rdoTwoPlayers.Text = "👥 2 Người chơi";
            this.rdoTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // btnModeMemory
            // 
            this.btnModeMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(246)))));
            this.btnModeMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeMemory.FlatAppearance.BorderSize = 0;
            this.btnModeMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeMemory.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnModeMemory.ForeColor = System.Drawing.Color.White;
            this.btnModeMemory.Location = new System.Drawing.Point(55, 130);
            this.btnModeMemory.Name = "btnModeMemory";
            this.btnModeMemory.Size = new System.Drawing.Size(410, 85);
            this.btnModeMemory.TabIndex = 5;
            this.btnModeMemory.Text = "🧠  Lật Thẻ Trí Nhớ\r\nTìm các cặp thẻ hình/biểu tượng giống nhau";
            this.btnModeMemory.UseVisualStyleBackColor = false;
            this.btnModeMemory.Click += new System.EventHandler(this.btnModeMemory_Click);
            // 
            // btnModeSequence
            // 
            this.btnModeSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnModeSequence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeSequence.FlatAppearance.BorderSize = 0;
            this.btnModeSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeSequence.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnModeSequence.ForeColor = System.Drawing.Color.White;
            this.btnModeSequence.Location = new System.Drawing.Point(55, 230);
            this.btnModeSequence.Name = "btnModeSequence";
            this.btnModeSequence.Size = new System.Drawing.Size(410, 85);
            this.btnModeSequence.TabIndex = 6;
            this.btnModeSequence.Text = "🔢  Lật Thẻ Theo Thứ Tự\r\nLật từ 1 → 2 → 3 → ... → N";
            this.btnModeSequence.UseVisualStyleBackColor = false;
            this.btnModeSequence.Click += new System.EventHandler(this.btnModeSequence_Click);
            // 
            // btnLeaderboardMenu
            // 
            this.btnLeaderboardMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.btnLeaderboardMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaderboardMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnLeaderboardMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboardMenu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLeaderboardMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.btnLeaderboardMenu.Location = new System.Drawing.Point(55, 335);
            this.btnLeaderboardMenu.Name = "btnLeaderboardMenu";
            this.btnLeaderboardMenu.Size = new System.Drawing.Size(200, 48);
            this.btnLeaderboardMenu.TabIndex = 7;
            this.btnLeaderboardMenu.Text = "🏆 Bảng Thành Tích";
            this.btnLeaderboardMenu.UseVisualStyleBackColor = false;
            this.btnLeaderboardMenu.Click += new System.EventHandler(this.btnLeaderboardMenu_Click);
            // 
            // btnAboutMenu
            // 
            this.btnAboutMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnAboutMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.btnAboutMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutMenu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAboutMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnAboutMenu.Location = new System.Drawing.Point(265, 335);
            this.btnAboutMenu.Name = "btnAboutMenu";
            this.btnAboutMenu.Size = new System.Drawing.Size(200, 48);
            this.btnAboutMenu.TabIndex = 8;
            this.btnAboutMenu.Text = "❓ Hướng Dẫn / Nhóm";
            this.btnAboutMenu.UseVisualStyleBackColor = false;
            this.btnAboutMenu.Click += new System.EventHandler(this.btnAboutMenu_Click);
            // 
            // btnSoundMenu
            // 
            this.btnSoundMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnSoundMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoundMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSoundMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoundMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSoundMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSoundMenu.Location = new System.Drawing.Point(125, 405);
            this.btnSoundMenu.Name = "btnSoundMenu";
            this.btnSoundMenu.Size = new System.Drawing.Size(130, 40);
            this.btnSoundMenu.TabIndex = 9;
            this.btnSoundMenu.Text = "🔊 Âm thanh: Bật";
            this.btnSoundMenu.UseVisualStyleBackColor = false;
            this.btnSoundMenu.Click += new System.EventHandler(this.btnSoundMenu_Click);
            // 
            // btnExitStep1
            // 
            this.btnExitStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnExitStep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitStep1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnExitStep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitStep1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnExitStep1.Location = new System.Drawing.Point(265, 405);
            this.btnExitStep1.Name = "btnExitStep1";
            this.btnExitStep1.Size = new System.Drawing.Size(130, 40);
            this.btnExitStep1.TabIndex = 10;
            this.btnExitStep1.Text = "Thoát";
            this.btnExitStep1.UseVisualStyleBackColor = false;
            this.btnExitStep1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlStep2
            // 
            this.pnlStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
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
            this.pnlStep2.Controls.Add(this.lblTimeLimit);
            this.pnlStep2.Controls.Add(this.cboTimeLimit);
            this.pnlStep2.Controls.Add(this.lblTheme);
            this.pnlStep2.Controls.Add(this.cboTheme);
            this.pnlStep2.Controls.Add(this.chkPreview);
            this.pnlStep2.Controls.Add(this.chkHardcore);
            this.pnlStep2.Controls.Add(this.btnStart);
            this.pnlStep2.Controls.Add(this.btnBackStep2);
            this.pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep2.Location = new System.Drawing.Point(0, 0);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(520, 560);
            this.pnlStep2.TabIndex = 1;
            this.pnlStep2.Visible = false;
            // 
            // lblStep2Title
            // 
            this.lblStep2Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStep2Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStep2Title.Location = new System.Drawing.Point(0, 18);
            this.lblStep2Title.Name = "lblStep2Title";
            this.lblStep2Title.Size = new System.Drawing.Size(520, 35);
            this.lblStep2Title.TabIndex = 0;
            this.lblStep2Title.Text = "Chọn Cấu Hình & Độ Khó";
            this.lblStep2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChosenMode
            // 
            this.lblChosenMode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblChosenMode.ForeColor = System.Drawing.Color.Gray;
            this.lblChosenMode.Location = new System.Drawing.Point(0, 53);
            this.lblChosenMode.Name = "lblChosenMode";
            this.lblChosenMode.Size = new System.Drawing.Size(520, 20);
            this.lblChosenMode.TabIndex = 1;
            this.lblChosenMode.Text = "";
            this.lblChosenMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDifficulty.Location = new System.Drawing.Point(40, 85);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(200, 22);
            this.lblDifficulty.TabIndex = 2;
            this.lblDifficulty.Text = "Chọn nhanh ma trận:";
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEasy.ForeColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(40, 110);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(135, 45);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "Dễ\r\n3 × 4";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedium.FlatAppearance.BorderSize = 0;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMedium.ForeColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(192, 110);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(135, 45);
            this.btnMedium.TabIndex = 4;
            this.btnMedium.Text = "Trung bình\r\n4 × 4";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHard.FlatAppearance.BorderSize = 0;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(345, 110);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(135, 45);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "Khó\r\n6 × 6";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblCustomSize
            // 
            this.lblCustomSize.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCustomSize.Location = new System.Drawing.Point(40, 172);
            this.lblCustomSize.Name = "lblCustomSize";
            this.lblCustomSize.Size = new System.Drawing.Size(300, 22);
            this.lblCustomSize.TabIndex = 6;
            this.lblCustomSize.Text = "Hoặc tùy chỉnh kích thước:";
            // 
            // lblRows
            // 
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRows.ForeColor = System.Drawing.Color.Black;
            this.lblRows.Location = new System.Drawing.Point(40, 202);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(50, 20);
            this.lblRows.TabIndex = 7;
            this.lblRows.Text = "Hàng:";
            // 
            // numRows
            // 
            this.numRows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numRows.Location = new System.Drawing.Point(95, 198);
            this.numRows.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.numRows.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(65, 25);
            this.numRows.TabIndex = 8;
            this.numRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRows.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.numRows.ValueChanged += new System.EventHandler(this.numMatrix_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblX.ForeColor = System.Drawing.Color.Gray;
            this.lblX.Location = new System.Drawing.Point(165, 200);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 22);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "×";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCols
            // 
            this.numCols.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numCols.Location = new System.Drawing.Point(195, 198);
            this.numCols.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.numCols.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(65, 25);
            this.numCols.TabIndex = 10;
            this.numCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCols.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.numCols.ValueChanged += new System.EventHandler(this.numMatrix_ValueChanged);
            // 
            // lblSizeNote
            // 
            this.lblSizeNote.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblSizeNote.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSizeNote.Location = new System.Drawing.Point(275, 202);
            this.lblSizeNote.Name = "lblSizeNote";
            this.lblSizeNote.Size = new System.Drawing.Size(200, 20);
            this.lblSizeNote.TabIndex = 11;
            this.lblSizeNote.Text = "";
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimeLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTimeLimit.Location = new System.Drawing.Point(40, 240);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(110, 22);
            this.lblTimeLimit.TabIndex = 12;
            this.lblTimeLimit.Text = "Thời gian:";
            // 
            // cboTimeLimit
            // 
            this.cboTimeLimit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeLimit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTimeLimit.FormattingEnabled = true;
            this.cboTimeLimit.Items.AddRange(new object[] {
            "30 giây",
            "1 phút",
            "2 phút",
            "3 phút",
            "Vô hạn"});
            this.cboTimeLimit.Location = new System.Drawing.Point(165, 238);
            this.cboTimeLimit.Name = "cboTimeLimit";
            this.cboTimeLimit.Size = new System.Drawing.Size(220, 25);
            this.cboTimeLimit.TabIndex = 13;
            // 
            // lblTheme
            // 
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTheme.Location = new System.Drawing.Point(40, 280);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(120, 22);
            this.lblTheme.TabIndex = 14;
            this.lblTheme.Text = "Chủ đề / Ảnh:";
            // 
            // cboTheme
            // 
            this.cboTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Items.AddRange(new object[] {
            "Hình ảnh thẻ bài",
            "Động vật",
            "Công nghệ",
            "Trái cây & Đồ ăn",
            "Ký hiệu học thuật",
            "Biểu tượng vui vẻ"});
            this.cboTheme.Location = new System.Drawing.Point(165, 278);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(220, 25);
            this.cboTheme.TabIndex = 15;
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPreview.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.chkPreview.Location = new System.Drawing.Point(43, 320);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(189, 21);
            this.chkPreview.TabIndex = 16;
            this.chkPreview.Text = "Nhìn trước 2 giây khi bắt đầu";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // chkHardcore
            // 
            this.chkHardcore.AutoSize = true;
            this.chkHardcore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHardcore.Enabled = false;
            this.chkHardcore.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkHardcore.ForeColor = System.Drawing.Color.DarkRed;
            this.chkHardcore.Location = new System.Drawing.Point(43, 350);
            this.chkHardcore.Name = "chkHardcore";
            this.chkHardcore.Size = new System.Drawing.Size(262, 21);
            this.chkHardcore.TabIndex = 17;
            this.chkHardcore.Text = "🔥 Hardcore (sai 1 bước = reset toàn bàn)";
            this.chkHardcore.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(246)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(40, 420);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(315, 52);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "▶  BẮT ĐẦU CHƠI";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBackStep2
            // 
            this.btnBackStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnBackStep2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackStep2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBackStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackStep2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBackStep2.Location = new System.Drawing.Point(365, 427);
            this.btnBackStep2.Name = "btnBackStep2";
            this.btnBackStep2.Size = new System.Drawing.Size(115, 42);
            this.btnBackStep2.TabIndex = 19;
            this.btnBackStep2.Text = "← Quay lại";
            this.btnBackStep2.UseVisualStyleBackColor = false;
            this.btnBackStep2.Click += new System.EventHandler(this.btnBackStep2_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(520, 560);
            this.Controls.Add(this.pnlStep2);
            this.Controls.Add(this.pnlStep1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Lật Thẻ Trí Nhớ - WinForms";
            this.pnlStep1.ResumeLayout(false);
            this.pnlStep1.PerformLayout();
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStep1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.RadioButton rdoSinglePlayer;
        private System.Windows.Forms.RadioButton rdoTwoPlayers;
        private System.Windows.Forms.Button btnModeMemory;
        private System.Windows.Forms.Button btnModeSequence;
        private System.Windows.Forms.Button btnLeaderboardMenu;
        private System.Windows.Forms.Button btnAboutMenu;
        private System.Windows.Forms.Button btnSoundMenu;
        private System.Windows.Forms.Button btnExitStep1;
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
        private System.Windows.Forms.Label lblTimeLimit;
        private System.Windows.Forms.ComboBox cboTimeLimit;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.CheckBox chkHardcore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBackStep2;
    }
}

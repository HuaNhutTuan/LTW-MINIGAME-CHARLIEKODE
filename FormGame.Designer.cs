namespace game_lật_thẻ_1._1
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.prgTime = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.pnlPauseOverlay = new System.Windows.Forms.Panel();
            this.btnResumeOverlay = new System.Windows.Forms.Button();
            this.lblPauseMessage = new System.Windows.Forms.Label();
            this.tmrPreview = new System.Windows.Forms.Timer(this.components);
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.tmrFlipBack = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlBoard.SuspendLayout();
            this.pnlPauseOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnSound);
            this.pnlHeader.Controls.Add(this.btnHelp);
            this.pnlHeader.Controls.Add(this.btnLeaderboard);
            this.pnlHeader.Controls.Add(this.btnPause);
            this.pnlHeader.Controls.Add(this.btnRestart);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblTurn);
            this.pnlHeader.Controls.Add(this.lblScore);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.prgTime);
            this.pnlHeader.Controls.Add(this.lblStatus);
            this.pnlHeader.Controls.Add(this.lblLevel);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(734, 118);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnSound
            // 
            this.btnSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSound.Location = new System.Drawing.Point(240, 10);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(42, 32);
            this.btnSound.TabIndex = 12;
            this.btnSound.Text = "🔊";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.Navy;
            this.btnHelp.Location = new System.Drawing.Point(288, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(42, 32);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "❓";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaderboard.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboard.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLeaderboard.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLeaderboard.Location = new System.Drawing.Point(336, 10);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(80, 32);
            this.btnLeaderboard.TabIndex = 10;
            this.btnLeaderboard.Text = "🏆 BXH";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.btnPause.Location = new System.Drawing.Point(422, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(95, 32);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "⏸ Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.Navy;
            this.btnRestart.Location = new System.Drawing.Point(523, 10);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(95, 32);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "🔄 Chơi lại";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(624, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "🚪 Thoát";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTurn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTurn.Location = new System.Drawing.Point(360, 50);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(120, 19);
            this.lblTurn.TabIndex = 8;
            this.lblTurn.Text = "👉 Lượt: P1";
            this.lblTurn.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblScore.Location = new System.Drawing.Point(180, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(81, 19);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Điểm số: 0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(520, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(199, 19);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời gian: 00s";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgTime
            // 
            this.prgTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgTime.Location = new System.Drawing.Point(15, 80);
            this.prgTime.Name = "prgTime";
            this.prgTime.Size = new System.Drawing.Size(704, 22);
            this.prgTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgTime.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStatus.Location = new System.Drawing.Point(14, 50);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(129, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Cặp đã ghép: 0 / 8";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLevel.Location = new System.Drawing.Point(14, 15);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(130, 20);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Cấp độ: 1 (4 x 4)";
            // 
            // pnlBoard
            // 
            this.pnlBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoard.Controls.Add(this.pnlPauseOverlay);
            this.pnlBoard.Location = new System.Drawing.Point(57, 135);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(620, 620);
            this.pnlBoard.TabIndex = 1;
            // 
            // pnlPauseOverlay
            // 
            this.pnlPauseOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlPauseOverlay.Controls.Add(this.btnResumeOverlay);
            this.pnlPauseOverlay.Controls.Add(this.lblPauseMessage);
            this.pnlPauseOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPauseOverlay.Location = new System.Drawing.Point(0, 0);
            this.pnlPauseOverlay.Name = "pnlPauseOverlay";
            this.pnlPauseOverlay.Size = new System.Drawing.Size(618, 618);
            this.pnlPauseOverlay.TabIndex = 0;
            this.pnlPauseOverlay.Visible = false;
            // 
            // btnResumeOverlay
            // 
            this.btnResumeOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(246)))));
            this.btnResumeOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResumeOverlay.FlatAppearance.BorderSize = 0;
            this.btnResumeOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumeOverlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnResumeOverlay.ForeColor = System.Drawing.Color.White;
            this.btnResumeOverlay.Location = new System.Drawing.Point(209, 320);
            this.btnResumeOverlay.Name = "btnResumeOverlay";
            this.btnResumeOverlay.Size = new System.Drawing.Size(200, 48);
            this.btnResumeOverlay.TabIndex = 1;
            this.btnResumeOverlay.Text = "▶ Tiếp Tục Chơi";
            this.btnResumeOverlay.UseVisualStyleBackColor = false;
            this.btnResumeOverlay.Click += new System.EventHandler(this.btnResumeOverlay_Click);
            // 
            // lblPauseMessage
            // 
            this.lblPauseMessage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPauseMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPauseMessage.Location = new System.Drawing.Point(0, 240);
            this.lblPauseMessage.Name = "lblPauseMessage";
            this.lblPauseMessage.Size = new System.Drawing.Size(618, 45);
            this.lblPauseMessage.TabIndex = 0;
            this.lblPauseMessage.Text = "⏸ TRÒ CHƠI ĐANG TẠM DỪNG";
            this.lblPauseMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(734, 775);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Lật Thẻ Trí Nhớ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBoard.ResumeLayout(false);
            this.pnlPauseOverlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ProgressBar prgTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Panel pnlPauseOverlay;
        private System.Windows.Forms.Button btnResumeOverlay;
        private System.Windows.Forms.Label lblPauseMessage;
        private System.Windows.Forms.Timer tmrPreview;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Timer tmrFlipBack;
    }
}

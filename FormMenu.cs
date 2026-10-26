using System;
using System.Drawing;
using System.Windows.Forms;

namespace game_lật_thẻ_1._1
{
    public partial class FormMenu : Form
    {
        private GameMode selectedMode;

        public FormMenu()
        {
            InitializeComponent();

            try
            {
                // Khởi tạo tài nguyên ảnh & âm thanh an toàn
                CardImageManager.InitializeImages();
                SoundManager.InitializeSounds();
                SoundManager.PlayBgm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cảnh báo nạp tài nguyên ban đầu: " + ex.Message,
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            if (cboTheme.Items.Count > 0)
                cboTheme.SelectedIndex = 0; // "Hình ảnh thẻ bài"

            if (cboTimeLimit.Items.Count > 0)
                cboTimeLimit.SelectedIndex = 1; // Mặc định: 1 phút

            UpdateSoundButtonText();

            // Bước 1 hiển thị, bước 2 ẩn
            pnlStep1.Visible = true;
            pnlStep1.BringToFront();
            pnlStep2.Visible = false;
        }

        private void UpdateSoundButtonText()
        {
            btnSoundMenu.Text = SoundManager.IsMuted ? "🔇 Âm thanh: Tắt" : "🔊 Âm thanh: Bật";
        }

        private void btnSoundMenu_Click(object sender, EventArgs e)
        {
            SoundManager.ToggleMute();
            UpdateSoundButtonText();
            if (!SoundManager.IsMuted)
            {
                SoundManager.PlayBgm();
            }
        }

        private void btnLeaderboardMenu_Click(object sender, EventArgs e)
        {
            FormLeaderboard frmLeaderboard = new FormLeaderboard();
            frmLeaderboard.ShowDialog(this);
        }

        private void btnAboutMenu_Click(object sender, EventArgs e)
        {
            FormAbout frmAbout = new FormAbout();
            frmAbout.ShowDialog(this);
        }

        // ============================
        // BƯỚC 1: Chọn chế độ chơi
        // ============================

        private void btnModeMemory_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();
            selectedMode = GameMode.MemoryMatch;
            GoToStep2();
        }

        private void btnModeSequence_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();
            selectedMode = GameMode.SequentialOrder;
            GoToStep2();
        }

        private void GoToStep2()
        {
            string playerText = rdoTwoPlayers.Checked ? " (ĐỐI KHÁNG 2 NGƯỜI)" : " (1 NGƯỜI CHƠI)";

            if (selectedMode == GameMode.MemoryMatch)
            {
                lblChosenMode.Text = "🧠 Chế độ: Lật Thẻ Trí Nhớ" + playerText;
                chkHardcore.Enabled = false;
                chkHardcore.Checked = false;
                chkHardcore.Visible = false;

                lblTheme.Visible = true;
                cboTheme.Visible = true;

                numRows.Value = 4;
                numCols.Value = 4;
            }
            else
            {
                lblChosenMode.Text = "🔢 Chế độ: Lật Thẻ Theo Thứ Tự" + playerText;
                chkHardcore.Enabled = true;
                chkHardcore.Visible = true;
                chkHardcore.Text = "🔥 Hardcore (sai 1 bước = reset toàn bàn về số 1)";

                lblTheme.Visible = false;
                cboTheme.Visible = false;

                numRows.Value = 4;
                numCols.Value = 4;
            }

            UpdateValidationHint();

            // Chuyển sang bước 2
            pnlStep1.Visible = false;
            pnlStep2.Visible = true;
            pnlStep2.BringToFront();
        }

        // ============================
        // BƯỚC 2: Chọn độ khó & cấu hình
        // ============================

        private void btnEasy_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();
            if (selectedMode == GameMode.MemoryMatch)
            {
                numRows.Value = 3;
                numCols.Value = 4; // 12 thẻ = 6 cặp (chẵn)
            }
            else
            {
                numRows.Value = 3;
                numCols.Value = 3;
            }
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();
            numRows.Value = 4;
            numCols.Value = 4;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();
            numRows.Value = 6;
            numCols.Value = 6;
        }

        private void btnBackStep2_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();
            pnlStep2.Visible = false;
            pnlStep1.Visible = true;
            pnlStep1.BringToFront();
        }

        private void numMatrix_ValueChanged(object sender, EventArgs e)
        {
            UpdateValidationHint();
        }

        private void UpdateValidationHint()
        {
            int rows = (int)numRows.Value;
            int cols = (int)numCols.Value;
            int total = rows * cols;

            if (selectedMode == GameMode.MemoryMatch)
            {
                if (total % 2 != 0)
                {
                    lblSizeNote.Text = $"⚠ {rows}×{cols}={total} (lẻ)";
                    lblSizeNote.ForeColor = Color.Red;
                }
                else
                {
                    lblSizeNote.Text = $"✓ {total} thẻ ({total / 2} cặp)";
                    lblSizeNote.ForeColor = Color.ForestGreen;
                }
            }
            else
            {
                lblSizeNote.Text = $"✓ Dãy 1 → {total}";
                lblSizeNote.ForeColor = Color.ForestGreen;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SoundManager.PlayFlip();

            int rows = (int)numRows.Value;
            int cols = (int)numCols.Value;
            string selectedTheme = cboTheme.SelectedItem?.ToString() ?? "Hình ảnh thẻ bài";
            bool enablePreview = chkPreview.Checked;
            bool isHardcore = chkHardcore.Checked && selectedMode == GameMode.SequentialOrder;
            PlayerMode playerMode = rdoTwoPlayers.Checked ? PlayerMode.TwoPlayers : PlayerMode.SinglePlayer;

            // Lấy thời gian đã chọn (0 = vô hạn)
            int timeLimitSeconds = 60;
            string timeChoice = cboTimeLimit.SelectedItem?.ToString() ?? "1 phút";
            switch (timeChoice)
            {
                case "30 giây": timeLimitSeconds = 30; break;
                case "1 phút": timeLimitSeconds = 60; break;
                case "2 phút": timeLimitSeconds = 120; break;
                case "3 phút": timeLimitSeconds = 180; break;
                case "Vô hạn": timeLimitSeconds = 0; break;
            }

            // Ràng buộc cho chế độ Trí nhớ: tổng phải chẵn
            if (selectedMode == GameMode.MemoryMatch && (rows * cols) % 2 != 0)
            {
                MessageBox.Show(
                    $"Chế độ Trí Nhớ yêu cầu tổng số thẻ phải là số chẵn!\nHiện tại: {rows} × {cols} = {rows * cols} (lẻ).\n\nHãy chỉnh lại kích thước.",
                    "Không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Chế độ đối kháng chỉ hỗ trợ ghép cặp Trí nhớ
            if (playerMode == PlayerMode.TwoPlayers && selectedMode != GameMode.MemoryMatch)
            {
                MessageBox.Show(
                    "Chế độ Đối kháng 2 người chơi hiện áp dụng cho luật chơi 'Ghép cặp Trí Nhớ'!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                selectedMode = GameMode.MemoryMatch;
            }

            FormGame frmGame = new FormGame(selectedMode, rows, cols, selectedTheme, enablePreview, isHardcore, timeLimitSeconds, playerMode);
            this.Hide();
            frmGame.ShowDialog();
            this.Show();

            // Cập nhật lại trạng thái âm thanh sau khi từ FormGame trở về
            UpdateSoundButtonText();

            // Reset về bước 1 khi quay lại menu
            pnlStep2.Visible = false;
            pnlStep1.Visible = true;
            pnlStep1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

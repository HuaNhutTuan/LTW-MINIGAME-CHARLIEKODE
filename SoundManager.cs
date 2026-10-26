using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace game_lật_thẻ_1._1
{
    /// <summary>
    /// Quản lý âm thanh trò chơi (Nhạc nền và hiệu ứng sự kiện) sử dụng System.Media.SoundPlayer.
    /// Có cơ chế bẫy lỗi try...catch toàn diện theo đúng yêu cầu đề bài.
    /// </summary>
    public static class SoundManager
    {
        private static SoundPlayer flipPlayer;
        private static SoundPlayer correctPlayer;
        private static SoundPlayer wrongPlayer;
        private static SoundPlayer victoryPlayer;
        private static SoundPlayer gameOverPlayer;
        private static SoundPlayer bgmPlayer;

        public static bool IsMuted { get; set; } = false;

        private static string soundDirectory;

        static SoundManager()
        {
            InitializeSounds();
        }

        public static void InitializeSounds()
        {
            try
            {
                // Thử tìm thư mục bg tại đường dẫn thực thi hoặc thư mục gốc ứng dụng
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                soundDirectory = Path.Combine(baseDir, "bg");

                if (!Directory.Exists(soundDirectory))
                {
                    // Thử tìm ở thư mục cha nếu chạy trong bin/Debug
                    string parentDir = Directory.GetParent(baseDir)?.Parent?.FullName;
                    if (parentDir != null)
                    {
                        string candidate = Path.Combine(parentDir, "bg");
                        if (Directory.Exists(candidate))
                        {
                            soundDirectory = candidate;
                        }
                    }
                }

                if (!Directory.Exists(soundDirectory))
                {
                    // Nếu vẫn không tìm thấy, cố gắng tạo thư mục rỗng để không văng
                    Directory.CreateDirectory(soundDirectory);
                }

                flipPlayer = CreatePlayer("flip.wav");
                correctPlayer = CreatePlayer("true.wav");
                wrongPlayer = CreatePlayer("false.wav");
                victoryPlayer = CreatePlayer("victory.wav");
                gameOverPlayer = CreatePlayer("gameover.wav");
                bgmPlayer = CreatePlayer("bgm.wav");
            }
            catch (Exception ex)
            {
                // Bẫy lỗi an toàn: Không làm sập ứng dụng
                MessageBox.Show(
                    "Không thể nạp một số tài nguyên âm thanh từ thư mục 'bg/':\n" + ex.Message + "\nTrò chơi sẽ tiếp tục mà không có âm thanh.",
                    "Cảnh báo Âm thanh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private static SoundPlayer CreatePlayer(string fileName)
        {
            try
            {
                string path = Path.Combine(soundDirectory, fileName);
                if (File.Exists(path))
                {
                    SoundPlayer sp = new SoundPlayer(path);
                    sp.LoadAsync();
                    return sp;
                }
            }
            catch (Exception)
            {
                // Bỏ qua lỗi nạp từng file lẻ
            }
            return null;
        }

        public static void PlayFlip()
        {
            if (IsMuted) return;
            try
            {
                flipPlayer?.Play();
            }
            catch (Exception) { }
        }

        public static void PlayCorrect()
        {
            if (IsMuted) return;
            try
            {
                correctPlayer?.Play();
            }
            catch (Exception) { }
        }

        public static void PlayWrong()
        {
            if (IsMuted) return;
            try
            {
                wrongPlayer?.Play();
            }
            catch (Exception) { }
        }

        public static void PlayVictory()
        {
            if (IsMuted) return;
            try
            {
                victoryPlayer?.Play();
            }
            catch (Exception) { }
        }

        public static void PlayGameOver()
        {
            if (IsMuted) return;
            try
            {
                gameOverPlayer?.Play();
            }
            catch (Exception) { }
        }

        public static void PlayBgm()
        {
            if (IsMuted) return;
            try
            {
                bgmPlayer?.PlayLooping();
            }
            catch (Exception) { }
        }

        public static void StopBgm()
        {
            try
            {
                bgmPlayer?.Stop();
            }
            catch (Exception) { }
        }

        public static bool ToggleMute()
        {
            IsMuted = !IsMuted;
            if (IsMuted)
            {
                StopBgm();
            }
            return IsMuted;
        }
    }
}

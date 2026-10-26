using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game_lật_thẻ_1._1
{
    public class LeaderboardRecord
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int TimeRemaining { get; set; }
        public string Mode { get; set; }
        public DateTime PlayedAt { get; set; }

        public override string ToString()
        {
            return $"{Name}#{Score}#{TimeRemaining}#{Mode}#{PlayedAt:yyyy-MM-dd HH:mm}";
        }
    }

    /// <summary>
    /// Quản lý Bảng thành tích (Leaderboard) đọc/ghi file thanhtichs.txt bằng System.IO.
    /// Có đầy đủ bẫy lỗi Exception Handling theo yêu cầu đề bài.
    /// </summary>
    public static class LeaderboardManager
    {
        private static string filePath;

        static LeaderboardManager()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                filePath = Path.Combine(baseDir, "thanhtichs.txt");

                if (!File.Exists(filePath))
                {
                    string parentDir = Directory.GetParent(baseDir)?.Parent?.FullName;
                    if (parentDir != null)
                    {
                        string candidate = Path.Combine(parentDir, "thanhtichs.txt");
                        if (File.Exists(candidate))
                        {
                            filePath = candidate;
                        }
                    }
                }

                // Nếu chưa có file nào thì tạo file mới rỗng
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "", Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể khởi tạo đường dẫn file 'thanhtichs.txt':\n" + ex.Message,
                    "Lỗi Tập Tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ghi thêm một bản ghi thành tích mới vào file thanhtichs.txt (dạng Append)
        /// </summary>
        public static bool SaveRecord(string name, int score, int timeRemaining, string mode)
        {
            if (string.IsNullOrWhiteSpace(name))
                name = "Người chơi ẩn danh";

            LeaderboardRecord record = new LeaderboardRecord
            {
                Name = name.Replace("#", " ").Trim(),
                Score = score,
                TimeRemaining = Math.Max(0, timeRemaining),
                Mode = mode,
                PlayedAt = DateTime.Now
            };

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    sw.WriteLine(record.ToString());
                }
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(
                    "Không có quyền ghi vào file 'thanhtichs.txt':\n" + ex.Message,
                    "Lỗi Truy Cập Tệp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "Lỗi I/O khi ghi vào file thành tích:\n" + ex.Message,
                    "Lỗi Ghi Tệp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi không xác định khi lưu điểm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Đọc toàn bộ danh sách thành tích từ file thanhtichs.txt và sắp xếp theo điểm số giảm dần
        /// </summary>
        public static List<LeaderboardRecord> LoadRecords()
        {
            List<LeaderboardRecord> records = new List<LeaderboardRecord>();

            try
            {
                if (!File.Exists(filePath))
                    return records;

                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('#');
                    if (parts.Length >= 4)
                    {
                        LeaderboardRecord rec = new LeaderboardRecord
                        {
                            Name = parts[0].Trim(),
                            Score = int.TryParse(parts[1], out int sc) ? sc : 0,
                            TimeRemaining = int.TryParse(parts[2], out int tm) ? tm : 0,
                            Mode = parts[3].Trim(),
                            PlayedAt = (parts.Length >= 5 && DateTime.TryParse(parts[4], out DateTime dt)) ? dt : DateTime.Now
                        };
                        records.Add(rec);
                    }
                }

                // Sắp xếp giảm dần theo điểm số, nếu bằng điểm thì ưu tiên thời gian còn lại nhiều hơn
                return records
                    .OrderByDescending(r => r.Score)
                    .ThenByDescending(r => r.TimeRemaining)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi đọc file 'thanhtichs.txt':\n" + ex.Message,
                    "Lỗi Đọc Tập Tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return records;
            }
        }

        /// <summary>
        /// Xóa toàn bộ lịch sử thành tích
        /// </summary>
        public static bool ClearRecords()
        {
            try
            {
                File.WriteAllText(filePath, "", Encoding.UTF8);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa dữ liệu thành tích:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

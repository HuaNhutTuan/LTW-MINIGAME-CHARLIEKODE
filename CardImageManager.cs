using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace game_lật_thẻ_1._1
{
    /// <summary>
    /// Quản lý nạp và cache hình ảnh thẻ bài từ thư mục img/.
    /// Có cơ chế bẫy lỗi try...catch và hình ảnh dự phòng tự động nếu thiếu file.
    /// </summary>
    public static class CardImageManager
    {
        private static string imgDirectory;
        private static Image cardBackImage;
        private static readonly Dictionary<int, Image> cardCache = new Dictionary<int, Image>();
        private static bool isInitialized = false;

        public static bool HasImagesAvailable { get; private set; } = false;

        public static void InitializeImages()
        {
            if (isInitialized) return;

            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                imgDirectory = Path.Combine(baseDir, "img");

                if (!Directory.Exists(imgDirectory))
                {
                    string parentDir = Directory.GetParent(baseDir)?.Parent?.FullName;
                    if (parentDir != null)
                    {
                        string candidate = Path.Combine(parentDir, "img");
                        if (Directory.Exists(candidate))
                        {
                            imgDirectory = candidate;
                        }
                    }
                }

                if (Directory.Exists(imgDirectory))
                {
                    string backPath = Path.Combine(imgDirectory, "card_back.png");
                    if (!File.Exists(backPath))
                    {
                        backPath = Path.Combine(imgDirectory, "no-image.png");
                    }

                    if (File.Exists(backPath))
                    {
                        using (var temp = Image.FromFile(backPath))
                        {
                            cardBackImage = new Bitmap(temp);
                        }
                        HasImagesAvailable = true;
                    }
                }
                else
                {
                    Directory.CreateDirectory(imgDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể nạp một số hình ảnh từ thư mục 'img/':\n" + ex.Message + "\nTrò chơi sẽ chuyển sang chế độ đồ họa văn bản dự phòng.",
                    "Cảnh Báo Hình Ảnh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                isInitialized = true;
            }
        }

        public static Image GetCardBack()
        {
            InitializeImages();

            if (cardBackImage != null)
                return cardBackImage;

            // Fallback nếu không có file ảnh: Tự vẽ ảnh mặt sau
            try
            {
                Bitmap bmp = new Bitmap(120, 120);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(52, 120, 246));
                    using (Pen p = new Pen(Color.Gold, 3))
                    {
                        g.DrawRectangle(p, 4, 4, 111, 111);
                    }
                    using (Font f = new Font("Segoe UI", 32, FontStyle.Bold))
                    {
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString("?", f, Brushes.White, new RectangleF(0, 0, 120, 120), sf);
                    }
                }
                cardBackImage = bmp;
                return cardBackImage;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Image GetCardImage(int cardId)
        {
            InitializeImages();

            if (cardCache.ContainsKey(cardId))
                return cardCache[cardId];

            try
            {
                if (Directory.Exists(imgDirectory))
                {
                    string fileName = $"card_{cardId}.png";
                    string filePath = Path.Combine(imgDirectory, fileName);

                    if (File.Exists(filePath))
                    {
                        using (var temp = Image.FromFile(filePath))
                        {
                            Bitmap bmp = new Bitmap(temp);
                            cardCache[cardId] = bmp;
                            return bmp;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Bẫy lỗi: nếu file hỏng hoặc lỗi thì tự sinh ảnh fallback
            }

            // Sinh ảnh fallback có số cardId
            try
            {
                Bitmap fallback = new Bitmap(120, 120);
                using (Graphics g = Graphics.FromImage(fallback))
                {
                    g.Clear(Color.White);
                    using (Pen p = new Pen(Color.FromArgb(100, 149, 237), 2))
                    {
                        g.DrawRectangle(p, 2, 2, 115, 115);
                    }
                    using (Font f = new Font("Segoe UI", 26, FontStyle.Bold))
                    {
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString(cardId.ToString(), f, Brushes.RoyalBlue, new RectangleF(0, 0, 120, 120), sf);
                    }
                }
                cardCache[cardId] = fallback;
                return fallback;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

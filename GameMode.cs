using System;

namespace game_lật_thẻ_1._1
{
    /// <summary>
    /// Định nghĩa Enum để phân biệt 2 chế độ chơi trong toàn bộ dự án
    /// </summary>
    public enum GameMode
    {
        MemoryMatch,     // Game 1: Lật thẻ ghép cặp trí nhớ
        SequentialOrder  // Game 2: Lật thẻ theo số tiến lên (1 -> N)
    }

    /// <summary>
    /// Định nghĩa số lượng người chơi: Chơi đơn (1 người) hoặc Đối kháng (2 người)
    /// </summary>
    public enum PlayerMode
    {
        SinglePlayer,    // 1 người chơi
        TwoPlayers       // 2 người chơi đối kháng
    }
}

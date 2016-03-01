using UnityEngine;

namespace Assets.Scripts
{
    public class ScoreController : MonoBehaviour
    {
        public GUIText ScoreGuiText;
        public GUIText HighScoreGuiText;

        private int _score;
        private int _highScore;
        private const string HighScoreKey = "HighScrore";

        void Start()
        {
            // 初期化
            Initialize();
        }

        void Update()
        {
            // HighScore 更新
            if (_score > _highScore) _highScore = _score;

            // Score / HighScrore 表示
            ScoreGuiText.text = _score.ToString();
            HighScoreGuiText.text = "HighScore : " + _highScore.ToString();
        }

        private void Initialize()
        {
            _score = 0;
            _highScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        }

        public void AddPoint(int point)
        {
            _score += point;
        }

        public void Save()
        {
            PlayerPrefs.SetInt(HighScoreKey, _highScore);
            PlayerPrefs.Save();

            // 初期化
            Initialize();
        }
    }
}

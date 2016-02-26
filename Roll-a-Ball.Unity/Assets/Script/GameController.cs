using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Script
{
    public class GameController : MonoBehaviour
    {
        public float GameOverLimit;
        public Text ScoreLabel;
        public Text ElapsedTimeLabel;
        public Text TimeLimitLabel;
        public GameObject FinishLabel;

        private int _initialItemCount;
        private float timeLimit;
        private float deltaTimer;

        public void Start()
        {
            _initialItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
            FinishLabel.SetActive(false);
            ScoreLabel.text = "Score : 0";
            TimeLimitLabel.text = "TimeLimit : " + GameOverLimit;
            ElapsedTimeLabel.text = "Elapsed time : 00:00:00";
            timeLimit = GameOverLimit;
        }

        public void Update()
        {
            // 経過時間表示
            var elapsedTime = TimeSpan.FromSeconds(double.Parse(Time.time.ToString()));
            ElapsedTimeLabel.text = string.Format("Elapsed time : {0:00}:{1:00}:{2:00}", elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.TotalMilliseconds);

            // 制限時間表示
            if (Time.time > timeLimit) timeLimit = 0;
            timeLimit -= Time.deltaTime;
            TimeLimitLabel.text = "TimeLimit : " + (int)timeLimit;

            // 残数表示
            var itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
            var score = _initialItemCount - itemCount;
            ScoreLabel.text = string.Format("Score : " + score);

            // クリア時の処理
            if (itemCount == 0)
            {
                FinishLabel.GetComponent<Text>().text = "You Win!!";
                FinishLabel.SetActive(true);
            }

            // GameOver 処理
            if (timeLimit <= 0)
            {
                FinishLabel.GetComponent<Text>().text = "Game Over....";
                FinishLabel.SetActive(true);
            }
        }

        public void OnGUI()
        {
            if (Time.time >= GameOverLimit)
            {
                if (GUILayout.Button("Reload"))
                {
                    FinishLabel.SetActive(false);
                    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}
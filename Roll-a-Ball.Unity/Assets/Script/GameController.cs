using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class GameController : MonoBehaviour
    {
        public Text ScoreLabel;
        public Text ElapsedTimeLabel;
        public GameObject WinnerLabel;
        private int _initialItemCount;

        public void Start()
        {
            _initialItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        }

        public void Update()
        {
            // 経過時間表示
            var elapsedTime = TimeSpan.FromSeconds(double.Parse(Time.time.ToString()));
            ElapsedTimeLabel.text = string.Format("経過時間 : {0:00}:{1:00}:{2:00}", elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.TotalMilliseconds);

            // 残数表示
            var itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
            var score = _initialItemCount - itemCount;
            ScoreLabel.text = string.Format("Score : " + score);

            // クリア時の処理
            if (itemCount == 0)
            {
                WinnerLabel.SetActive(true);
            }
        }
    }
}
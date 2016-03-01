using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public GameObject Player;
        private GameObject _title;
        
        void Start()
        {
            _title = GameObject.Find("Title");
        }

        void Update()
        {
            if (IsPlaying() == false && Input.GetKeyDown(KeyCode.X))
            {
                GameStart();
            }
        }

        void GameStart()
        {
            _title.SetActive(false);
            Instantiate(Player, Player.transform.position, Player.transform.rotation);
        }

        public void GameOver()
        {
            // ハイスコア保存
            FindObjectOfType<ScoreController>().Save();

            _title.SetActive(true);
        }

        public bool IsPlaying()
        {
            return _title.activeSelf == false;
        }
    }
}

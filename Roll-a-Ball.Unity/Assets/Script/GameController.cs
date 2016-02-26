using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreLabel;
    public GameObject WinnerLabel;

    public void Update()
    {
        // 残数表示
        var count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();

        // クリア時の処理
        if (count == 0)
        {
            WinnerLabel.SetActive(true);
        }
    }
}

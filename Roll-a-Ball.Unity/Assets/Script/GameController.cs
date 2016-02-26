using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreLabel;

    public void Update()
    {
        var count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();
    }
}

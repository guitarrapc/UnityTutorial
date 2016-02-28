using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5;

    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // Obtain where to move from Input. (Keyboard)
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        
        // Direction to move
        var direction = new Vector2(x, y).normalized;

        // Apply Direction and Speed
        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }
}

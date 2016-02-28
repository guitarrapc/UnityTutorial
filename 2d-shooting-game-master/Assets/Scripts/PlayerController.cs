using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject PlayerBullet;
        public float Speed = 5;

        IEnumerator Start()
        {
            while (true)
            {
                // 弾を自機と同じ位置/角度で インスタンシェート (作成)
                var bullet = Instantiate(PlayerBullet, transform.position, transform.rotation);
                yield return new WaitForSeconds(0.05f);
            }
        }

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
}
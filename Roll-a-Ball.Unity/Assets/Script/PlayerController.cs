using UnityEngine;

namespace Assets.Script
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;

        void FixedUpdate()
        {
            if (Input.GetKey("down"))
            {
                Debug.Log("down キーが押された！");
            }

            // Obtain Input
            var keyX = Input.GetAxis("Horizontal");
            var keyY = Input.GetAxis("Vertical");
            var mouseX = Input.GetAxis("Mouse X");
            var mouseY = Input.GetAxis("Mouse Y");
            var x = keyX + mouseX;
            var y = keyY + mouseY;
            
            var rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddForce(x * Speed, 0, y * Speed);
        }
    }
}

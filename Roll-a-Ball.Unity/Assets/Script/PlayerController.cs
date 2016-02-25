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
            var x = Input.GetAxis("Horizontal");
            var z = Input.GetAxis("Vertical");

            var rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddForce(x * Speed, 0, z * Speed);
        }
    }
}
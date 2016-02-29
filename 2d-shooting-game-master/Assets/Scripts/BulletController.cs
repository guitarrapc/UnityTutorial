using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class BulletController : MonoBehaviour
    {
        public int Speed = 10;
        public float LifeTime = 5;

        void Start()
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.up.normalized * Speed;

            Destroy(gameObject, LifeTime);
        }
    }
}
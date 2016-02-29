using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class SpaceShipController : MonoBehaviour
    {
        public float MoveSpeed;
        public bool CanShot;
        public float ShotInterval;

        public GameObject BulletObject;
        public GameObject ExplosionObject;

        public void Explosion()
        {
            Instantiate(ExplosionObject, transform.position, transform.rotation);
        }

        public void Shot(Transform origin)
        {
            // 同じ位置、角度から弾を発射
            Instantiate(BulletObject, origin.position, origin.rotation);
        }

        public void Move(Vector2 direction)
        {
            GetComponent<Rigidbody2D>().velocity = direction * MoveSpeed;
        }
    }
}
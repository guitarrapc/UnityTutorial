using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class SpaceShipControllerBase : MonoBehaviour
    {
        public float MoveSpeed;
        public bool CanShot;
        public float ShotInterval;

        public GameObject BulletObject;
        public GameObject ExplosionObject;

        public int HitPoint;

        public virtual void Explosion(GameObject explosion)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        public virtual void Shot(Transform origin, GameObject bullet)
        {
            // 同じ位置、角度から弾を発射
            Instantiate(bullet, origin.position, origin.rotation);
        }

        protected abstract void Move(Vector2 direction);

        protected abstract Animator GetAnimator();
    }
}
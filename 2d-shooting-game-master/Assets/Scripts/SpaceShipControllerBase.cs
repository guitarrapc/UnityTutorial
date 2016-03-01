using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class SpaceShipControllerBase : MonoBehaviour
    {
        protected float MoveSpeed;
        protected bool CanShot;
        protected float ShotInterval;

        protected GameObject BulletObject;
        protected GameObject ExplosionObject;

        public void Explosion(GameObject explosion)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        public virtual void Shot(Transform origin, GameObject bullet)
        {
            // 同じ位置、角度から弾を発射
            Instantiate(bullet, origin.position, origin.rotation);
        }

        protected abstract void Move(Vector2 direction);
    }
}
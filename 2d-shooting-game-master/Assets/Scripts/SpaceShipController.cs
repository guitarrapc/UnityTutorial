using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class SpaceShipController : MonoBehaviour
{
    public float Speed;
    public bool CanShot;
    public float ShotInterval;
    public GameObject Bullet;

    public void Shot(Transform origin)
    {
        // 同じ位置、角度から弾を発射
        Instantiate(Bullet, origin.position, origin.rotation);
    }

    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }
}

using UnityEngine;
using System.Collections;
using System.Linq;
using System;

namespace Assets.Scripts
{

    public class EnemyController : SpaceShipControllerBase
    {
        IEnumerator Start()
        {
            // y軸 (up) のマイナス => 下に移動
            Move(transform.up * -1);

            // 弾を打たない属性の場合はここでコルーチンも終わり
            if (!CanShot) yield break;

            // 弾の発射
            while (true)
            {
                // 子要素となるShotPosition 要素数を取得 -> 子要素のTransformを取得
                foreach (var shotPosition in Enumerable.Range(0, transform.childCount).Select(index => transform.GetChild(index)))
                {
                    // 子要素のTranform と同じ位置、角度から発射
                    base.Shot(shotPosition, BulletObject);
                }
                yield return new WaitForSeconds(ShotInterval);
            }
        }

        protected override void Move(Vector2 direction)
        {
            GetComponent<Rigidbody2D>().velocity = direction * MoveSpeed;
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            // collider の Layer名取得
            var layerName = LayerMask.LayerToName(collider.gameObject.layer);

            if (layerName == "Bullet(Player)" || layerName == "Player")
            {
                // Playerの弾/Playerを削除
                Destroy(collider.gameObject);

                // 爆発エフェクト
                base.Explosion(ExplosionObject);

                // 自分自身を削除
                Destroy(gameObject);
            }
        }
    }
}
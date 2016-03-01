using UnityEngine;
using System.Collections;
using System.Linq;
using System;

namespace Assets.Scripts
{
    public class EnemyController : SpaceShipControllerBase
    {
        private Animator _animator;

        public int Point = 100;

        IEnumerator Start()
        {
            _animator = GetComponent<Animator>();

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

            // Player の弾、Player 以外は何もしない
            if (layerName != "Bullet(Player)" && layerName != "Player") return;

            // Player弾のTransform を取得
            if (layerName == "Bullet(Player)")
            {
                var bulletTransform = collider.gameObject.transform.parent;
                var bullet = bulletTransform.GetComponent<BulletController>();
                HitPoint -= bullet.AttackPower;
            }

            // Playerの弾/Playerを削除
            Destroy(collider.gameObject);

            if (HitPoint <= 0)
            {
                // Score にポイント加算
                FindObjectOfType<ScoreController>().AddPoint(Point);

                // 爆発エフェクト
                base.Explosion(ExplosionObject);

                // 自分自身を削除
                Destroy(gameObject);
            }
            else
            {
                GetAnimator().SetTrigger("Damage");
            }
        }

        protected override Animator GetAnimator()
        {
            return _animator;
        }
    }
}
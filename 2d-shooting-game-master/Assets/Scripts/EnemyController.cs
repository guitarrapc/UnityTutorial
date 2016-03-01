using UnityEngine;
using System.Collections;
using System.Linq;
using System;

namespace Assets.Scripts
{

    public class EnemyController : MonoBehaviour
    {
        private SpaceShipController _spaceShipController;

        IEnumerator Start()
        {
            _spaceShipController = GetComponent<SpaceShipController>();

            // y軸 (up) のマイナス => 下に移動
            Move(transform.up * -1);

            // 弾を打たない属性の場合はここでコルーチンも終わり
            if (!_spaceShipController.CanShot) yield break;

            // 弾の発射
            while (true)
            {
                // 子要素となるShotPosition 要素数を取得 -> 子要素のTransformを取得
                foreach (var shotPosition in Enumerable.Range(0, transform.childCount).Select(index => transform.GetChild(index)))
                {
                    // 子要素のTranform と同じ位置、角度から発射
                    _spaceShipController.Shot(shotPosition);
                }
                yield return new WaitForSeconds(_spaceShipController.ShotInterval);
            }
        }

        private void Move(Vector2 direction)
        {
            GetComponent<Rigidbody2D>().velocity = direction * _spaceShipController.MoveSpeed;
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
                _spaceShipController.Explosion();

                // 自分自身を削除
                Destroy(gameObject);
            }
        }
    }
}
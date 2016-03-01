using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : SpaceShipControllerBase
    {
        void Awake()
        {
            Application.targetFrameRate = 60;
        }

        IEnumerator Start()
        {
            while (true)
            {
                // 弾を自機と同じ位置/角度で作成
                Shot(transform, BulletObject);

                // ショット音
                GetComponent<AudioSource>().Play();

                // ショット 待機時間
                yield return new WaitForSeconds(ShotInterval);
            }
        }

        void Update()
        {
            // Obtain where to move from Input. (Keyboard)
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");

            // Direction to move
            var direction = new Vector2(x, y).normalized;

            // Apply Direction and Speed
            // _spaceShipController.Move(direction);

            // velocity による移動から、transform.position に変更
            Move(direction);
        }

        protected override void Move(Vector2 direction)
        {
            // View Port の取得
            var min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            var max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            // Playerの現在位置取得
            Vector2 playerPosition = transform.position;

            // 移動量を position に追加
            playerPosition += direction * MoveSpeed * Time.deltaTime;

            // Player の位置を ViewPort 内に制限
            playerPosition.x = Mathf.Clamp(playerPosition.x, min.x, max.x);
            playerPosition.y = Mathf.Clamp(playerPosition.y, min.y, max.y);

            // 制限をかけた値を Player の位置と修正する
            transform.position = playerPosition;
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            // collider の Layer名取得
            var layerName = LayerMask.LayerToName(collider.gameObject.layer);

            if (layerName == "Bullet(Enemy)" || layerName == "Enemy")
            {
                // 敵の弾/敵を削除
                Destroy(collider.gameObject);

                // 爆発エフェクト
                base.Explosion(ExplosionObject);

                // 自分自身を削除
                Destroy(gameObject);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        private SpaceShipController _spaceShipController;

        IEnumerator Start()
        {
            _spaceShipController = GetComponent<SpaceShipController>();
            while (true)
            {
                // 弾を自機と同じ位置/角度で作成
                _spaceShipController.Shot(transform);
                yield return new WaitForSeconds(_spaceShipController.ShotInterval);
            }
        }

        void Awake()
        {
            Application.targetFrameRate = 60;
        }

        void Update()
        {
            // Obtain where to move from Input. (Keyboard)
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");

            // Direction to move
            var direction = new Vector2(x, y).normalized;

            // Apply Direction and Speed
            _spaceShipController.Move(direction);
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
                _spaceShipController.Explosion();

                // 自分自身を削除
                Destroy(gameObject);
            }
        }
    }
}
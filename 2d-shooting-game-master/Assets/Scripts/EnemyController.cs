using UnityEngine;
using System.Collections;
using System.Linq;

public class EnemyController : MonoBehaviour
{
    private SpaceShipController _spaceshipController;

    IEnumerator Start()
    {
        _spaceshipController = GetComponent<SpaceShipController>();

        // y軸 (up) のマイナス => 下に移動
        _spaceshipController.Move(transform.up * -1);

        // 弾を打たない属性の場合はここでコルーチンも終わり
        if (!_spaceshipController.CanShot) yield break;

        // 弾の発射
        while (true)
        {
            // 子要素となるShotPosition 要素数を取得 -> 子要素のTransformを取得
            foreach (var shotPosition in Enumerable.Range(0, transform.childCount).Select(index => transform.GetChild(index)))
            {
                // 子要素のTranform と同じ位置、角度から発射
                _spaceshipController.Shot(shotPosition);
            }
            yield return new WaitForSeconds(_spaceshipController.ShotInterval);
        }
    }
}

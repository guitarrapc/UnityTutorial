using UnityEngine;
using System.Collections;

public class BackGroundController : MonoBehaviour
{
    public float ScrollSpeed = 0.1f;

    void Update()
    {
        // 時間によって速度が変わって 1になると 0に戻る
        var y = Mathf.Repeat(Time.time * ScrollSpeed, 1);

        // y軸スクロールとして、ずらすオフセットを取得
        var offset = new Vector2(0, y);

        // マテリアルをオフセット分ずらす
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}

using UnityEngine;
using System.Collections;

public class WaveEmitter : MonoBehaviour
{
    public GameObject[] WavePrefab;
    private int _currentWave;

    IEnumerator Start()
    {
        if (WavePrefab.Length == 0) yield break;
        while (true)
        {
            // wave の作成
            //var wave = Instantiate(WavePrefab[_currentWave], transform.position, Quaternion.identity) as GameObject;
            var wave = Instantiate(WavePrefab[_currentWave], transform.position, Quaternion.identity) as GameObject;

            // 親の子要素にする
            wave.transform.parent = transform;

            // 子要素がなくなるのを待機
            while (wave.transform.childCount != 0)
            {
                yield return new WaitForEndOfFrame();
            }

            // Wave自体の削除
            Destroy(wave);

            // 子要素の wave を全て実行したら current wave を 0 にする
            if (WavePrefab.Length <= ++_currentWave) _currentWave = 0;
        }
    }
}

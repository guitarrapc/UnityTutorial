using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class WaveEmitController : MonoBehaviour
    {
        public GameObject[] WavePrefab;

        private int _currentWave;
        private GameManager _gameManager;

        IEnumerator Start()
        {
            if (WavePrefab.Length == 0) yield break;

            _gameManager = FindObjectOfType<GameManager>();

            while (true)
            {
                // タイトル表示中は待機
                while (_gameManager.IsPlaying() == false)
                {
                    yield return new WaitForEndOfFrame();
                }

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
}

using UnityEngine;

namespace Assets.Script
{
    public class FollowPlayerCamera : MonoBehaviour
    {
        public Transform TargetGameObject;
        private static Vector3 _offset;

        void Start()
        {
            // 自分自身と TargetGameObject の相対距離を算出
            _offset = GetComponent<Transform>().position - TargetGameObject.position;
        }

        void Update()
        {
            // TargetGameObject のポジションに自分のポジションを上書き -> FPS 風
            // GetComponent<Transform>().position = TargetGameObject.position;

            // 自分自身の座標に、TargetGameObject の座標 + 相対座標の値を設定 -> TPS 風 (相対距離分常に離れる)
            GetComponent<Transform>().position = TargetGameObject.position + _offset;
        }
    }
}
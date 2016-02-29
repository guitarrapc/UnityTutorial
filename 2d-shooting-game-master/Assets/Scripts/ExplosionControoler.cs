using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class ExplosionControoler : MonoBehaviour
    {
        void OnAnimationFinish()
        {
            Destroy(gameObject);
        }
    }
}
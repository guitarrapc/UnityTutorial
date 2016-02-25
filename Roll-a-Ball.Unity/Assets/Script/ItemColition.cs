using UnityEngine;

namespace Assets.Script
{
    public class ItemColition : MonoBehaviour
    {
        void OnTriggerEnter(Collider hit)
        {
            if (hit.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
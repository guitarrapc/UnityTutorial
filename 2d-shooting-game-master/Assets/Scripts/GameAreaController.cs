using UnityEngine;

namespace Assets.Scripts
{
    public class GameAreaController : MonoBehaviour
    {
        void OnTriggerExit2D(Collider2D collider)
        {
            Destroy(collider.gameObject);
        }
    }
}

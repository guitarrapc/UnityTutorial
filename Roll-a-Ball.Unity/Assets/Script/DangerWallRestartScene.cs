using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class DangerWallRestartScene : MonoBehaviour
    {
        void OnCollisionEnter(Collision hit)
        {
            if (hit.gameObject.CompareTag("Player"))
            {
                // Deprecated with Unity 5.3
                // Application.LoadLevel(Application.loadedLevel);

                // New from Unity 5.3!
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
            }
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotKeys : MonoBehaviour
{
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(0);
    }
}

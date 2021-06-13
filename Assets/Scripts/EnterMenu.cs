using UnityEngine.SceneManagement;
using UnityEngine;

public class EnterMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Menu");
        }
    }
}

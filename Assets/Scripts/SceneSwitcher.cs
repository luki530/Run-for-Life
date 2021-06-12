using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Run-for-life");
    }
    
    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("Options-Menu");
    }

    public void QuitGame () {
        Application.Quit ();
    }
}

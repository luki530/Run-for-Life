
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveMenu : MonoBehaviour
{
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Run-For-Life");
        }
    }
}

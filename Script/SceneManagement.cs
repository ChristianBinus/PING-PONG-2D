using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ChangeScene(string ChangeScene)
    {
        SceneManager.LoadScene(ChangeScene);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void LoadButton(string sceneName)
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

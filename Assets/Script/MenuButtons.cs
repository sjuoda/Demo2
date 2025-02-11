using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void LoadButton()
    {
        SceneManager.LoadScene("SampleScene")
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

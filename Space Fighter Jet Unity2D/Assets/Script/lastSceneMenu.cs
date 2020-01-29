using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lastSceneMenu : MonoBehaviour
{
    public Canvas thisCanvas;

    public void ResartBTN()
    {
        thisCanvas.enabled = false;
        SceneManager.LoadScene("lvl01");
    }

    public void MainMenuBTN()
    {
        thisCanvas.enabled = false;
        SceneManager.LoadScene(0);
    }

    public void ExitBTN()
    {
        thisCanvas.enabled = false;
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public Canvas thisCanvas;

    private void Start()
    {
        thisCanvas.enabled = false;
    }

    public void ResartBTN()
    {
        thisCanvas.enabled = false;
        SceneManager.LoadScene("lvl01");
    }

    public void ExitBTN()
    {
        thisCanvas.enabled = false;
        Application.Quit();
    }
}

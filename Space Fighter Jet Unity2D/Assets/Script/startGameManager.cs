﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGameManager : MonoBehaviour
{
    public Canvas thisCanvas;

    public void StartBTN()
    {
        thisCanvas.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitBTN()
    {
        thisCanvas.enabled = false;
        Application.Quit();
    }
}
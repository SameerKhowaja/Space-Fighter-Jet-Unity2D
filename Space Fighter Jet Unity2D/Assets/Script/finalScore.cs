using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public Text Finalscore;

    void Start()
    {
        Finalscore.text = PlayerPrefs.GetInt("current_Score", 0).ToString();
    }
    
}

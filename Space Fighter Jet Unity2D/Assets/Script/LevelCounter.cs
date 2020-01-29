using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    public Canvas waveCount_Canvas;

    void Start()
    {
        StartCoroutine(disableTXT());
    }

    IEnumerator disableTXT()
    {
        yield return new WaitForSeconds(0.5f);
        waveCount_Canvas.enabled = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireMissle : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject fire = Instantiate(firePrefab, firePoint.position, Quaternion.identity);
        }
    }
}

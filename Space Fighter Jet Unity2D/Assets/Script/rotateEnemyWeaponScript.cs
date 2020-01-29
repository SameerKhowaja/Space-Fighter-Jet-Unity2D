using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEnemyWeaponScript : MonoBehaviour
{
    public float speed = 180;

    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, speed * Time.fixedDeltaTime);   
    }
}

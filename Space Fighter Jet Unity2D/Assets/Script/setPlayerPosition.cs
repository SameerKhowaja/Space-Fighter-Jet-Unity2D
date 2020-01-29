using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPlayerPosition : MonoBehaviour
{
    public playerMovement playermovement;
    Vector3 newPos = new Vector3(0f, -6.59f, 0f);
    float Speed = 0.05f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, newPos, Speed);
        if(transform.position.y == newPos.y)
        {
            playermovement.enabled = true;
            this.enabled = false;
        }
    }
}

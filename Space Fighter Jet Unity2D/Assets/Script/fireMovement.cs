using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.up * Speed * Time.fixedDeltaTime);
    }

}

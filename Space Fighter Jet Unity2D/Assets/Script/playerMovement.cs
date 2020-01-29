using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    float xPos;

    public spawnBoss spawnboss;
    public Transform topGround;
    float playerSpeed = 0.15f;

    private void LateUpdate()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -8.5f, 8.5f);
        transform.position = playerPos;
    }

    private void Update()
    {
        if (spawnboss.checkBossDestroyed == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, topGround.transform.position, playerSpeed);
        }
    }

    private void FixedUpdate()
    {
        xPos = Input.GetAxisRaw("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * xPos * Speed * Time.fixedDeltaTime);
    }


}

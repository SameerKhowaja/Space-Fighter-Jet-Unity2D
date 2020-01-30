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

    //Vector3 touch_pos;

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

        /*For Mobile Inputs
        if (Input.touchCount > 0)
        {
            Touch touch1 = Input.GetTouch(0);
            touch_pos = Camera.main.ScreenToWorldPoint(touch1.position);
            touch_pos.z = 0;
            
        }
        */
    }

    private void FixedUpdate()
    {
        xPos = SimpleInput.GetAxisRaw("Horizontal");

        /*Mobile Touch Sensor
        if (touch_pos.x > 0 && Input.touchCount>0)
        {
            xPos = 1;
            rb.MovePosition(rb.position + Vector2.right * xPos * Speed * Time.fixedDeltaTime);
        }
        else if (touch_pos.x < 0 && Input.touchCount > 0)
        {
            xPos = -1;
            rb.MovePosition(rb.position + Vector2.right * xPos * Speed * Time.fixedDeltaTime);
        }
        else
        {
            xPos = 0;
            rb.MovePosition(rb.position + Vector2.right * xPos * Speed * Time.fixedDeltaTime);
        }
        */

        
        rb.MovePosition(rb.position + Vector2.right * xPos * Speed * Time.fixedDeltaTime);
        
    }
    
}

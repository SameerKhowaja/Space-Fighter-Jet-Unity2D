using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    public GameObject smallBlast;
    public Rigidbody2D rb;
    float RandomGravity;

    public float min_RandomGravity, max_RandomGravity;

    private void Update()
    {
        RandomGravity = Random.Range(min_RandomGravity, max_RandomGravity);
        rb.gravityScale = RandomGravity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Missle")
        {
            Destroy(gameObject);
        }

        if (collision.collider.tag == "Ground" || collision.collider.tag == "Player")
        {
            GameObject blast = Instantiate(smallBlast, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(blast, 0.5f);
        }
    }
}

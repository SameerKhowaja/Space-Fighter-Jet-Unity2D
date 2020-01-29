using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBossWeapon : MonoBehaviour
{
    public GameObject mediumBlast;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            GameObject blast = Instantiate(mediumBlast, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(blast, 0.5f);
        }

        if (collision.collider.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMissle : MonoBehaviour
{
    public GameObject smallBlast;

    void Start()
    {
        Destroy(gameObject, 1.35f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            GameObject blast = Instantiate(smallBlast, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(blast, 1f);
        }

        if(collision.collider.tag == "EnemyWeapon")
        {
            Destroy(gameObject);
        }
    }
}

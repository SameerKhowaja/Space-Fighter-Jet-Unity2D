using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    float Speed;

    public Transform Player;
    Vector2 destPos;

    public float min_Speed, max_Speed;

    private void Start()
    {
        Player = GameObject.Find("Player").transform;
        destPos = Player.position;
        Speed = Random.Range(min_Speed, max_Speed);
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, destPos, Speed);

        if(transform.position.y == destPos.y)
        {
            Destroy(gameObject);
        }
    }
}

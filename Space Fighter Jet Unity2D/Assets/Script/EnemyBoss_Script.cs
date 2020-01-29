using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBoss_Script : MonoBehaviour
{
    Vector3 newPos = new Vector3(0f, 5.5f, 0f);
    float Speed = 0.05f;

    public float BossHealth;
    public GameObject bigBlast;

    public Transform Player;

    public Rigidbody2D rb;
    public Transform firePos;

    public GameObject[] BossWeapons;

    public float shootTime, shootGap;

    public Slider healthSlider;

    public float min_shootTime, max_shootTime;

    private void Start()
    {
        healthSlider.maxValue = BossHealth;
        healthSlider.value = BossHealth;
        Player = GameObject.Find("Player").transform;
        //Debug.Log(Player.transform.position);
    }

    void Update()
    {
        //move to position
        transform.position = Vector2.MoveTowards(transform.position, newPos, Speed);

        if(transform.position == newPos)
        {
            //For Angle Changing
            Player = GameObject.Find("Player").transform;
            Vector2 lookDir = Player.transform.position - transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
            rb.rotation = angle;
        }

        //Fire
        shootTime -= Time.deltaTime;
        if (shootTime <= 0)
        {
            int RandonWeapon = Random.Range(0, 2);
            Instantiate(BossWeapons[RandonWeapon], firePos.position, Quaternion.identity);

            shootGap = Random.Range(min_shootTime, max_shootTime);
            shootTime = shootGap;
        }

        if(BossHealth <= 0f)
        {
            GameObject blast = Instantiate(bigBlast, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.3f);
            Destroy(blast, 2.2f);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Missle")
        {
            BossHealth -= 10f;
            healthSlider.value -= 10f;
        }
    }

}
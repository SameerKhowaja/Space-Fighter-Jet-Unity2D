using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBoss : MonoBehaviour
{
    public Transform BossPoint;
    public GameObject bossPrefab;

    GameObject Boss;
    public bool checkBossDestroyed;
    bool check;

    public fireMissle playerFireMissile;
    public BossArrivalTime bossTimeReset;
    public spawnEnemies spawnEnemiesAgain;

    private void Start()
    {
        checkBossDestroyed = true;
        check = true;

        playerFireMissile.enabled = false;
        Boss = Instantiate(bossPrefab, BossPoint.position, Quaternion.identity);
        StartCoroutine(enableFireAgain());
    }

    private void Update()
    {
        if (Boss == null && checkBossDestroyed == true && check == true)
        {
            check = false;
            StartCoroutine(resetor());
        }
    }

    IEnumerator enableFireAgain()
    {
        yield return new WaitForSeconds(3.3f);
        playerFireMissile.enabled = true;
    }

    IEnumerator resetor()
    {
        Debug.Log("Boss Destroyed");

        yield return new WaitForSeconds(2f);

        checkBossDestroyed = false;
    }
}

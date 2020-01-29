using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] enemy;
    public GameObject[] EnemyMissle;

    public float startTime;
    public float wavesTime;

    int randomEnemy, randomMissle;
    int MissleYesNo;
    int RandomPositionOUT1, RandomPositionOUT2, RandomPositionOUT3;

    void Update()
    {
        if (Time.time > startTime)
        {
            SpawnEnemy();
            startTime = Time.time + wavesTime;
        }

    }


    void SpawnEnemy()
    {
        RandomPositionOUT1 = Random.Range(0, points.Length);
        RandomPositionOUT2 = Random.Range(0, points.Length);
        RandomPositionOUT3 = Random.Range(0, points.Length);

        for (int i = 0; i < points.Length; i++)
        {
            if (i != RandomPositionOUT1 && i != RandomPositionOUT2 && i != RandomPositionOUT3)
            {
                randomEnemy = Random.Range(0, enemy.Length);
                Instantiate(enemy[randomEnemy], points[i].position, Quaternion.identity);
            }
            else
            {
                MissleYesNo = Random.Range(0, 2);
                if(MissleYesNo == 1)
                {
                    randomMissle = Random.Range(0, 2);
                    Instantiate(EnemyMissle[randomMissle], points[i].position, Quaternion.identity);
                }
            }
        }
    }


}

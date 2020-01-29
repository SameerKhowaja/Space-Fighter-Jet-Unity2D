using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossArrivalTime : MonoBehaviour
{
    public spawnEnemies spawn_enemies;
    public spawnBoss spawn_boss;

    public float BossTime;

    public Slider BossTimeSlider;
    public Canvas BossTime_Canvas;
    public Text BossComingTXT;

    private void Start()
    {
        BossTime_Canvas.enabled = true;
        BossTimeSlider.maxValue = BossTime;
        BossTimeSlider.value = BossTime;
    }

    void Update()
    {
        if (BossTime > 0)
        {
            BossTime -= Time.deltaTime / 2;
            BossTimeSlider.value = BossTime;
        }

        if(BossTime <= 0)
        {
            spawn_enemies.enabled = false;
            StartCoroutine(wait1());
        }

        if(BossTimeSlider.value <= 0)
        {
            BossTimeSlider.enabled = false;
            BossComingTXT.enabled = true;
        }

    }

    IEnumerator wait1()
    {
        yield return new WaitForSeconds(5f);
        BossTime_Canvas.enabled = false;
        spawn_boss.enabled = true;
    }

}

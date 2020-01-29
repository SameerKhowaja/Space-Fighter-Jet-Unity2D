using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealthControl : MonoBehaviour
{
    static public int playerHealth = 3;

    public Image h1, h2, h3;
    public Canvas endGame_Canvas;

    public fireMissle fm;
    public playerMovement pm;
    public spawnEnemies se;
    public spawnBoss sb;
    public BossArrivalTime bat;

    public Canvas HeartCanvas;

    public bool hitCheck;
    public bool gameover;

    private void Start()
    {
        HeartHealth();
    }

    void Update()
    {
        if(playerHealth <= 0)
        {
            hitCheck = true;
            gameover = true;
            //Game End
            endGame_Canvas.enabled = true;
            HeartCanvas.enabled = false;
            disablingScripts();

            playerHealth = 3;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.collider.tag == "Enemy" || collision.collider.tag == "EnemyWeapon") && hitCheck == false)
        {
            playerHealth -= 1;
            HeartHealth();
        }
    }

    void HeartHealth()
    {
        if (playerHealth == 3)
        {
            h1.enabled = h2.enabled = h3.enabled = true;
        }
        else if (playerHealth == 2)
        {
            h1.enabled = h2.enabled = true;
            h3.enabled = false;
        }
        else if (playerHealth == 1)
        {
            h1.enabled = true;
            h3.enabled = h2.enabled = false;
        }
        else
        {
            h1.enabled = h2.enabled = h3.enabled = false;
        }
    }

    void disablingScripts()
    {
        bat.enabled = fm.enabled = pm.enabled = se.enabled = sb.enabled = false;
    }
}

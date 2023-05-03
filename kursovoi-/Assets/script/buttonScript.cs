using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
   
    public void dubbleFire()
    {
        GameObject.Find("Canvas").SetActive(false);
        fire.bulletCount += 1;

    }
    public void recuveryFaster()
    {
        GameObject.Find("Canvas").SetActive(false);
        fire.startTime -= 1f;
    }

    public void bonusDamage()
    {
        GameObject.Find("Canvas").SetActive(false);
        bulletDirection.damage += 3;
    }

    public void moveSpeed()
    {
        GameObject.Find("Canvas").SetActive(false);
        move_character.speed += 200;
    }

   
    public void tripleShot()
    {
        GameObject.Find("Canvas").SetActive(false);
        fire.countGun = 3;
    }
    public void healthBones()
    {
        GameObject.Find("Canvas").SetActive(false);
        Player_health.curentHealth += 3;
    }
}

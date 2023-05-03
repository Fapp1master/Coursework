using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_health : MonoBehaviour
{
    public int damage = 3;
     static public int curentHealth = 10 , maxHealth = 10;
    public float force;

    private void Start()
    {
        

    }
    private void Update()
    {


        if (curentHealth <= 0)
        {
            
            SceneManager.LoadScene(2);
            
            curentHealth = 10;
            spawnerEnemy.WorldTimer = 0;
            fire.countGun = 1;
            deathEnemy.health = 2;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeToDamage(damage);
            
        }
    }
    private void TakeToDamage(int damage)
    {
        curentHealth -= damage;
    }
}

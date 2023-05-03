using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathEnemy : MonoBehaviour
{
    static public int health = 2;
    private int curentHealth;
    static public int damage = 1;
    public GameObject effectDeath;
    void Start()
    {
        curentHealth = health;
    }

    void Update()
    {
        if (curentHealth <= 0)
        {
            Debug.Log("Enemy death");
            Destroy(gameObject);
            Instantiate(effectDeath, transform.position, Quaternion.identity);
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(effectDeath, transform.position, Quaternion.identity);
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log(curentHealth);
            curentHealth -= damage;
        }
    }

}

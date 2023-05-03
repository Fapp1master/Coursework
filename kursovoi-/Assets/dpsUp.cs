using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dpsUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deathEnemy.damage += 2;
            Destroy(gameObject);
        }
    }
}

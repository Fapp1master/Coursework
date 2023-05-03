using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemy : MonoBehaviour
{

    public Transform point;
    public GameObject enemy;
    private int Uptime = 5;
    private float timer , startTime = 5;
    static public float WorldTimer = 0;
    private void Start()
    {
        timer = startTime;
    }
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        WorldTimer += 1;
        if (timer <= 0)
        {
            Instantiate(enemy, point.transform.position, Quaternion.identity);

            timer = startTime;
        }
    }

}

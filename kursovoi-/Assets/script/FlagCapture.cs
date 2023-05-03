using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCapture : MonoBehaviour
{
    private float startCapture = 0, finalCapture = 4 , capture;
    public SpriteRenderer sprite;


    private void Start()
    {
        capture = startCapture;
    }
    private void Update()
    {
        
        
        
        if (capture >= finalCapture)
        {
            sprite.color = Color.green;
            fire.countGun += 1;
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            capture += 0.01f;
        }
    }

}

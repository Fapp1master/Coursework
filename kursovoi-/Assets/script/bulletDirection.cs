using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDirection : MonoBehaviour
{
    public float speed;
    public float distance;
   static public int damage = 1;

    public GameObject effectsHit;
    
    private void Start()
    {

    }
    private void Update()
    {
      
        StartCoroutine(CoroutineSample());
        transform.Translate(Vector2.up * speed * Time.deltaTime);


        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.gameObject.tag == "Enemy")
        {
           
            Destroy(gameObject);
            Instantiate(effectsHit, transform.position, Quaternion.identity);
        }
    }

    private IEnumerator CoroutineSample()
    {
        yield return new WaitForSeconds(5);
        
        Destroy(gameObject);
    }
}

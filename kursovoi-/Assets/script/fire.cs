using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float offset;
    private  float time ;
    static public float startTime = 0.5f;
    private float rotateZ;
     
    static public  int countGun = 1;
    static public float bulletCount ;
    private float startBulletCount;
    public GameObject bullet , gun2, gun1;
    public Transform point , point2 , point3;

    public Joystick joystick;

    private void Update()
    {
        
        if (countGun == 1)
        {
            gun1.SetActive(true);
            gun2.SetActive(false);
        }
        else if (countGun == 2)
        {
            
            gun1.SetActive(false);
            gun2.SetActive(true);
        }
        else if (countGun == 3)
        {
            gun1.SetActive(true);
            gun2.SetActive(true);
        }
        rotateZ = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
        
            if (time <= 0f)
            {
            
                if (joystick.Horizontal > 0 || joystick.Horizontal < 0 || joystick.Vertical > 0 || joystick.Vertical < 0)
                {

                        if (countGun == 1)
                        {
                            
                            Instantiate(bullet, point.position, transform.rotation);
                            
                        }
                        else if(countGun == 2)
                        {
                            
                            Instantiate(bullet, point2.position, transform.rotation);
                            Instantiate(bullet, point3.position, transform.rotation);
                        }
                        else if (countGun == 3)
                        {
                            
                            Instantiate(bullet, point.position, transform.rotation);
                            Instantiate(bullet, point2.position, transform.rotation);
                            Instantiate(bullet, point3.position, transform.rotation);
                        }

                if (startBulletCount >0)
                    {
                        time = 0.5f;
                    startBulletCount -= 1;

                    }
                    else
                    { 
                        time = startTime;
                    startBulletCount = bulletCount;
                    }
                }
           
        }
            else
            {
                time -= Time.deltaTime;
            }
        

    }
}

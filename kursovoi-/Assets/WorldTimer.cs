using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldTimer : MonoBehaviour
{
    public Text text;
    
    private void Update()
    {
        text.text = spawnerEnemy.WorldTimer.ToString();
        if (spawnerEnemy.WorldTimer == 10000)
        {
            deathEnemy.health += 2;
            
        }
       else  if (spawnerEnemy.WorldTimer == 30000)
        {
            deathEnemy.health += 2;
        }
       else  if (spawnerEnemy.WorldTimer == 50000)
        {
            deathEnemy.health += 2;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBar : MonoBehaviour
{
    private float currentHealth;
    public Slider slider;
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = Player_health.maxHealth;
    }

   
    void Update()
    {
        currentHealth = Player_health.curentHealth;
        slider.value = currentHealth;
    }
}

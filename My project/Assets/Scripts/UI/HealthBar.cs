using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void HealthSet(int health)
    {
        if (health <= 0)
        {
            slider.value = 0;
        }
        slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}

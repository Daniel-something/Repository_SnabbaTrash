using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Script gjord av Michal
public class HealthBar : MonoBehaviour
{

    public Slider slider; // S� att man har en slider som g�r s� att "livet" kan s�nkas ner gradvis (just nu �r det p� max 4)

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; // maximalt liv
        slider.value = health; // startar p� maximalt livet
    }
    public void SetHealth(int health)
    {
        slider.value = health; // slider till livet
    }
}

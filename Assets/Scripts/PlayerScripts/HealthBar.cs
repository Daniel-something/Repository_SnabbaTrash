using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Script gjord av Michal
public class HealthBar : MonoBehaviour
{

    public Slider slider; // Så att man har en slider som gör så att "livet" kan sänkas ner gradvis (just nu är det på max 4)

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; // maximalt liv
        slider.value = health; // startar på maximalt livet
    }
    public void SetHealth(int health)
    {
        slider.value = health; // slider till livet
    }
}

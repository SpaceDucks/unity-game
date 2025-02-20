using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // used to interact with the health bar (graphic)

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public Slider slider; 
    public Gradient gradient;
    public Image fill;
    private Vector3 scaleChange, positionChange;
    public HealthBarScale healthBarScale1;
    public PlayerScript playerScript;
    

    void start() {
        slider.value = 100; //sets the health bar to that value
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; //sets health bar's max to maxHealth 
        
        fill.color = gradient.Evaluate(1f); //allows the health bar to go from green to yellow to red
    }

    public void SetHealth(int health)
    {
        slider.value = health; //changes health bar's value to new health value

        fill.color = gradient.Evaluate(slider.normalizedValue); // updates the color of the health bar
    }
}
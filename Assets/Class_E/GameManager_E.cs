using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add namespace for TextMeshPro
using TMPro;

public class GameManager_E : MonoBehaviour
{
    public static GameManager_E instance;
    public int health;

    // Have reference to the text box to update Health
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        // keep a reference of ourselves
        instance = this;

        // start with how much health
        health = 1;

        // Display health onto screen
        healthText.text = "health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // A function to add health
    public void AddHealth(int healthToAdd)
    {
        health += healthToAdd;
        print("Health: " + health);
        healthText.text = "health: " + health;
    }
}

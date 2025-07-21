using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPond : MonoBehaviour
{
    public float healingRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When player is standing inside the pond //
    private void OnTriggerStay(Collider other)
    {
        // make sure its player inside the pond //
        GameManager_F.instance.AddHealth(healingRate * Time.deltaTime);
    }

    // When player is enters the pond //
    private void OnTriggerEnter(Collider other)
    {
        // Start healing BGM //
        GameManager_F.instance.PlayBGMHealing();
    }

    // When player is exits the pond //
    private void OnTriggerExit(Collider other)
    {
        // Stop Healing BGM //
        GameManager_F.instance.PlayBGM1();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Detect player entering the area //
    private void OnTriggerEnter(Collider other)
    {
        // Make sure the PLAYER is in the trigger box //
        if (other.gameObject.tag.Equals("Player")) 
        {
            print("Player inside");
            GameManager_F.instance.PlayBGM2();   // Change to BGM2 
        }
    }

    // Detect player exiting the area //
    private void OnTriggerExit(Collider other)
    {
        // Make sure the PLAYER is exit the trigger box //
        if (other.gameObject.tag.Equals("Player"))
        {
            print("Player outside");
            GameManager_F.instance.PlayBGM1();  // Change to BGM1 
        }
    }
}

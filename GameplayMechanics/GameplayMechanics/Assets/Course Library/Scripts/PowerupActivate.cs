using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupActivate : MonoBehaviour
{
    // Variables
    private bool PowerupActive;

    // Start is called before the first frame update
    void Start()
    {
        PowerupActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("Player"))
        {
            PowerupActive = true;
        }
    }
}

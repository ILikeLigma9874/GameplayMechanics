using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    // Variables
    public GameObject Powerup;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 5.0f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Spawn()
    {
        Instantiate(Powerup, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Powerup.transform.rotation);
    }
}

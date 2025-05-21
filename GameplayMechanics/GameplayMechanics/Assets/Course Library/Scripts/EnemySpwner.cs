using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemySpwner : MonoBehaviour
{
    public GameObject Enemy;
    private float Difficulty;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemySpwner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public float Difficulty;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<EnemySpwner>().enabled = true;
        Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
        InvokeRepeating("RaiseDifficulty", 3.0f, 1.5f);
        InvokeRepeating("Spawn", 2.0f, Difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
            GetComponent<EnemySpwner>().enabled = false;
    }

    public void Spawn()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
    }

    private void RaiseDifficulty()
    {
        Difficulty -= (int)0.5;
    }
}

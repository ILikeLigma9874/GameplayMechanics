using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float Speed;
    Rigidbody enemyRb;
    private GameObject Player;
    private GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (int)-2.03)
            enemyRb.AddForce((Player.transform.position - transform.position).normalized * Speed);
        if (transform.position.y == (int)-3.5)
            Destroy(Enemy);
    }
}
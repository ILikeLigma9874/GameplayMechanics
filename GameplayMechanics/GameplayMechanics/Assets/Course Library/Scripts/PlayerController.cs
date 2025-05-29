using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    Rigidbody playerRb;
    public GameObject FocalPoint;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Powerup;
    public PhysicMaterial Normal;
    public PhysicMaterial Powerful;
    public SphereCollider col;
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float forwardinput = Input.GetAxis("Vertical");
        if (transform.position.y > (int)-2.03)
            playerRb.AddForce(FocalPoint.transform.forward * forwardinput * Speed);
        if (transform.position.y < (int)-20.5)
            Destroy(gameObject);
        if (Timer <= 7.5f && Timer > 0.0f)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0.0f)
            {
                col.material = Normal;
            }
        }
    }


    public void PowerUp()
    {
        col.material = Powerful;
        Timer = 7.5f;
    }
}

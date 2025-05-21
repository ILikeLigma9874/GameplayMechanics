using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    Rigidbody playerRb;
    public GameObject FocalPoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardinput = Input.GetAxis("Vertical");
        if (transform.position.y > (int)-2.03)
            playerRb.AddForce(FocalPoint.transform.forward * forwardinput * Speed);
        if (transform.position.y < (int)-20.5)
            Destroy(gameObject);
    }
}

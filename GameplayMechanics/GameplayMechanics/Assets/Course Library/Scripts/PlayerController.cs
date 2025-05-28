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
    private bool Powered;
    public GameObject Enemy;
    public GameObject Powerup;
    public PhysicMaterial Normal;
    public PhysicMaterial Powerful;

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
        if (Powered == false)
        {
            collision.material = Normal;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Powerup)
        {
            if (collision.gameObject == Enemy)
            {
                StartCoroutine(PoweredHit((int)0.15f));
            }
            
        }
    }


    IEnumerator PoweredHit(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log(Speed = (int)3.75);
    }
}

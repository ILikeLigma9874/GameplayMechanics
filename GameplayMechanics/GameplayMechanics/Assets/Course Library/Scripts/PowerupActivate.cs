using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PowerupActivate : MonoBehaviour
{
    // Variables
    public bool PowerupActive;
    private bool DESTROY;
    private float Speed = 999999999999999;

    // Start is called before the first frame update
    void Start()
    {
        PowerupActive = false;
        DESTROY = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DESTROY == true)
        {
            DESTROY = false;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
            PowerupActive = true;
            StartCoroutine(PowerupActivated(5.0f));
            StartCoroutine(Destroy(5.0f));
            InvokeRepeating("Disappear", 0.0f, 0.0f);
    }


    IEnumerator PowerupActivated(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log(PowerupActive = false);
    }


    IEnumerator Destroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log(DESTROY = true);
    }


    void Disappear()
    {
        transform.Translate(Vector3.down * Speed);
    }
}

using UnityEngine;

public class PowerupActivate : MonoBehaviour
{
    // Variables
    public PlayerController controller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision Spherecollision)
    {
        controller.PowerUp();
        Destroy(gameObject);
    }
}

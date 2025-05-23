using UnityEngine;

public class EnemySpwner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public float Difficulty;
    private int Spawnamount;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<EnemySpwner>().enabled = true;
        InvokeRepeating("Spawn", 5.0f, 7.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
            GetComponent<EnemySpwner>().enabled = false;
    }

    public void Spawn()
    {
            Spawnamount = Random.Range(1, 5);
            if (Spawnamount >= 1 && Spawnamount <= 2)
            {
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
            }
            if (Spawnamount >= 3 && Spawnamount <= 4)
            {
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
            }
            if (Spawnamount == 5)
            {
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
                Instantiate(Enemy, new Vector3(Random.Range(-12, 12), 0, Random.Range(-10, 10)), Enemy.transform.rotation);
        }
    }

        }

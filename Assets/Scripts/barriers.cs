using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMove : MonoBehaviour
{
    //private Rigidbody rb;
    public GameObject Player;

    public int minSpeed;
    public int maxSpeed;

    void Start()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        var rb = GetComponent<Rigidbody>();

        if (transform.position.z < -10 || transform.position.z == 1)
        {
            rb.velocity = RandomVector(minSpeed, maxSpeed);
        }

        else if (transform.position.z >= 10 || transform.position.z == 0)
        {
            rb.velocity = RandomVector(-minSpeed, -maxSpeed);
        }
        yield return new WaitForSeconds(0.5f);
    }

    private Vector3 RandomVector(float min, float max)
    {
        var z = Random.Range(min, max);
        return new Vector3(0f, 0f, z);
    }

    /*private void OnTriggerEnter(Collider other)
    { // Destroy Player, End Game 
        if (other.gameObject == Player)
        {
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
    }*/

}

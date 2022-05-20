using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public void OnTriggerEnter(Collider Col)
    {

        if (Col.GetComponent<Collider>().tag == "barrier")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game Over");
        }

        if (Col.GetComponent<Collider>().tag == "Endline")
        {

            SceneManager.LoadScene("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        Debug.Log("Space Key was pressed down!");
             GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        }
         if (Input.GetKeyDown(KeyCode.RightArrow))
         {
        Debug.Log("right Key was pressed down!");
             GetComponent<Rigidbody>().AddForce(Vector3.right * 5, ForceMode.VelocityChange);
         }
         if (Input.GetKeyDown(KeyCode.LeftArrow))
          {
        Debug.Log("left Key was pressed down!");
              GetComponent<Rigidbody>().AddForce(Vector3.left * 5, ForceMode.VelocityChange);
          }
        
    }

}

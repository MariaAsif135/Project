using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotater : MonoBehaviour
{
    private bool pickUpAllowed;
    public AudioSource coinSound;

	
	// Update is called once per frame
	private void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        PickUp();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit(Collider collision)
    {
        if(collision.tag == "Player")
        {
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {   
        coinSound.Play();
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class coin_rotate : MonoBehaviour
{
    public int coin;
    void Start()
    {

    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "coins")
        {

            //Debug.Log("Coin Collected");
            Col.gameObject.SetActive(false);
            coin = coin + 1;


        }

    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 0, 45) );
    }
}

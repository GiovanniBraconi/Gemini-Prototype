using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private float xBound = 19f;
    private float yBound = 9f;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    
    private void ScreenBounds()
    {
        if (transform.position.x < -xBound)
        {

            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);


        }
        if  (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);

        }
        if  (transform.position.y > yBound)
        {
            transform.position = new Vector3(transform.position.x, yBound, transform.position.z);

        }
        if  (transform.position.y < -yBound)
        {
            transform.position = new Vector3(transform.position.x, -yBound, transform.position.z);

        }
    }
    private void Bond()
    {
        
        player1.transform.position = player1.transform.position + (player2.transform.position - player1.transform.position).normalized * 20;
    }

        // Update is called once per frame
        void Update()
        {
            ScreenBounds();
        }
    
}


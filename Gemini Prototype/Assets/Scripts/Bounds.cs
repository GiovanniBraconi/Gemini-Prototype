using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private float xBound = 19f;
    private float yBound = 9f;
    private float maxRadius = 15f;
    private float minRadius = 3f;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;



    private void ScreenBounds()
    {
        if (transform.position.x < -xBound)
        {

            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);


        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);

        }
        if (transform.position.y > yBound)
        {
            transform.position = new Vector3(transform.position.x, yBound, transform.position.z);

        }
        if (transform.position.y < -yBound)
        {
            transform.position = new Vector3(transform.position.x, -yBound, transform.position.z);

        }
    }


    private void Radiuses()
    {


        Vector3 centerPosition1 = player2.transform.position; 
        Vector3 centerPosition2 = player1.transform.position;
        float distance = Vector3.Distance(centerPosition2, centerPosition1); 

        if (distance > maxRadius) 
        {
            Vector3 fromOriginToObject1 = centerPosition2 - centerPosition1; 
            Vector3 fromOriginToObject2 = centerPosition1 - centerPosition2;
            fromOriginToObject1 *= maxRadius / distance; 
            fromOriginToObject2 *= maxRadius / distance;
            player1.transform.position = centerPosition1 + fromOriginToObject1; 
            player2.transform.position = centerPosition2 + fromOriginToObject2;
        }
        if (distance < minRadius)
        {
            Vector3 fromOriginToObject1 = centerPosition2 - centerPosition1; 
            Vector3 fromOriginToObject2 = centerPosition1 - centerPosition2;
            fromOriginToObject1 *= minRadius / distance; 
            fromOriginToObject2 *= minRadius / distance;
            player1.transform.position = centerPosition1 + fromOriginToObject1;
            player2.transform.position = centerPosition2 + fromOriginToObject2;
        }
    }
    
    

        
        void Update()
        {
            ScreenBounds();
            Radiuses();
        }
    
}


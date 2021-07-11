using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private float xBound = 19f;
    private float yBound = 9f;
    private void ScreenBounds()
    {
        if (transform.position.x < -xBound)
        {

            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);


        }
        else if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);

        }
        else if (transform.position.y > yBound)
        {
            transform.position = new Vector3(transform.position.x, yBound, transform.position.z);

        }
        else if (transform.position.y < -yBound)
        {
            transform.position = new Vector3(transform.position.x, -yBound, transform.position.z);

        }
    }

        // Update is called once per frame
        void Update()
        {
            ScreenBounds();
        }
    }


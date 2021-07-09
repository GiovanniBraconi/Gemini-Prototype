using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }
    
    public void EnergyBeam()
    {
        if (Input.GetKey(KeyCode.E))
        {
            lr.enabled = true;
        lr.SetPosition(0, startPoint.position);
        lr.SetPosition(1, endPoint.position);
        }
        else
        {
            lr.enabled = false;
        }


    }

    // Update is called once per frame
    void Update()
    {

        EnergyBeam();
    }

            
}

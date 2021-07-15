using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    
   
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }
    
    public void BlueEnergyBeam()
    {
        
            lr.startColor = Color.blue;
            lr.endColor = Color.blue;
            lr.enabled = true;
        lr.SetPosition(0, startPoint.position);
        lr.SetPosition(1, endPoint.position);
        

       

    }
    public void RedEnergyBeam()
    {
       
            lr.startColor = Color.red;
            lr.endColor = Color.red;
            lr.enabled = true;
            lr.SetPosition(0, startPoint.position);
            lr.SetPosition(1, endPoint.position);
        
       


    }
    public void MagentaEnergyBeam()
    {
        
            lr.startColor = Color.magenta;
            lr.endColor = Color.magenta;
            lr.enabled = true;
            lr.SetPosition(0, startPoint.position);
            lr.SetPosition(1, endPoint.position);
        
        


    }



   
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.E))
        {
        BlueEnergyBeam();
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            RedEnergyBeam();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            MagentaEnergyBeam();
        }
        else
        {
            lr.enabled = false;
        }
        
    }

}
       
        

        


            

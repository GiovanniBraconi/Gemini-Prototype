using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
   
   
    private void Alignment()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
        

    }
  
    void Update()
    {
        Alignment();
    }
}

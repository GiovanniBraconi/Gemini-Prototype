using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    // Start is called before the first frame update
   
    private void Alignment()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
        

    }
    // Update is called once per frame
    void Update()
    {
        Alignment();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public GameObject pivotObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(pivotObject.transform.position, new Vector3(0,0,1), rotationSpeed*Time.deltaTime);
        //transform.RotateAroundLocal(new Vector3 )
        transform.Rotate(new Vector3(0,0,1), Space.Self);
        }
}

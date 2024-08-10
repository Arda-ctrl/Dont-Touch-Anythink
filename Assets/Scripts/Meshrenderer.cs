using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshrenderer : MonoBehaviour
{
    MeshRenderer rendererr;
    Rigidbody myRigidBody;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        rendererr = GetComponent<MeshRenderer>();
        rendererr.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(Time.time > 3)
        {
            rendererr.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}

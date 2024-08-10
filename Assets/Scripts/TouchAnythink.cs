using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAnythink : MonoBehaviour
{
    int hits = 0;
    int count = 0;

    private void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.tag == "player")
       {
        GetComponent<MeshRenderer>().material.color = Color.red;
        
        if(count<1)
        {   
            hits++;
        Debug.Log("Hit Count : "+hits);
        }
        count++;
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assignment20_1{
public class Assignment_20: MonoBehaviour
{  
     public float x = 0.01f;
     public float z = 0.01f;
     public float speed=1f;
 
    void Start()
    {
        
    }

  
    void Update()
    {
         
        if (Input.GetKey(KeyCode.RightArrow))
        {
               transform.position += new Vector3(x,0,0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
             transform.position -= new Vector3(x,0,0);
        }
         if (Input.GetKey(KeyCode.UpArrow))
        {
               transform.position += new Vector3(0,0,z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
             transform.position -= new Vector3(0,0,z);
        }
      
    }
}
}
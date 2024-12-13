using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_25{
public class cameracontroller : MonoBehaviour
{
   public Transform target;
    public float rotateSpeed = 50f;

    void Start()
    {
        
    }

    
    void Update()
    {
            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
            transform.RotateAround(target.position, Vector3.up, horizontal);
        }
}
}
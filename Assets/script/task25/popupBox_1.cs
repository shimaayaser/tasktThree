using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_25{
public class popupBox_1 : MonoBehaviour
{
    
  
    float x, y, z = 0f;
    float bookRotationSensitivity = 2000.0f;
    float zAngle = 0.0f;
    public GameObject hiddenObject; 
    public GameObject hiddenObject_1;
    public float revealSpeed =1f;
    private Vector3 targetScale; 
    private Vector3 targetScale_1;
    void Start()
    {
      targetScale = hiddenObject.transform.localScale;
     hiddenObject.transform.localScale = Vector3.zero;
     targetScale_1 = hiddenObject_1.transform.localScale;
     hiddenObject_1.transform.localScale = Vector3.zero;
    }

   
    void Update()
    {
         if (Input.GetMouseButton(0))
        {
            zAngle -= Input.GetAxis("Mouse X") * bookRotationSensitivity * Time.deltaTime;
            zAngle = Mathf.Clamp(zAngle, -180, 0);
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
            hiddenObject.transform.localScale = Vector3.Lerp(hiddenObject.transform.localScale,targetScale,revealSpeed * Time.deltaTime);
            hiddenObject_1.transform.localScale = Vector3.Lerp(hiddenObject_1.transform.localScale,targetScale_1,revealSpeed * Time.deltaTime);
        }
        
        
    }
}
}
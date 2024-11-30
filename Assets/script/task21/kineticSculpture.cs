using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment21{
public class kineticSculpture : MonoBehaviour
{
    
    public GameObject[] cubes;
    void Start(){
        
    }
    
    void Update()
    {
        foreach(GameObject cube in cubes){
          float yNew = Mathf.Sin(Time.time*0.025f);
          cube.transform.rotation = Quaternion.Euler(new Vector3(0,yNew *360f, 0));
        } 
        
      
    }
}
}
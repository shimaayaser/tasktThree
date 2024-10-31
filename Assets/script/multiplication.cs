using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplication : MonoBehaviour
{
    void Start()
    {
        int num=5;
        for(int i=1;i<=10;i++){
            int result=multiplyNumber(num,i);
            Debug.Log(num+"*"+ i+"="+ result);
        }
    }
    int multiplyNumber (int x ,int z){
        int multiply=x*z;
        return multiply;
    }

   
}

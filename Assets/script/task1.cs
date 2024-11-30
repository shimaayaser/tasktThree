using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
    // 2024
    // Start is called before the first frame update
    void Start()
    {

        int count=0;
        while(count<=10){
            int num=Random.Range(1,21);
            Debug.Log(num);
            if(num==5){
                Debug.Log("skip the number");
                continue;
            }
            if(num==15){
                Debug.Log("finish the loop");
                break;
                }
            count++;
            }

    }

}

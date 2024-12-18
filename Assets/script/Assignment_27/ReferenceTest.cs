using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
public class ReferenceTest : MonoBehaviour
{

    void Start()
    {
        int a=6;
        int b=4;
        int newNum;

        Debug.Log($"The number before call num method:{a}");
        Num(a);
        Debug.Log($"The number after call num method:{a}");
        
        Debug.Log($"The number before call Numref method:{b}");
        Numref( ref b);
        Debug.Log($"The number after call Numref method:{b}");


        Numout(out newNum);
      

        }
    

public void Num(int number){
        number+=10;
        Debug.Log($"The Number : {number}");
    }


public void Numref(ref int number)
        {
            number += 10;
            Debug.Log($"The Reference Number : {number}");
        }

public void Numout(out int number)
        {
            number = 10;
            Debug.Log($"The Out Number :{number}");
        }


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string []words ={"cat","dog","car","pizza","hat","fish","tree","monkey","ball","brid"};
        string newWords="";
        int counter=0;
        while(counter<=7){
           
          newWords += (words[Random.Range(0,words.Length)]+" ");
           counter++;
           
        }
        Debug.Log(newWords);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_1{
public class GameContainer <T>
{
    private T item;
   
    public  T Item
    {
        get{return item;}
        set{item=value;}

    }
}
}
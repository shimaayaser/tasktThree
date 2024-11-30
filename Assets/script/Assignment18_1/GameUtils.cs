using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_1{
public class GameUtils
{
    public static string DescribeItem<T>(T something){
      string describeItem="This item is a";
        return describeItem +""+something;
    }
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public struct Position
{
    public  float X,Y, Z;

    public Position(float X,float Y , float Z){
        this.X=X;
        this.Y=Y;
        this.Z=Z;
    }
    public void printPosition(){
        Debug.Log("the position X:"+" "+X+" "+"the position Y:"+" "+Y+" "+"the position Z:"+" "+Z);
    }

}
}
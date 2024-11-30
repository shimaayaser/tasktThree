using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy :Character
{
//    New addition to the code
      public Enemy(string name, int health) : base(name, health) { }


   public void Attack(int attack){

        Health-=attack;
        Debug.Log("decrease the health :"+ ""+attack+"new health:"+""+Health);
   }
}

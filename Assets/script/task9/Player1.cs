using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character
{
    // New addition to the code
    public Player1(string name, int health) : base(name, health) { }
    public void Heal(int amount){    

        Health += amount;
        Debug.Log("increase the health :"+""+amount+"new health:"+""+Health);

      }
}

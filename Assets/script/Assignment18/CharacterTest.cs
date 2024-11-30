using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{

public class CharacterTest : MonoBehaviour
{
    Character character =new Character();
    Soldier  soldier;
    Officer officer; 
    Character[] characters = new Character[2];
    void Start() {
        
        soldier=new Soldier();
        officer=new Officer("David", 100, new Position(6,4,2));
        characters[0]=soldier;
        characters[1]=officer;

        for(int i = 0; i < characters.Length; i++){
             characters[i].DisplayInfo();
        }


        Debug.Log("before attack soldier's health : " +" "+ soldier.Health);
        officer.Attack(15, soldier, "kicking");
        Debug.Log("after attack soldier's health : " +" "+ soldier.Health);

    }
}

}


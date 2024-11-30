using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName ="";
    public int health = 100 ;
    public static int playerCount=0;
 
    public void InitializePlayer(string name, int initialHealth){
        name=playerName;
        initialHealth=health;
        playerCount++;
    }
    public void Heal(int amount){
        health+=amount;
        Debug.Log( amount);

    }
    public void Heal( bool fullRestore){
       if(fullRestore){
         health=100;
       }
    }
    public static void ShowPlayerCount(){
        Debug.Log(playerCount);
    }

}

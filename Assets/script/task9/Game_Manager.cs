using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    
    void Start()
    {
        Player1 player = new Player1("Subhi", 100);
        Enemy enemy = new Enemy("Zarifeh", 70);

        Debug.Log("the Player name:"+player.Name +""+"the Player health:"+""+player.Health);
        Debug.Log("the Enemy name:"+enemy.Name +""+"the Enemy health:"+""+enemy.Health);

        player.Heal(30);
        enemy.Attack(50);

    }

    
}

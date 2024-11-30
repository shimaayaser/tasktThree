using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    
    void Start()
    {
        Player playerOne = new Player();
        Player playerTwo = new Player();

        playerOne.InitializePlayer("david",90);
        playerTwo.InitializePlayer("John",60);

        playerOne.Heal(10);
        playerTwo.Heal(30);

        playerOne.Heal(true);
        playerTwo.Heal(false);

        Player.ShowPlayerCount();

    }

    
}

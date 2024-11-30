using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_1{
public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GameContainer<string> gameContainer =new  GameContainer<string>();
      gameContainer.Item="Healing Potion";
      Debug.Log("Stored item:"+gameContainer.Item);
      string description =GameUtils.DescribeItem(gameContainer.Item);
      Debug.Log(description);

    }

  
}
}
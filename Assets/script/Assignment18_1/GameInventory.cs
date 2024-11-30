using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_1{
public class GameInventory : MonoBehaviour
{

    void Start()
    {
            Inventory potions = new Inventory();
            Inventory elixirs = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");
            Inventory combine = potions + elixirs;
            combine.ShowItems();
    }

}
}
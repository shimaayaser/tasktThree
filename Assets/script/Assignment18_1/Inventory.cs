using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_1{
public class Inventory 
{
   private List<string> itemName;

    public  Inventory()
        {
            itemName = new List<string>();
        }
    public void AddItem(string item)
        {
            itemName.Add(item);
        }

    public void ShowItems(){
        foreach(string item in itemName){
        Debug.Log(item);
        }
     }
    public static Inventory  operator +(Inventory a,Inventory b){
            Inventory combine = new Inventory();
            foreach (string item in a.itemName)
            {
                combine.AddItem(item);
            }
            foreach (string item in b.itemName)
            {
                combine.AddItem(item);
            }

            return combine;
        }
    }
}

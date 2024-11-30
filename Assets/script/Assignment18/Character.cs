using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class Character 
{
    public string name;
    private int health;
    protected Position position;
  
    public int Health{

        get{return health;}
        set{if(value<=100)health=value;}
    }

    public Character(string name,int health,Position position){
        this.name=name;
        this.health=health;
        this.position=position;
    }
    public Character() :this("No name", 100, new Position(0,0,0)) { }

    public virtual void DisplayInfo(){
        Debug.Log("the name:"+" "+name +" "+"the health:"+" "+health);
        position.printPosition();
    }

    public void Attack(int damage,Character target){
        
        HealthDamage(target, damage);
         
    }
    public void Attack(int damage, Character target, string attackType){
        
        Debug.Log("attack type :"+" "+ attackType);
        HealthDamage(target, damage);

    }
    void HealthDamage(Character target, int damage){
        target.Health -= damage;
     }
 }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_26
{

public class CreatureManager : MonoBehaviour {
       

        void Start(){
            List<Creature> creatures = new List<Creature>();
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();
            creatures.Add(kangaroo);
            creatures.Add(duck);
            List<IRunnable> runnable = new List<IRunnable>();
            List<IJumpable> jumpable = new List<IJumpable>();
            List<ISwimmable> swimmable = new List<ISwimmable>();
            runnable.Add(kangaroo);
            jumpable.Add(kangaroo);
            runnable.Add(duck);
            swimmable.Add(duck);
          
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable runnables in runnable)
            {
                runnables.Run();
            }
            foreach (IJumpable jumpables in jumpable)
            {
                jumpables.Jump();
            }
            foreach (ISwimmable swimmables in swimmable)
            {
                swimmables.Swim();
            }


        }

    }
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

    public interface IRunnable
    {
        public void Run();
    }

    public interface IJumpable
    {
        public void Jump();
    }
    public interface ISwimmable
    {
        public void Swim();
    }
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }

    }
    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }

}
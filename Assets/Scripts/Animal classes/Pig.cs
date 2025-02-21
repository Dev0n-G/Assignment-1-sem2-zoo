using UnityEngine;

public class Pig : Animal
{
    public Pig() : base("Pig") { }

    public override void MakeSound()
    {
        Debug.Log($"{name} says: Oink!");
    }

    public override void Interact()
    {
        Debug.Log($"You interact with the {name}. It happily snorts.");
    }
}

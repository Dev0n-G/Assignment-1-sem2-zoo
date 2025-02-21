using UnityEngine;

public class Penguin : Animal
{
    public Penguin() : base("Penguin") { }

    public override void MakeSound()
    {
        Debug.Log($"{name} says: Squawk!");
    }

    public override void Interact()
    {
        Debug.Log($"You interact with the {name}. It flaps its wings.");
    }
}

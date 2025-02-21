using UnityEngine;

public class Camel : Animal
{
    public Camel() : base("Camel") { }

    public override void MakeSound()
    {
        Debug.Log($"{name} says: Grunt!");
    }

    public override void Interact()
    {
        Debug.Log($"You interact with the {name}. It gives you a slow, steady look.");
    }
}

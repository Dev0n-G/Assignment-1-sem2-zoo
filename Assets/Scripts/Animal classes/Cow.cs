using UnityEngine;

public class Cow : Animal
{
    public Cow() : base("Cow") { }

    public override void MakeSound()
    {
        Debug.Log($"{name} says: Moo!");
    }

    public override void Interact()
    {
        Debug.Log($"You interact with the {name}. It chews on some grass.");
    }
}

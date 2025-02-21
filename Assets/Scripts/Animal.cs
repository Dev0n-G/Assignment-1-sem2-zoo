using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public float hunger;
    public new string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public abstract void MakeSound();
    public abstract void Interact();
}

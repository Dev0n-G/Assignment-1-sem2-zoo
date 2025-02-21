using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private bool isNearAnimal = false;
    private Animal currentAnimal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Animal"))
        {
            isNearAnimal = true;
            currentAnimal = other.GetComponent<Animal>();
            Debug.Log("Near animal: " + currentAnimal.name);  // Added Debug log
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Animal"))
        {
            isNearAnimal = false;
            currentAnimal = null;
        }
    }

    void Update()
    {
        if (isNearAnimal && Input.GetKeyDown(KeyCode.E))
        {
            if (currentAnimal != null)
            {
                currentAnimal.Interact();  // This should now call the correct Interact method.
                Debug.Log("Interacting with: " + currentAnimal.name);  // Added Debug log
            }
        }
    }
}

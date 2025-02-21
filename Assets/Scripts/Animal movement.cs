using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed = 135f;
    public float moveDistance = 3f;
    private float timer;

    void Start()
    {
        timer = 4f;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            MoveRandomDirection();
            timer = 4f;
        }
    }

    void MoveRandomDirection()
    {
        int randomDirection = Random.Range(0, 4);
        Vector3 moveVector = Vector3.zero;

        switch (randomDirection)
        {
            case 0: moveVector = Vector3.left; break;
            case 1: moveVector = Vector3.right; break;
            case 2: moveVector = Vector3.up; break;
            case 3: moveVector = Vector3.down; break;
        }

        transform.Translate(moveVector * moveDistance * moveSpeed * Time.deltaTime);
    }
}

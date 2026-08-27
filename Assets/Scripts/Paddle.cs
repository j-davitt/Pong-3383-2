using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public int id;
    public float moveSpeed = 2f;

    void Update()
    {
        float value = ProcessInput();
        Move(value);   
    }
    float ProcessInput()
    {
        float movement = 0f;
        switch (id)
        {
            case 1:
                movement = Input.GetAxis("MoveP1");
                break;
            case 2:
                movement = Input.GetAxis("MoveP2");
                break;
        }
        return movement;
    }
    void Move(float value)
    {
        Vector2 vel = rb2d.linearVelocity;
        vel.y = moveSpeed * value;
        rb2d.linearVelocity = vel;
    }
}

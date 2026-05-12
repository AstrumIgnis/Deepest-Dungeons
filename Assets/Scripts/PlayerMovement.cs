using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    // FixedUpdate is called 50x per second, and is used for physics calculations.
    // It is called before any physics calculations are performed, and is used to
    // update the physics state of the game.
    void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }
}

using UnityEngine;

public abstract class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerBody;
    public IdleState idleState;
    public Move moveState;
    public Jump jumpState;
    public static bool isGrounded;
    public abstract PlayerMovement RunCurrentState(bool isGrounded);
}

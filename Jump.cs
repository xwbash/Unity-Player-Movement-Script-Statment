using UnityEngine;

public class Jump : PlayerMovement
{
    public override PlayerMovement RunCurrentState(bool _isGrounded)
    {
        StateManager manager = new StateManager();
        manager.isGrounded = false;
        playerBody.AddForce(Vector3.up*10f);
        if(!_isGrounded)
        {
            return idleState;
        }
        return this;
    }

}

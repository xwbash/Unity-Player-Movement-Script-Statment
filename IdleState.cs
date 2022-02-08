using UnityEngine;
public class IdleState : PlayerMovement
{
   
    public override PlayerMovement RunCurrentState(bool _isGrounded)
    {
        
        if(Input.GetAxis("Jump") > 0 && _isGrounded)
        {
            return jumpState;
        }
        else if(Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            return moveState;
        }
        return this;
    }

}

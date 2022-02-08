using UnityEngine;

public class Move : PlayerMovement{

    public override PlayerMovement RunCurrentState(bool _isGrounded)
    {
        if(_isGrounded && Input.GetAxis("Jump") > 0)
        {
            return jumpState;
        }
        else if(Input.GetAxis("Horizontal") == 0)
        {
            return idleState;
        }
        float Horizontal = Input.GetAxis("Horizontal");
        playerBody.AddForce(new Vector3(Horizontal*10f,0,0));
        return this;
    }
}

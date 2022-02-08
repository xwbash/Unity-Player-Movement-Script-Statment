using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
   public bool isGrounded;
   public PlayerMovement currentState;
    // Start is called before the first frame update
    private void Update() {
        
        RunStateMachine();
    }
    // Update is called once per frame
    void RunStateMachine()
    {
        PlayerMovement nextState = currentState?.RunCurrentState(isGrounded);

        if(nextState != null)
        {
            SwitchNextState(nextState);
        }
    }
    void SwitchNextState(PlayerMovement nextState)
    {
        currentState = nextState;
    }
}

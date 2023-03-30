using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private State currentState;

    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }
    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if(nextState != null){
            ChangeState(nextState);
        }
    }
    private void ChangeState(State nextState)
    {
        currentState = nextState;
    }
}

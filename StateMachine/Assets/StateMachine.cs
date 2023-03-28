using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public interface IState 
{
	void OnBegin();
	void OnEnd();
	StateMachine.EState OnUpdate();
	void OnContact();
	void OnPowerUp();
}

public class StateMachine : MonoBehaviour
{
	public enum EState { Patrulhar, Perseguir, Defender, Fugir}
    public EState currentState;
    private IState[] state;

}

public void Update(){
    EState nextState = state[(int)currentState].OnUpdate();
    if(nextState != currentState){
        ChangeState(nextState);
    }
}
private void ChangeState(EState nextState){
    state[(int)currentState].OnEnd();
    state[(int)nextState].OnBegin();
    currentState = nextState;
}
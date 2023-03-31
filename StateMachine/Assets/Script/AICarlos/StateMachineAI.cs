using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EState { Patrulhar, Perseguir, Fugir, Defender }

public abstract class AState
{
    public PlayerAI jogador;
    public EState next;
    public float distanciaMinima;
    public abstract void OnBegin(PlayerAI player);
    public abstract EState OnUpdate(bool perto);
}

public class StateMachineAI : MonoBehaviour
{
    public PlayerAI player;
    EState currentState;
    EState nextState;
    private AState[] state = { new PatrulharAI(), new PerseguirAI(), new FugirAI(), new DefenderAI() };

    void Start()
    {
        currentState = EState.Patrulhar;
        state[0].OnBegin(player);
        Debug.Log(state[(int)currentState].next);
    }

    void Update()
    {
        nextState = state[(int)currentState].OnUpdate(VerificarPerto());
        if (nextState != currentState)
        {
            ChangeState(nextState);
        }
    }

    private void ChangeState(EState nextState)
    {
        state[(int)nextState].OnBegin(player);
        Debug.Log(currentState);
        currentState = nextState;
        Debug.Log(state[(int)currentState].next);
    }

    public bool VerificarPerto()
    {
        Vector3 distancia = transform.position - player.transform.position;
        if (distancia.magnitude <= state[(int)currentState].distanciaMinima)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
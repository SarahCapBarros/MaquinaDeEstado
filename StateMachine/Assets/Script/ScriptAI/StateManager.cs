//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public enum EState { Patrulhar, Perseguir, Fugir, Defender }

//public abstract class AState
//{
//    public Player jogador;
//    public EState next;
//    public float distanciaMinima;
//    public abstract void OnBegin(Player player);
//    public abstract EState OnUpdate(bool perto);
//}

//public class StateManager : MonoBehaviour
//{
//    public Player player;
//    EState currentState;
//    EState nextState;
//    private AState[] state = { new Patrulhar(), new Perseguir(), new Fugir(), new Defender() };

//    void Start()
//    {
//        currentState = EState.Patrulhar;
//        state[0].OnBegin(player);
//        Debug.Log(state[(int)currentState].next);
//    }

//    void Update()
//    {
//        nextState = state[(int)currentState].OnUpdate(VerificarPerto());
//        if (nextState != currentState)
//        {
//            ChangeState(nextState);
//        }
//    }

//    private void ChangeState(EState nextState)
//    {
//        state[(int)nextState].OnBegin(player);
//        currentState = nextState;
//        Debug.Log(state[(int)currentState].next);
//    }

//    public bool VerificarPerto()
//    {
//        Vector3 distancia = transform.position - player.transform.position;
//        if (distancia.magnitude <= state[(int)currentState].distanciaMinima)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }

//    }
//}
//public abstract class State
//{
//    public Jogador jogador;
//    public abstract State RunCurrentState();
//    public abstract State nextState
//    public enum estados { Patrulhar, Fugir, Perseguir };
//    public abstract bool VerficarPerto();
//    estados stadoo;
//}

//public class StateManager : MonoBehaviour
//{
//    private State currentState;
//    public Transform playerTransform;
//    public float distanciaMaxima = 5f;
//    public float distanciaMinima = 2f;

//    Update is called once per frame
//    void U()
//    {

//        if (Input.GetKey(KeyCode.S))
//        {
//            Debug.Log("Fugir");
//            currentState = estadoFugir;
//        }

//        RunStateMachine();
//    }
//    private void RunStateMachine()
//    {
//        if next stage = current stage->run current stage; else current stage = next stage->run next stage;
//        State nextState = currentState.RunCurrentState();

//        if (nextState != null)
//        {
//            ChangeState(nextState);
//        }
//    }
//    private void ChangeState(State nextState)
//    {
//        currentState = nextState;
//    }
//}



//public class EstadoPerseguir : State
//{
//    stadoo[2]
//    public bool perto;

//    public override State RunCurrentState()
//    {
//        if (perto && !jogador.Invencivel)
//        {
//            Debug.Log("Perseguir");
//            return this;
//        }
//        else
//        {
//            return estadoPatrulhar;
//        }

//    }

//}

//public class EstadoFugir : State
//{
//    public EstadoPatrulhar estadoPatrulhar;
//    public bool perto, playerInvencivel;
//    public override State RunCurrentState()
//    {
//        if (!perto)
//        {
//            return estadoPatrulhar;
//        }
//        else
//        {
//            return this;
//        }
//    }


//}

//public class EstadoPatrulhar : State
//{
//    public EstadoPerseguir estadoPerseguir;
//    public EstadoFugir estadoFugir;
//    public bool perto, playerInvencivel;
//    public override State RunCurrentState()
//    {
//        if (perto && !playerInvencivel)
//        {
//            return estadoPerseguir;

//        }
//        else if (perto && playerInvencivel)
//        {
//            return estadoFugir;
//        }
//        else
//        {
//            return this;
//        }

//    }
//}



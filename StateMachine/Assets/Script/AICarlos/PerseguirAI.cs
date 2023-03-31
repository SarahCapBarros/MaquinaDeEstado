using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerseguirAI : AState
{
    public override void OnBegin(PlayerAI player)
    {
        jogador = player;
        next = EState.Perseguir;
        distanciaMinima = 6.0f;
    }

    public override EState OnUpdate(bool perto)
    {
        if(!jogador.inv)
        {
            return next;
        }
        else if(perto && jogador.inv)
        {
            next = EState.Defender;
            return next;
        }
        else if(!perto && jogador.inv)
        {
            next = EState.Patrulhar;
            return next;
        }
        else
        {
            return next;
        }
    }
}
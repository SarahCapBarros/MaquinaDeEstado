using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrulharAI : AState
{
    public override void OnBegin(PlayerAI player)
    {
        jogador = player;
        next = EState.Patrulhar;
        distanciaMinima = 6.0f;
    }

    public override EState OnUpdate(bool perto)
    {
        if(!perto)
        {
            return next;
        }
        else if(perto && !jogador.inv)
        {
            next = EState.Perseguir;
            return next;
        }
        else if(perto && jogador.inv)
        {
            next = EState.Fugir;
            return next;
        }
        else
        {
            return next;
        }
    }
}
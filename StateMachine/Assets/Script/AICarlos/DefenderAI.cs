using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderAI : AState
{
    public override void OnBegin(PlayerAI player)
    {
        jogador = player;
        next = EState.Defender;
        distanciaMinima = 6.0f;
    }

    public override EState OnUpdate(bool perto)
    {
        if(jogador.inv && perto)
        {
            return next;
        }
        else if(!perto && jogador.inv)
        {
            next = EState.Patrulhar;
            return next;
        }
        else if(!jogador.inv)
        {
            next = EState.Perseguir;
            return next;
        }
        else
        {
            return next;
        }
    }
}
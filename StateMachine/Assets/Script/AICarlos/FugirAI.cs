using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FugirAI : AState
{
    public override void OnBegin(PlayerAI player)
{
    jogador = player;
    next = EState.Defender;
    distanciaMinima = 15.0f;
}

    public override EState OnUpdate(bool perto)
    {
        if(perto)
        {
            return next;
        }
        else if(!perto)
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
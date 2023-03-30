using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoDefender : State
{
    public bool perto, playerInvencivel;
    public EstadoPatrulhar estadoPatrulhar;
    public EstadoPerseguir estadoPerseguir;
    public override State RunCurrentState()
    {
        if (!perto && playerInvencivel)
        {
            return estadoPatrulhar;
        }
        else if (!playerInvencivel)
        {
            return estadoPerseguir;
        }
        else
        {
            Debug.Log("Defender-se");
            return this;
        }
    }

}

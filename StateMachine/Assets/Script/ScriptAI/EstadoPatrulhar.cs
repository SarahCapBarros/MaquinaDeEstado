using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPatrulhar : State
{
    public EstadoPerseguir estadoPerseguir;
    public EstadoFugir estadoFugir;
    public bool perto, playerInvencivel;
    public override State RunCurrentState()
    {
        if(perto && !playerInvencivel)
        {
            return estadoPerseguir;

        }else if(perto && playerInvencivel)
        {
            return estadoFugir;
        }
        else
        {
            return this;
        }
        
    }
}

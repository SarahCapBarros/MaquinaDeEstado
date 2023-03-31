using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class EstadoPatrulhar : State
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
}*/

/*public class EstadoPatrulhar : State
{
    public EstadoPerseguir estadoPerseguir;
    public EstadoFugir estadoFugir;
    public Transform playerTransform;
    public float distanciaMaxima = 5f;
    public float distanciaMinima = 2f;
    
    public override State RunCurrentState()
    {
        float distancia = Vector3.Distance(transform.position, playerTransform.position);

        if (distancia < distanciaMinima && playerInvencivel )
        {
            return estadoFugir;
        }
        else if (distancia <= distanciaMaxima)
        {
            return estadoPerseguir;
        }
        else
        {
            Debug.Log();
            return this;
        }
    }
}*/

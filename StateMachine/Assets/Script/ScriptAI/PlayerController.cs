using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float velocidadeParaFrente = 8.0f;
    [SerializeField] private float velocidadeDeVirada = 100.0f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float teclaHorizontal = Input.GetAxis("Horizontal");
        float teclaVertical = Input.GetAxis("Vertical");

        // N�o permite que o jogador ande para tr�s.
        if (teclaVertical < 0.0f)
        {
            teclaVertical = 0.0f;
        }

        // Movimenta o jogador na dire��o para frente e para tr�s.
        rb.velocity = transform.forward * teclaVertical * velocidadeParaFrente;

        // Rotaciona o jogador na dire��o horizontal.
        transform.Rotate(Vector3.up * teclaHorizontal * velocidadeDeVirada * Time.deltaTime);
    }
}

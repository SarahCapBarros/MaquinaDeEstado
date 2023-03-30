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

        // Não permite que o jogador ande para trás.
        if (teclaVertical < 0.0f)
        {
            teclaVertical = 0.0f;
        }

        // Movimenta o jogador na direção para frente e para trás.
        rb.velocity = transform.forward * teclaVertical * velocidadeParaFrente;

        // Rotaciona o jogador na direção horizontal.
        transform.Rotate(Vector3.up * teclaHorizontal * velocidadeDeVirada * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float VelocidadMovimiento = 5.0f;

    private Character jugador;

    private void Start()
    {
        jugador = GetComponent<Character>();
    }

    private void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        transform.Translate(movimiento * VelocidadMovimiento * Time.deltaTime);

        // Disparar en la dirección del movimiento
        if (movimiento != Vector3.zero)
        {
            Vector3 direccionDisparo = movimiento.normalized;
            jugador.Disparar(direccionDisparo);
        }
    }
}

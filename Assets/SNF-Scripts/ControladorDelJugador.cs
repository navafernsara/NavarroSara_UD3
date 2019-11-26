using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    /*Almacena Rigidbody de Jugador*/
    Rigidbody rb;

    public float velocidad;
    int contador;
    //Variables para almacenar objetos recogidos
    int numItems_1;
    int numItems_2;
    int numItems_3;

    public Text marcador;
    public Text finJuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ActualizaMarcador();
        //Desactivar elemento texto de fin de juego//
        finJuego.gameObject.SetActive(false);
        
    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento*velocidad);
    }


    public void OnTriggerEnter(Collider other) //Collider sera el otro objeto con el que solisiona
    {

        if(other.tag == "Suma1")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numItems_1 = numItems_1 + 1;
        }
        else if (other.tag == "Suma2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numItems_2 = numItems_2 + 1;
        }
        else if (other.tag == "Resta1")
        {
            contador = contador - 1;
        }

        ActualizaMarcador();

        if (numItems_1 >= 6 && numItems_2 >= 3)
        {
            finJuego.gameObject.SetActive(true);

            Time.timeScale = 0;
        }
    }

    void ActualizaMarcador()
    {
        marcador.text = "Puntos:" + contador;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ControladorDelJugador : MonoBehaviour
{
    int contador; 
    Rigidbody rb;
    public Text puntuacion; 
    public float velocidad;
    public Text win; 

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        puntuacion.text = "Puntuacion" + contador;
        if (contador>=5)
        {
            win.gameObject.SetActive(true);
        }
    }



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        puntuacion.text = "Puntuacion" + contador;
        win.gameObject.SetActive(false); 
    }
    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(movimiento*velocidad); 
    }




}

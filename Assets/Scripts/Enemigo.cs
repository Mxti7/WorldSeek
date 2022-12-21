using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform Jugador;
    public float velocidad;
    bool estarAlerta;



    void Start()
    {
        
    }


    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position,rangoDeAlerta,capaDelJugador );
        
        if (estarAlerta == true)
        {
            ////transform.LookAt(Jugador);
            Vector3 posJugador = new Vector3(Jugador.position.x,transform.position.y,Jugador.position.z);
            transform.LookAt(posJugador);
            transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }
}
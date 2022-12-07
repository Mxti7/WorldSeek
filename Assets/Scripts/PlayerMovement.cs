using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement : MonoBehaviour

{

    CharacterController characterController;

    //bool caminar = false; Se crea una variable dependiendo de la animacion;

    public float velocidad_caminar=6.0f;
    public float velocidad_correr=10.0f;
    public float cantidad_salto=8.0f;
    public float gravedad =70.0f;
    //public Animator animator; Se crea solo 1 animator por player;

    private Vector3 movimiento = Vector3.zero;

    // Start is called before the first frame update

    void Start()

    {

        characterController = GetComponent<CharacterController>();

    }



    // Update is called once per frame

    void Update()

    {

        if(characterController.isGrounded){

            movimiento= new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if(Input.GetKey(KeyCode.LeftShift)){

                movimiento = transform.TransformDirection(movimiento)* velocidad_correr;
                //caminar = false;

            }

            else{

                movimiento = transform.TransformDirection(movimiento)* velocidad_caminar;
                //caminar = true;

            }

            if(Input.GetKey(KeyCode.Space)){
                movimiento.y = cantidad_salto;

            }
            //animator.SetBool("walk", caminar); se setea la variable que se asigno en los parametros.

            

        }

        movimiento.y -= gravedad * Time.deltaTime;

        characterController.Move(movimiento*Time.deltaTime);

    }

}


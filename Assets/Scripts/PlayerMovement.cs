using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement : MonoBehaviour

{

    CharacterController characterController;

    //public float velocidad_rotacion=200.0f;
    //bool caminar = false; Se crea una variable dependiendo de la animacion;
    public float velCaminar = 6.0f;
    public float velCorrer = 10.0f;
    public float cantidadSalto = 8.0f;
    public float gravedad = 70.0f;
    //public Animator animator; //Se crea solo 1 animator por player;

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

            movimiento = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if(Input.GetKey(KeyCode.LeftShift)){
                movimiento = transform.TransformDirection(movimiento)* velCorrer;
                //caminar = false;

            }

            else{
                movimiento = transform.TransformDirection(movimiento)* velCaminar;
                //caminar = true;

            }

            if(Input.GetKey(KeyCode.Space)){
                movimiento.y = cantidadSalto;

            }
            //animator.SetBool("walk", caminar); se setea la variable que se asigno en los parametros.

            

        }

        movimiento.y -= gravedad * Time.deltaTime;

        characterController.Move(movimiento*Time.deltaTime);

    }

}


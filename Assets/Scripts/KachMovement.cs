using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KachMovement : MonoBehaviour
{
    public float velCorrer = 7.0f;
    public float velRotacion = 250.0f;
    public float fuerzaSalto = 8.0f;

    public bool saltando;

    public Animator animator;
    public Rigidbody rigidbody;

    private float x, y;

    
    

    void start()
    {
        saltando = false;
    }

    void FixedUpdate() //Para estandarizar el tiempo en que se ejecuta por cada FPS.
    {
        transform.Rotate(0, x*Time.deltaTime * velRotacion, 0);
        transform.Translate(0, 0, y*Time.deltaTime * velCorrer);
    }

    void Update()
    {

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        if(saltando==true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("IsJumping", true);
                rigidbody.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }
            animator.SetBool("OnGround", true);
        }
        else
        {
            FallingDown();
        }
    }

    public void FallingDown()
    {
        animator.SetBool("OnGround", false);
        animator.SetBool("IsJumping", false);
    }
}

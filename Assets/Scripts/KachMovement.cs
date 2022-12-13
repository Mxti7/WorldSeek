using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KachMovement : MonoBehaviour
{
    public float velCorrer = 7.0f;
    public float velRotacion = 250.0f;

    public Animator animator;

    private float x, y;

    void start()
    {

    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x*Time.deltaTime * velRotacion, 0);

        transform.Translate(0, 0, y*Time.deltaTime * velCorrer);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}

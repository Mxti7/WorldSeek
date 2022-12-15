using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalJump : MonoBehaviour
{

    public KachMovement logicaPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        logicaPersonaje.saltando=true;
    }

    private void OnTriggerExit(Collider other)
    {
        logicaPersonaje.saltando=false;
    }
}

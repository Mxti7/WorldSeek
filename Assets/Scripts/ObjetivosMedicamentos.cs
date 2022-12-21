using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjetivosMedicamentos : MonoBehaviour
{

    public int numDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonDeMision;

    // Start is called before the first frame update
    void Start()
    {

        numDeObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
        textoMision.text = "Recolecta los medicamentos" +
                         "\n Restantes: " + numDeObjetivos;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Objetivos")
        {
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = "Recolecta los medicamentos" +
                             "\n Restantes: " + numDeObjetivos;

            if(numDeObjetivos <= 0)
            {
                textoMision.text = "Recolectaste todos los medicamentos";
                botonDeMision.SetActive(true);
            }
        }
    }
}

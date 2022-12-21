using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Validation : MonoBehaviour
{

    public Text InputPlayerName, InputPlayerAge;
    
    string name;
    byte age;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidarCampos(){
        name = InputPlayerName.text;
        age = byte.Parse(InputPlayerAge.text);
        
        // Validar que se ingresen solo numeros y sea mayor de 18
        try{
            if(name.Length >=4 && age >= 18)
            {
                SceneManager.LoadScene("Game");
            }

            if(name.Length < 4)
            {
                Debug.Log($"Ingresaste un nombre que no es válido");
            }

            if(name.Length < 4 && age < 18)
            {
                Debug.Log($"El nombre ingresado no es válido y eres menor de edad");
            }
            else

            if(name.Length < 4 && age >= 18)
            {
                Debug.Log($"El nombre ingresado no es válido");
            }
            else
            {
                Debug.Log($"{name}, Usted no tiene la edad mínima, su edad es {age}");
            }
        }
        catch(Exception ex){
            Debug.Log($"Error en formato de edad {ex.Message}");
        }
        
    }
}





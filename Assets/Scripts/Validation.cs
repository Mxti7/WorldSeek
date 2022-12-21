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
        try{
            if(age >= 18)
            {
                SceneManager.LoadScene("Game");
            }
            else
            {
                Debug.Log($"{name}, Usted no tiene la edad mínima, su edad es {age}");
            }
        }
        catch(Exception ex){
            Debug.Log($"Error en formato de edad {ex.Message}");
        }
        Debug.Log($"Su nombre es {name}");
    }
}

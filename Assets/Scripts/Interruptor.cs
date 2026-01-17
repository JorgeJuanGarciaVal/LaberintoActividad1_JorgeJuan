using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Interruptor : MonoBehaviour
{
    public Puerta puertaAbrir;
    public string messageOnActivate = "Interruptor activado";

    private bool activated = false;

    public void Activate()
    {
        if (activated) { return; }
        activated = true;
        
        if (puertaAbrir != null) { 
            puertaAbrir.Open();

        Debug.Log("Interruptor activado: "+ gameObject.name);
        
        }     
    }

}

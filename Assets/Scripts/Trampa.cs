using UnityEngine;

public class Trampa : MonoBehaviour
{
    public string deathMessage = "Trampa";

    private void OnTriggerEnter(Collider other)
    {

        //Comprueba que el objeto que detecta es el jugador. Si no es el jugador, lo ignora.
        if (!other.CompareTag("Player")) return;

        Reaparicion reaparicion = other.GetComponent<Reaparicion>();
            if (reaparicion != null) { 
                reaparicion.Die(deathMessage);
        }



    }
}

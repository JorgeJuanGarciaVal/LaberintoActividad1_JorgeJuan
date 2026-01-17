using UnityEngine;

public class Trampa : MonoBehaviour
{
    public string deathMessage = "Trampa";

    private void OnTriggerEnter(Collider other)
    {

        // Comprueba que quien entra es el Player
        if (!other.CompareTag("Player")) return;

        Reaparicion reaparicion = other.GetComponent<Reaparicion>();
            if (reaparicion != null) { 
                reaparicion.Die(deathMessage);
        }



    }
}

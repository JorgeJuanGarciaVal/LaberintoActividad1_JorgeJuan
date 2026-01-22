using UnityEngine;

public class Disparo : MonoBehaviour
{
    public FlechaTrampa flecha;
    public Transform direccionDisparo;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        //Comprueba que el objeto que detecta es el jugador. Si no es el jugador, lo ignora.
        if (!other.CompareTag("Player")) return;
        if (activated) return;

        activated = true;

        flecha.Launch(direccionDisparo.forward);
    }
}

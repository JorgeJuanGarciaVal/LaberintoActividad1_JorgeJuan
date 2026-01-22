using UnityEngine;

public class DerrotaSecuencia : MonoBehaviour
{
    [SerializeField] GameObject activar;

    private void OnTriggerEnter(Collider other)
    {
        //Comprueba que el objeto que detecta es el jugador. Si no es el jugador, lo ignora.
        if (!other.CompareTag("Player")) return;

        activar.SetActive(false);
        activar.SetActive(true);

        
    }
}

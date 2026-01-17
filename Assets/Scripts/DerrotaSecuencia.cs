using UnityEngine;

public class DerrotaSecuencia : MonoBehaviour
{
    [SerializeField] GameObject activar;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        activar.SetActive(false);
        activar.SetActive(true);

        
    }
}

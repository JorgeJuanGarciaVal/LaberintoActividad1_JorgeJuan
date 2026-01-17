using UnityEngine;

public class ActivarSecuencia : MonoBehaviour
{
    [SerializeField] GameObject toActivate;

    private void OnTriggerEnter(Collider other)
    {
        toActivate.SetActive(true);
    }
}

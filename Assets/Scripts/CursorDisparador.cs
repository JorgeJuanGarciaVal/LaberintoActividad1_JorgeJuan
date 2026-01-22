using UnityEngine;
using UnityEngine.InputSystem;

public class CursorDisparador : MonoBehaviour
{

    public Camera playerCamera;
    public float range = 80f;
    public LayerMask hitMask = ~0; // todo
    public KeyCode interactKey = KeyCode.Mouse0; // click izq

    void Update()
    {
        if (!Input.GetKeyDown(interactKey)) return;

        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, range, hitMask))
        {
            // Busca un Switch en el objeto impactado (o en sus padres)
            Interruptor sw = hit.collider.GetComponent<Interruptor>() ?? hit.collider.GetComponentInParent<Interruptor>();
            if (sw != null)
            {
                sw.Activate();
            }
            else
            {
                Debug.Log("Impacto, pero no era un interruptor: " + hit.collider.name);
            }
        }
    }
}

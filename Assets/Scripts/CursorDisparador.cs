using UnityEngine;
using UnityEngine.InputSystem;

public class CursorDisparador : MonoBehaviour
{
    //Camera mainCamera;

    // private void Start()
    // {
    //    mainCamera = Camera.main;
    // }

    //  RaycastHit hit;
    //  void Update()
    //  {
    //     if (Mouse.current.leftButton.isPressed)
    //     {

    //         Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
    //Debug.Log(Mouse.current.position.ReadValue());
    //         Debug.DrawRay(ray.origin, ray.direction * 20f, Color.royalBlue);

    //         if (Physics.Raycast(ray, out hit, Mathf.Infinity))
    //         {
    //              Debug.Log($"He encontrado a lo largo del rayo el objeto {hit.collider.name}");
    //Destroy(hit.collider.gameObject);
    //EsferaDestruible esferaDestruible = hit.collider.GetComponent<EsferaDestruible>();
    //esferaDestruible.NotifyHasBeenHit();
    //      }


    //  }
    // }



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

using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    private bool open = false;

    public void Open()
    {
        if (open) { return; }
        open = true;

        Debug.Log("Puerta abierta: " + gameObject.name);

        // Desaparece la puerta (visual + collider)
        gameObject.SetActive(false);
    }
}

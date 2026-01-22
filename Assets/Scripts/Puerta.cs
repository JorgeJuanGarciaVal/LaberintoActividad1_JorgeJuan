using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Puerta : MonoBehaviour
{

    public float altura = 3f;
    public float velocidad = 5f;

    private Vector3 posicionInicial;
    private Vector3 posicionFinal;

    private bool open = false;


    void Start()
    {
        posicionInicial = transform.position;
        posicionFinal = posicionInicial + Vector3.up * altura;
    }

    void Update()
    {
        if (!open) return;

        transform.position = Vector3.MoveTowards(transform.position, posicionFinal, velocidad * Time.deltaTime);
    }

    public void Open()
    {
        open = true;

        Debug.Log("Puerta abierta: " + gameObject.name);

        // Desaparece la puerta
        //gameObject.SetActive(false);
    }
}

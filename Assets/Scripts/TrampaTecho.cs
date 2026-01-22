using UnityEngine;

public class TrampaTecho : MonoBehaviour
{
    public float speed = 1f;
    public float downDistance = 3f;

    private Vector3 posicionInicial;
    private Vector3 posicionFinal;
    private bool goingDown = true;

    void Start()
    {
        posicionInicial = transform.position;
        posicionFinal = posicionInicial + Vector3.down * downDistance;
    }

    void Update()
    {
        Vector3 target;

        if (goingDown)
        {
            target = posicionFinal;
        }
        else
        {
            target = posicionInicial;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //Si el techo llega a la posición final, se invierte su direccion de movimiento para que haga el movimiento de subir y bajar
        if (Vector3.Distance(transform.position, target) < 0.01f)
           goingDown = !goingDown;
    }
}

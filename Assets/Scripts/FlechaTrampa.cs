using UnityEngine;

public class FlechaTrampa : MonoBehaviour
{
    public float speed = 10f;
    public float tiempoVida = 3f; // Segundos que tarda en destruirse
    private bool launched = false;
    private Rigidbody rb;



    public void Launch(Vector3 direction)
    {
        rb = GetComponent<Rigidbody>();

        if (launched) return;
        launched = true;

        rb.isKinematic = false;
        rb.linearVelocity = direction.normalized * speed;

        Destroy(gameObject, tiempoVida);
    }

}

using UnityEngine;



[RequireComponent(typeof(CharacterController))]
public class NewMonoBehaviourScript : MonoBehaviour
{

    //Velocidad de movimiento
    public float velocidad_mov = 5f;

    //Velocidad de rotacion
    public float velocidad_rot = 180f;

    private CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // A-D 
        float Horizontal = Input.GetAxis("Horizontal");

        // W-S
        float Vertical = Input.GetAxis("Vertical");

        //Giro del personaje
        float rotacion = Horizontal * velocidad_rot * Time.deltaTime;
        transform.Rotate(0, rotacion, 0);

        //Movimiento del personaje (Hacia delante y atrás)
        Vector3 movimiento = new Vector3(0, 0, Vertical);          // Movimiento solamente en el eje Z

        //Velocidad y deltaTime
        movimiento = movimiento * velocidad_mov * Time.deltaTime;

        //Convertir de espacio local a global
        movimiento = transform.TransformDirection(movimiento);

        controller.Move(movimiento);
    }
}

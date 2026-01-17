using UnityEngine;

public class Reaparicion : MonoBehaviour
{
    public Transform Respawn;

    private CharacterController controller;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Die(string reason)
    {
        Debug.Log("Has muerto: " + reason);

        // Teleport seguro con CharacterController
        controller.enabled = false;
        transform.position = Respawn.position;
        transform.rotation = Respawn.rotation;
        controller.enabled = true;
    }
}

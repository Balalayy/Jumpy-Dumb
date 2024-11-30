using UnityEngine;

public class Player : MonoBehaviour
{
    // «десь вы можете добавить пол€ и методы, необходимые дл€ управлени€ вашим персонажем.

    // ѕример метода дл€ передвижени€ персонажа
    public float moveSpeed = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + movement);
    }
}
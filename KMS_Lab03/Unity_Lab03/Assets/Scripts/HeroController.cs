using UnityEngine;

public class HeroController : MonoBehaviour
{
    public Renderer objectRenderer;
    public float moveSpeed = 5f;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
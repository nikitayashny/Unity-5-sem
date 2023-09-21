using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 100;
    private Rigidbody rb;
    private Renderer sphereRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 10f;
        sphereRenderer = rb.GetComponent<Renderer>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 1.51)
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Color newColor = Random.ColorHSV();
            sphereRenderer.material.color = newColor;
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
    }
}

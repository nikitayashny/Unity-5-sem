using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_06_Car : MonoBehaviour
{
    public Renderer objectRenderer;

    public int score = 0;
    public float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectRenderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

}

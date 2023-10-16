using UnityEngine;

public class Task_05 : MonoBehaviour
{
    public float speed = 20f;
    public float scaleChangeAmount = 0.01f;

    private bool IsOnTrigger = false;
    private Rigidbody sphereRigidbody;
    private Vector3 initialScale;

    void Start()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
        initialScale = transform.localScale;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        sphereRigidbody.AddForce(movement * speed);

        if (IsOnTrigger)
        {
            transform.localScale += new Vector3(scaleChangeAmount, scaleChangeAmount, scaleChangeAmount);
        }
        else if (!IsOnTrigger && transform.localScale != initialScale)
        {
            transform.localScale -= new Vector3(scaleChangeAmount, scaleChangeAmount, scaleChangeAmount);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            IsOnTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            IsOnTrigger = false;
        }
    }
}
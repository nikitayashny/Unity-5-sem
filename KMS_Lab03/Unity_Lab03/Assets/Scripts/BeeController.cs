using UnityEngine;

public class BeeController : MonoBehaviour
{
    public Transform player;
    public Transform sun;
    public float chaseDistance = 5f;
    public float maxSpeed = 5f;
    public float minSpeed = 2f;

    public float currentSpeed;

    void Start()
    {
        currentSpeed = maxSpeed;
    }

    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        if (distanceToPlayer <= chaseDistance && Vector3.Dot(transform.forward, directionToPlayer.normalized) > 0)
        {
            Vector3 chaseDirection = directionToPlayer.normalized;
            transform.forward = chaseDirection;

            float distanceToSun = Vector3.Distance(transform.position, sun.position);
            currentSpeed = Mathf.Lerp(minSpeed, maxSpeed, distanceToSun / chaseDistance);

            transform.position += chaseDirection * currentSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        HeroController player = other.GetComponent<HeroController>();
        if (player != null)
        {
            player.moveSpeed = 0f;
            player.objectRenderer.material.color = Color.red;
        }
        Debug.Log("You died.");
        Time.timeScale = 0f;
    }
}
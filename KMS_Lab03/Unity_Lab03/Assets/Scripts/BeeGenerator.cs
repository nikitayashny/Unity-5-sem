using UnityEngine;

public class BeeGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObjects = 20;
    public float spawnRadius = 10f;

    void Start()
    {
        Vector3 initialPosition = transform.position;

        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomOffset = Random.insideUnitSphere * spawnRadius;
            Vector3 spawnPosition = initialPosition + randomOffset;
            Quaternion randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
            GameObject spawnedObject = Instantiate(prefab, spawnPosition, randomRotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        HeroController player = other.GetComponent<HeroController>();
        if (player != null)
        {
            player.moveSpeed = 0f;
            player.objectRenderer.material.color = Color.green;
        }
        Debug.Log("You win.");
        Time.timeScale = 0f;
    }
}
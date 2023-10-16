using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab; 
    public GameObject spherePrefab; 
    public float planeSizeX = 100f; 
    public float planeSizeZ = 20000f; 
    public float zInterval = 10f; 

    private void Start()
    {
        GenerateCubes();
    }

    private void GenerateCubes()
    {
        float z = -10000f;
        while (z <= planeSizeZ)
        {
            if (Mathf.Abs(z) % zInterval == 0)
            {
                float x = Random.Range(-planeSizeX / 2f, planeSizeX / 2f);
                float x2 = Random.Range(-planeSizeX / 2f, planeSizeX / 2f);
                float y = 0f;
                Vector3 position = new Vector3(x, y, z);
                Vector3 position2 = new Vector3(x2, y, z);
                Instantiate(cubePrefab, position, Quaternion.identity);
                Instantiate(spherePrefab, position2, Quaternion.identity);
            }

            z += zInterval;
        }
    }
}
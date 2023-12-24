using UnityEngine;

public class CameraC : MonoBehaviour
{
    public Camera mainCamera; 
    public Camera secondCamera; 
    public KeyCode switchKey = KeyCode.C; 

    void Start()
    {

        mainCamera.enabled = true;
        secondCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondCamera.enabled = !secondCamera.enabled;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class CounterScript1 : MonoBehaviour
{
    public float force = 100f;
    public Camera camera;
    public EventSystem eventSystem;

    void Update()
    {
        if (!(Input.GetMouseButtonDown(0) && !eventSystem.IsPointerOverGameObject())) return;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit)) return;

        var direction = hit.transform.position - camera.transform.position;
        hit.transform.GetComponent<Rigidbody>()?.AddForce(direction * force);
    }
}
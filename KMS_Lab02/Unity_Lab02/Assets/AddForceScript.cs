using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "Cube_Rotate") 
        {
            myCollision.rigidbody.AddForce(1000f, 0f, 0f);
        }
    }
}

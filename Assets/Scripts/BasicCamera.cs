using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCamera : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 2.0f, 0);
    public Vector3 reverseRotation = new Vector3(0, -2.0f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.P))
        {
            this.GetComponent<Transform>().Rotate(rotation);
        }

        if (Input.GetKey(KeyCode.O))
        {
            this.GetComponent<Transform>().Rotate(reverseRotation);
        }

    }
}

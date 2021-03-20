using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAdvance : MonoBehaviour
{
    public Vector3 movement = new Vector3(0.1f, 0, 0);
    // Object will stop after a certain point
    //private Vector3 stopMovement = new Vector3(350f, 0, 0);
    //private Vector3 halt = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (transform.position.x <= 350f)
        {
            this.GetComponent<Transform>().Translate(movement);
        }
    }
}

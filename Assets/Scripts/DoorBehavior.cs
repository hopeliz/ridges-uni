using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public bool doorOpensClockwise = false;
    public float doorClosedRotation;
    public float doorOpenLimit;
    public bool doorClosed = true;

    // Start is called before the first frame update
    void Start()
    {
        if (doorClosed)
        {
            doorClosedRotation = transform.rotation.z;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z > doorOpenLimit)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, doorOpenLimit, transform.rotation.w);
        }

        if (transform.rotation.z < doorClosedRotation)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, doorClosedRotation, transform.rotation.w);
        }
    }
}

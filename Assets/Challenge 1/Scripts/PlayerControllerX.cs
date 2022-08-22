using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15.0f;
    private float rotationSpeed = 100.0f;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime * verticalInput);

        // tilt the plane up/down based on up/down arrow keys
     //   transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);

    }
}

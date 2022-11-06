using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalnput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //User Input
        horizontalnput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn the vehicle
        transform.Rotate(Vector3.up * turnSpeed * horizontalnput * Time.deltaTime);
    }
}

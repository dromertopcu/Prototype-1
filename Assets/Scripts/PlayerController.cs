using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed;
    [SerializeField] float horsePower = 0;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] TextMeshProUGUI speedometerText;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // We get the Player Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        //transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);

        playerRb.AddRelativeForce(forwardInput * horsePower * Vector3.forward);

        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
        speedometerText.SetText("Speed: " + speed + " kph");
    }
}
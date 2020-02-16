using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    // Get the force that is holding the player upright
    ConstantForce objectForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        SpringJoint joint = GetComponent<SpringJoint>();
        Rigidbody connectedComponent = joint.connectedBody;
        objectForce = connectedComponent.GetComponent<ConstantForce>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Calculate the appropriate y value for the upward force
        float yForce = Mathf.Lerp(0.0f, 170.0f, 170.0f - objectForce.force.x);

        Vector3 tilt = new Vector3(0.0f, yForce, 0.0f);
        Vector3 previousForce =
            new Vector3(objectForce.force.x * moveHorizontal * 0.1f,
                        0.0f,
                        objectForce.force.z * moveVertical * 0.1f);

        objectForce.force = tilt + previousForce;

        // Change the tilt of the player depending on which way they are going
        //objectForce.force = tilt + movement;

        // Move the player in that direction
        rb.AddForce(movement * speed);
    }
}

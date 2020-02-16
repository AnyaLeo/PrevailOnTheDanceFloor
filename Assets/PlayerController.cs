using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public bool playerFell = false; 

    private Rigidbody rb;

    ConstantForce objectForce;

    float maxYForce;

    private GlobalScore gameMode;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Get the force that is holding the player upright
        SpringJoint joint = GetComponent<SpringJoint>();
        Rigidbody connectedComponent = joint.connectedBody;
        objectForce = connectedComponent.GetComponent<ConstantForce>();

        // Get the maximum y force that we can apply to the body to keep it upright
        maxYForce = objectForce.force.y;
        gameMode = transform.parent.parent.parent.parent.gameObject.GetComponent<GlobalScore>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //// Calculate the appropriate y value for the upward force
        //// NOTE: Disabled because it doesn't fit with the current game mode
        //// of pushing people off instead of being knocked down
        //float yForceValueToClamp = maxYForce - (Mathf.Abs(objectForce.force.x) + Mathf.Abs(objectForce.force.z));
        //float yForce = Mathf.Clamp(yForceValueToClamp, 0.0f, maxYForce);

        //// Apply the object force corresponding to which direction the character is walking in
        //Vector3 tilt = new Vector3(0.0f, yForce, 0.0f);
        //Vector3 previousForce =
        //    new Vector3(objectForce.force.x + moveHorizontal * 0.1f,
        //                0.0f,
        //                objectForce.force.z + moveVertical * 0.1f);
        //objectForce.force = tilt + previousForce;

        // Move the player in that direction
        rb.AddForce(movement * speed);

        if (rb.position.y < 0f)
        {   

            SpringJoint joint = GetComponent<SpringJoint>();
            if (joint)
            {
                Destroy(joint);
            }
            if(!playerFell)
            {
                playerFell = true;
                gameMode.setMainMainPlayerFell();
            }
        }
    }
}

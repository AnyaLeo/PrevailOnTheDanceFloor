using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalking : MonoBehaviour
{
    private float latestDirectionChangeTime;
    public float directionChangeTime = 3f;
    public float characterVelocity = 2f;
    private Vector3 movementDirection;
    private Vector3 movementPerSecond;
    public GameObject player;


    void Start()
    {
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }

    void calcuateNewMovementVector()
    {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        movementDirection = new Vector3(Random.Range(-1.0f, 1.0f),0, Random.Range(-1.0f, 1.0f)).normalized;
        if (this.player != null)
        {
            Vector3 heading = this.player.transform.position - this.transform.position;
            heading.y = 0;
            heading = heading.normalized;
            movementDirection += heading;
            movementDirection = movementDirection.normalized;
        }

        movementPerSecond = movementDirection * characterVelocity;

    }

    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }

        //move enemy: 
        transform.position = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime), transform.position.y,
        transform.position.z + (movementPerSecond.z * Time.deltaTime));

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public void Toss(Vector3 direction) {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        Vector3 diceVelocity = rigidBody.velocity;

        float directionX = Random.Range(0, 500);
        float directionY = Random.Range(0, 500);
        float directionZ = Random.Range(0, 500);

        rigidBody.AddForce((direction - transform.position) * 200);
        rigidBody.AddTorque(directionX, directionY, directionZ);
    }
}

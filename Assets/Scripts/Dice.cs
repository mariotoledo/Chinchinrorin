using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Rigidbody rigidBody;

    public void Toss(Vector3 direction) {
        rigidBody = GetComponent<Rigidbody>();

        float directionX = Random.Range(0, 500);
        float directionY = Random.Range(0, 500);
        float directionZ = Random.Range(0, 500);

        rigidBody.AddForce((direction - transform.position) * 100);
        rigidBody.AddTorque(directionX, directionY, directionZ);
    }

    private void OnCollisionStay(Collision other) {
        if(rigidBody.velocity == Vector3.zero) {
            Debug.Log("Stoped: " + gameObject.name + " " + other.gameObject.name);
        }
    }
}

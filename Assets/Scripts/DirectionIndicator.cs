using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionIndicator : MonoBehaviour
{
    int direction = 1;
    float velocity = 0.01f;
    float maxRadius = 1.5f;

    bool isActive = false;

    public void StartIndicator() {
        gameObject.SetActive(true);
        transform.position = new Vector3(0, transform.position.y, transform.position.z);

        isActive = true;
    }

    public void StopIndicator() {
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive) {
            transform.position += new Vector3(velocity, 0, 0);

            if(transform.position.x > maxRadius || transform.position.x < -maxRadius) {
                velocity *= -1;
            }
        }
    }
}

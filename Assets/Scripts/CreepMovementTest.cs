using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepMovementTest : MonoBehaviour
{
    public float speed = 50f;
    public float roationSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * roationSpeed * Time.deltaTime);
    }
}

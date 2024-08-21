using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public int jumpPower;

    public Rigidbody rigidbody;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 Offset;

    public void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    public void Update()
    {
        transform.position = playerTransform.position + Offset;

    }
}

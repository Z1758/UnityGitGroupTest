using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpPower;
    public Rigidbody rigid;
    public bool jumpState;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpState == false)
            {
                rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                jumpState = true;
            }


        }

        if (this.transform.position.y <= 1)
        {
            jumpState = false;

        }
    }
}

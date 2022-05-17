using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //BUG FIX OF ADDING TOO MUCH FORCE
        if(Math.Abs(rb.velocity.y) > 6.0f){
            Vector3 curr = rb.velocity;
            curr.Normalize();
            rb.velocity = curr * 6;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.GetComponent<MeshRenderer>().materials[0].color.IsEqualTo(new Color(0.169f, 0.169f, 0.169f, 1.000f))) {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}

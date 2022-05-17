using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    public float rotateSpeed;
    public float moveX;
    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0)){
            transform.Rotate(0, -moveX * rotateSpeed * Time.deltaTime, 0);
        }
    }
}

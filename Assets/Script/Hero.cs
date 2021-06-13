using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    float mspeed = 2.0f;
    float spinspeed = 180f;
    void Start()
    {

    }

    void Update()
    {
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * mspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * mspeed * Time.deltaTime);
        }*/
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * mspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * mspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)){ transform.Rotate(Vector3.up * spinspeed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Rotate(-Vector3.up* spinspeed * Time.deltaTime); }
    }
}

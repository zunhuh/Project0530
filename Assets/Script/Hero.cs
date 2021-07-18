using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float mspeed = 5.0f;
    float spinspeed = 180f;
    public GameObject rocket;
    public GameObject fire_pos;
    public Rigidbody rigidbody;
    public int hp_cur = 100;
    public int hp_max = 100;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){transform.Translate(Vector3.forward * mspeed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.DownArrow)){ transform.Translate(Vector3.back * mspeed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.RightArrow)){ transform.Rotate(Vector3.up * spinspeed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Rotate(-Vector3.up* spinspeed * Time.deltaTime); }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); 
        }
        

    }
    void Shoot()
    {
        GameObject go = Instantiate(rocket);
        go.transform.position = fire_pos.transform.position;
        go.transform.rotation = fire_pos.transform.rotation;
    }


}

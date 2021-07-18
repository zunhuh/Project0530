using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{   
    // Start is called before the first frame update
    
    enum eState 
    {
        idle,
        move,
        attack,
        hit,
        die
    }
    eState state = eState.idle; 
    float state_time = 0f;
    float move_speed = 2.0f;
    GameObject hero;
    void Start()
    {
        hero = GameObject.Find("Hero");
    }
    // Update is called once per frame
    void Update()
    {
        State_update();
    }
    void Move()
    {
        transform.position += transform.forward * move_speed * Time.deltaTime;
    }
    void State_start(eState s)
    {
        state = s;

        }
    }
    void State_update()
    {
                  if (Vector3.Distance(hero.transform.position, transform.position) < 2.0f)
                    State_start(eState.attack);
                if (Time.time > state_time)
                    State_start(eState.idle);
                    break;
                if ( Time.time> state_time)
                    State_start(eState.idle);
                break;


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name.Contains("Rocket"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScenePlay sc = GameObject.Find("Scene").GetComponent<ScenePlay>();
            sc.score++;
        }
    }
}
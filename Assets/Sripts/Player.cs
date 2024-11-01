using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    //public Rigidbody2D rb;

    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("left_move")){
            transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
        }
        if(Input.GetButton("right_move")){
            transform.Translate(new Vector2(1, 0) * speed * Time.deltaTime);
        }
        if(Input.GetButton("up_move")){
            transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
        }
        if(Input.GetButton("down_move")){
            transform.Translate(new Vector2(0, -1) * speed * Time.deltaTime);
        }
    }
}

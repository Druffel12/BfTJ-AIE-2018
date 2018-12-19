using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    public float Speed;

    public Rigidbody rb;

    Animator anim;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();

        anim = gameObject.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
       
	}

    void Movement()
    {
        Vector3 Pos = transform.position;

        bool away = Input.GetKey("w");
        anim.SetBool("AwayFromCam", away);

        bool towards = Input.GetKey("s");
        anim.SetBool("TowardsCam", towards);

        bool left = Input.GetKey("a");
        anim.SetBool("MovingLeft", left);

        bool right = Input.GetKey("d");
        anim.SetBool("MovingRight", right);

        if (away)
        {
            Pos.z += Speed * Time.deltaTime;
            Debug.Log("moving away from cam");
        }

        else if (towards)
        {
            Pos.z -= Speed * Time.deltaTime;
            Debug.Log("moving toward cam");
        }

        else if (left)
        {
            Pos.x -= Speed * Time.deltaTime;
            Debug.Log("moving left");
        }

        else if (right)
        {
            Pos.x += Speed * Time.deltaTime;
            Debug.Log("moving right");
        }

        transform.position = Pos;
    }

    //void ItemClick()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //    }
    //}
}

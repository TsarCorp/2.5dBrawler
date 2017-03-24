using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;
    private SpriteRenderer sr;
    public float speedMod = 10;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetAxis("Horizontal"))>0){
            rb.AddForce(Vector3.left * speedMod);
            anim.SetBool("isWalking", true);
            sr.flipX = false;
        } else if ((Input.GetAxis("Horizontal")) < 0)
        {
            rb.AddForce(Vector3.right * speedMod);
            anim.SetBool("isWalking", true);
            sr.flipX = true;
        } else { anim.SetBool("isWalking", false); }

        if ((Input.GetAxis("Vertical")) < 0)
        {
            rb.AddForce(Vector3.forward * speedMod);
            anim.SetBool("isWalking", true);
            // sr.flipX = false;
        }
        else if ((Input.GetAxis("Vertical")) > 0)
        {
            rb.AddForce(Vector3.back * speedMod);
            anim.SetBool("isWalking", true);
            //sr.flipX = true;
        }
        // else { anim.SetBool("isWalking", false); }

        rb.AddForce(Vector3.back * speedMod);

        //print(Input.GetAxis("Horizontal"));
        print(rb.velocity);

       
        
        
    }
}

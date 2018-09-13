using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movee : MonoBehaviour {
    public float speed;
    Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
        
	}

    // Update is called once per frame

    private void FixedUpdate()
    {
        float movH = Input.GetAxisRaw("Horizontal");
        float movV = Input.GetAxisRaw("Vertical");



        Vector3 movement = new Vector3(movH, 0.0f, movV);
        rb.AddForce(movement * speed);

        
    }
    void Update () {
		



	}
}

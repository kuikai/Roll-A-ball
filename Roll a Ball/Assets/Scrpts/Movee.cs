using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Movee : MonoBehaviour {
    public float speed;
    Rigidbody rb;

    public Text CountText;
    public Text winText;
    private int count;
	void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        CountText.text = "count" + count.ToString();
        winText.text = "";
 	}

    // Update is called once per frame

    private void FixedUpdate()
    {
        float movH = Input.GetAxisRaw("Horizontal");
        float movV = Input.GetAxisRaw("Vertical");



        Vector3 movement = new Vector3(movH, 0.0f, movV);
        rb.AddForce(movement * speed);
        SetCountText();


    }
    void Update () {
		



	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();

            if (count == 8)
            {
                winText.text = "Win";
            }

        }
    }
    void SetCountText()
    {
        CountText.text = "count: " + count.ToString();
        
    }
}

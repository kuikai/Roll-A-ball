using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater : MonoBehaviour {

    float smooth = 5.0f;
    bool rotate = true;
	// Update is called once per frame
	void Update () {

        while (rotate==true)
        {
            Quaternion Taget = Quaternion.Euler(1, 1, 1);

            transform.rotation = Quaternion.Slerp(transform.rotation, Taget, Time.deltaTime * smooth);
        }
        }
}

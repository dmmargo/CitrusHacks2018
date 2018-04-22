
using UnityEngine;

public class Fly : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 1000f;

	void FixedUpdate () {

        //add a forward force
        rb.AddForce(0, sideForce * Time.deltaTime, forwardForce * Time.deltaTime);
		
	}
}

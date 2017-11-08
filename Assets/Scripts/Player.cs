using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float VerticalSpeed = 3.0f;

	private Rigidbody2D rb2D;
	// Use this for initialization
	void Start ()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb2D.AddForce(transform.up * 300);
		}
		var verticalDirection = 0;
		if (Input.GetKey(KeyCode.A))
		{
			verticalDirection -= 1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			verticalDirection += 1;
		}
		var xVelocity = verticalDirection * VerticalSpeed;
		var velocity = rb2D.velocity;
		velocity.x = xVelocity;
		rb2D.velocity = velocity;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public float speed;

	private new Rigidbody rigidbody;
	private Vector3 vector3;

	private const float number_Of_Directions = 1.0f;

	void Start () 
	{
		vector3 = Vector3.zero;

		rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = vector3;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
			vector3.z = number_Of_Directions;
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
			vector3.z = -number_Of_Directions;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
			vector3.x = number_Of_Directions;
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
			vector3.x = -number_Of_Directions;
		}
		else
		{
			vector3 = Vector3.zero;
		}

		if(Input.GetKeyDown(KeyCode.A))
		{
			transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
		}

		rigidbody.velocity = vector3 * speed;
	}

	public void OnCollisionEnter(Collision col)
	{
		
	}
}

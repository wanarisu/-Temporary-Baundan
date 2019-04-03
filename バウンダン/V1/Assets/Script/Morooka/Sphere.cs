using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
	private new Rigidbody rigidbody;

	public float xMax = 0.5f;
	public float zMax = 1.0f;

	private Vector3 progressVector_F;     //　進行ベクトル

	public float speed;

	void Start ()
	{
		rigidbody = GetComponent<Rigidbody>();
		progressVector_F = new Vector3(xMax, 0, zMax);
		rigidbody.velocity = progressVector_F.normalized * speed;
	}

	void Update ()
	{
		//transform.position += progressVector_F;
	}

	void ReflectionVector()
	{
	}

	public void OnCollisionEnter(Collision col)
	{
		Vector3 normalVector_N = Vector3.zero;
		Vector3 vecocity = Vector3.zero;

		normalVector_N = col.contacts[0].normal;

		vecocity = progressVector_F + (2 * Vector3.Dot(-progressVector_F, normalVector_N) * normalVector_N);
		progressVector_F = vecocity;
		rigidbody.velocity = vecocity.normalized * speed;
	}

	private void OnCollisionStay(Collision collision)
	{
		
	}

	//　スカラー積の計算
	private Vector3 ScalarProductCalculation(Vector3 a, Vector3 b)
	{
		a.x *= b.x;
		a.y *= b.y;
		a.z *= b.z;

		return a;
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviourPun {

	public Transform target;

	public float speed = 5f;
	public float rotateSpeed = 200f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	void FixedUpdate () {
		if (target == null) return;

		Vector2 direction = (Vector2)target.position - rb.position;

		direction.Normalize();

		float rotateAmount = Vector3.Cross(direction, transform.up).z;

		rb.angularVelocity = -rotateAmount * rotateSpeed;

		rb.velocity = transform.up * speed;
	}

	void OnTriggerEnter2D ()
	{
		// Put a particle effect here
		//Destroy(gameObject);
	}
}
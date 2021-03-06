﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int health = 100;
	public float playerMovementSpeed = 5.0f;
	public float mouseSens = 5.0f;
	public float rangeUpDown = 60f;
	float verticalRotation = 0;
	public float verticalVelocity = 0;
	public float jumpSpeed = 5f;
	public int maxnumberOfJumps = 1;
	int numberOfJumps;

	// Use this for initialization
	void Start ()
	{
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// CameraRot

			//Horizontal
		float rotLeftRight = Input.GetAxis("Mouse X") * mouseSens;
		transform.Rotate(0 , rotLeftRight, 0);

			//Vertical
		verticalRotation -= Input.GetAxis("Mouse Y") * mouseSens;
		verticalRotation = Mathf.Clamp (verticalRotation, -rangeUpDown, rangeUpDown);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);




		//MoveMentCommands
		float ForwardSpeed = Input.GetAxis ("Vertical") * playerMovementSpeed;
		float SideSpeed = Input.GetAxis ("Horizontal")* playerMovementSpeed;

		Vector3 speed = new Vector3(SideSpeed, verticalVelocity, ForwardSpeed);

		speed = transform.rotation * speed;
	
		CharacterController cc = GetComponent<CharacterController> ();
		cc.Move (speed * Time.deltaTime);


		//Gravity

		verticalVelocity += Physics.gravity.y * Time.deltaTime;

		//verticalVelocity = jumpSpeed;



		if (cc.isGrounded)  {

			numberOfJumps = maxnumberOfJumps;
		
		}

		if (Input.GetButtonDown ("Jump")) 	{
			if (numberOfJumps > 0)
			{
				verticalVelocity = jumpSpeed;
			}
			numberOfJumps -= 1;
		}
	}

	void TakeDamage () {
		health -= 10;
	}

	void OnGUI() {
		GUI.Box(new Rect(10, 10, 75, 25), "Health " + health.ToString());
		
	}

	public int getHealth(){
		return health;
	}

}


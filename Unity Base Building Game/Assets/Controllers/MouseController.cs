﻿using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	public GameObject circleCursor;

	Vector3 lastFramePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 currFramePosition = Camera.main.ScreenToWorldPoint( Input.mousePosition );
		currFramePosition.z = 0;

		// Update the circle cursor position
		circleCursor.transform.position = currFramePosition;


		// Handle screen dragging
		if( Input.GetMouseButton(1) || Input.GetMouseButton(2) ) {	// Right or Middle Mouse Button

			Vector3 diff = lastFramePosition - currFramePosition;
			Camera.main.transform.Translate( diff );

		}

		lastFramePosition = Camera.main.ScreenToWorldPoint( Input.mousePosition );
		lastFramePosition.z = 0;
	}
}

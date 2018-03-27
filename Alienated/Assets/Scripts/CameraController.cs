﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerController player;

	public bool isFollowing;

	public float xOffset;
	public float yOffset;

	void Start () 
	{
		player = FindObjectOfType<PlayerController> ();

		isFollowing = true;
	}

	void Update () 
	{
		if (isFollowing)
			transform.position = new Vector3 (player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
	}
}

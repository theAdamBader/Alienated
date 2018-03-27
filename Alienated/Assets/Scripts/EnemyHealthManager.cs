﻿using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

	public int enemyHealth;

	public GameObject deathEffect;

	public int pointsOnDeath;

	void Start () 
	{
		
	}
	

	void Update () 
	{
		if (enemyHealth <= 0) 
		{
			Instantiate (deathEffect, transform.position, transform.rotation);
			ScoreManager.AddPoints (pointsOnDeath);
			Destroy (gameObject);
		}
	}


	public void giveDamage(int damageToGive)
	{
		enemyHealth -= damageToGive;
		GetComponent<AudioSource> ().Play ();
	}
}

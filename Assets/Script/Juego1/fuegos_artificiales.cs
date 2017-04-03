﻿using UnityEngine;
using System.Collections;

public class fuegos_artificiales : MonoBehaviour {

	public GameObject fuegorojo;
	public GameObject fuegoamarillo;

	private ParticleSystem ParticulaR;
	private ParticleSystem ParticulaA;
	// Use this for initialization
	void Start () {

		ParticulaR = fuegorojo.GetComponent<ParticleSystem>();
		ParticulaA= fuegoamarillo.GetComponent<ParticleSystem>();
		ParticulaR.Stop ();
		ParticulaA.Stop ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ControlTarget.fuegos) {
			ParticulaR.Play ();
			ParticulaA.Play ();
			ControlTarget.fuegos = false;
		}
	}
}

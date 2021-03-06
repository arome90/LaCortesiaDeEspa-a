﻿using UnityEngine;
using System.Collections;

public class AccionCuadro : MonoBehaviour {

	private Animator anim;
	private AudioSource audio;
	
	void Start () {
		this.anim = this.GetComponent<Animator> ();
		this.audio = this.gameObject.GetComponent<AudioSource> ();
	}
	
	void OnMouseDown() {
		if (Tracker.T () != null) {
			Tracker.T ().Click(Input.mousePosition.x, Input.mousePosition.y, this.gameObject.name);
		}

		this.anim.Play ("Parpadeo");
		this.audio.Play ();
	}
}
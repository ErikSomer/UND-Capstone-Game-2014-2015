﻿//Michael Schilling
//CSci 448
using UnityEngine;
using System.Collections;

public class Rock : Carriable {
	
	void OnCollisionEnter(Collision col) {
		if (!audio.isPlaying) {
			audio.Play ();
		}
	}
}

﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class googlyEyeAnim : MonoBehaviour {

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		StartCoroutine (blink ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator blink (){

		while (true){



			int chance = Random.Range (0, 10);

			if (chance == 1) {
				sr.enabled = false;
				yield return new WaitForSeconds (0.1f);
				sr.enabled = true;
			}


			yield return new WaitForSeconds (Random.Range(0,5f));
		}
	}


}

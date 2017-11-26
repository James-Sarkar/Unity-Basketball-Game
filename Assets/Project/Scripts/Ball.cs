using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject trailObject;

	// Use this for initialization
	void Start () {
		trailObject.SetActive (false);
	}

	// Use this to active trail object
	public void ActivateTrail () {
		trailObject.SetActive (true);
	}
}

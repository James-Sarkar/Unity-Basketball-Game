using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {

	public GameObject effectObject;

	// Use this for initialization
	void Start () {
		effectObject.SetActive (false);
	}

	// Use this to trigger the score effect only when  
	// the basketball goes through the hoop
	void OnTriggerEnter (Collider otherCollider) {
		if (otherCollider.GetComponent<Ball> () != null) {
			effectObject.SetActive (true);
		}
	}
}

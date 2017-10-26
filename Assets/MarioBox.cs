using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioBox : MonoBehaviour {
	public GameObject collectableItem;
	public int maxCollectableItems;
	private int amountCollected;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {
		amountCollected++;
		if (amountCollected <= maxCollectableItems) {
			Instantiate (collectableItem, transform);
			GetComponent<AudioSource> ().Play ();
		}
	}
}

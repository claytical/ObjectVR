using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
	public int purse;
	public AudioClip collectCoin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnControllerColliderHit(ControllerColliderHit hit) {
		CollectableItem item = hit.gameObject.GetComponent<CollectableItem> ();
		if (item != null) {
			purse += item.value;
			gameObject.GetComponent<AudioSource> ().PlayOneShot (collectCoin);

			Destroy (item.gameObject);
		}

	}
}

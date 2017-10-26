using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	public float refreshTime;
	private float timeToRefresh;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeToRefresh <= Time.time) {
			Renderer r = gameObject.GetComponent<Renderer>();
			r.material.shader = Shader.Find ("Standard");
			r.material.SetColor ("_Color", Color.white);

		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Weapon") {
			Renderer r = gameObject.GetComponent<Renderer>();
			r.material.shader = Shader.Find ("Standard");
			r.material.SetColor ("_Color", Color.red);
		}
		timeToRefresh = Time.time + refreshTime;
	}
}

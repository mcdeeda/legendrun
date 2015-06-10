using UnityEngine;
using System.Collections;

public class heart_trigger : MonoBehaviour {
	
	private ParticleSystem ps;
	
	// Use this for initialization
	void Start () {
		ps = gameObject.GetComponent<ParticleSystem>();
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter() {
		ps.Play();
		Debug.Log("particles");
		Destroy (ps,0.6f);
		foreach(Transform child in transform){
			Destroy(child.gameObject);
		}
	}
}

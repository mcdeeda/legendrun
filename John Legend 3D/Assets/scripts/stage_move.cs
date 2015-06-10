using UnityEngine;
using System.Collections;

public class stage_move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
	}
}

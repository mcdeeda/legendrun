using UnityEngine;
using System.Collections;

public class dog_move : MonoBehaviour {

	public float dog_pos = 1.0f;
	public float dog_left = 7.6f;
	public float dog_center = 6.4f;
	public float dog_right = 5.2f;
	public float dog_shift = 1.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.W)){
			if(dog_pos != 0.0){
				dog_pos -= 1;
			}
			if(dog_pos == 0.0f || dog_pos == 1.0f) {
				gameObject.transform.Translate(dog_shift,0,0);
			}
		}
		if(Input.GetKeyDown(KeyCode.Q)){
			if(dog_pos !=2.0){
				dog_pos += 1;
			}
			if(dog_pos == 1.0f || dog_pos == 2.0f) {
				gameObject.transform.Translate(-dog_shift,0,0);
			}
		}
	}
}
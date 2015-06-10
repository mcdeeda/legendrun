using UnityEngine;
using System.Collections;

public class startscreen : MonoBehaviour {

	 

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("yayyyyy you pressed space");
			Application.LoadLevel (1);

		}
	
	}
}

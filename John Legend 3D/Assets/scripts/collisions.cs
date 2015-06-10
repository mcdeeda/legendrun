using UnityEngine;
using System.Collections;

public class collisions : MonoBehaviour {

	public Reset resetscript;
	public faceBehavior face;
	public AudioClip pop;
	int pl = 0;

	void OnTriggerEnter ( Collider activator ) {
		Debug.Log ("something entered the trigger! omg");
		activator.GetComponent<Rigidbody>().velocity /= 10f;// increase speed by 500%
		//this.gameObject.GetComponent<Rigidbody>().AddExplosionForce(3f,this.transform.position, 1f);
		//GetComponent<Rigidbody>().AddForce(new Vector3 (0f,0f,10f));
		if(activator.tag.Equals ("Player1"))
		{
			Score.player1Score += 1;
			pl = 1;
			face.happyFace(pl);
		}
		else if(activator.tag.Equals ("Player2"))
		{
			Score.player2Score += 1;
			pl = 2;
			face.happyFace(pl);
		}
		else if(activator.tag.Equals ("Player3"))
		{
			Score.player3Score += 1;
			pl = 3;
			face.happyFace(pl);
		}
		else if(activator.tag.Equals ("Player4"))
		{
			Score.player4Score += 1;
			pl = 4;
			face.happyFace(pl);
		}
		activator.GetComponentInChildren<ParticleSystem>().Emit(100);
		activator.GetComponentInChildren<ParticleSystem>().transform.parent = null;
		AudioSource.PlayClipAtPoint (pop, Camera.main.transform.position,2f);
		Destroy ( this.gameObject);
		resetscript.ResetBalloon();
		this.GetComponent<Collider>().enabled = false;
		Destroy ( activator.gameObject);
		// self-destruct so this powerup is used-up
		//Destroy (activator.GetComponent<Rigidbody>());
	}
}

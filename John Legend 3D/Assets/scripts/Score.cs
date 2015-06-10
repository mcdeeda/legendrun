using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	public TextMesh p1, p2, p3, p4;
	public endScreen end;
	int winner = 0;
	//public Mucus m;
	//easiest way to keep score is to use a STATIC VARIABLE

	public static int player1Score=0, player2Score=0, player3Score=0, player4Score=0;
	//public AudioClip mucus;

	// Use this for initialization
	void Start () 
	{
		//AudioSource.PlayClipAtPoint (mucus,Camera.main.transform.position,0.5f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ( player1Score );
		if ( player1Score < 10 )
			p1.text = "0" + player1Score.ToString();

		else if (player1Score >=10)
		{
			Debug.Log ("AHHHHHHHHHHHHHHH");
			p1.text = player1Score.ToString();
			winner = 2;
			end.WinScreen(winner);
			player1Score = 0;
			player2Score = 0;
			player3Score = 0;
			player4Score = 0;

			//m.destroyMucus();
		}



		if ( player2Score < 10 )
			p2.text = "0" + player2Score.ToString();

		else if (player2Score >=10)
		{
			Debug.Log ("EHHHHHHHHHHHHHHH");
			p2.text = player2Score.ToString();
			winner = 3;
			end.WinScreen(winner);
			player1Score = 0;
			player2Score = 0;
			player3Score = 0;
			player4Score = 0;

			//m.destroyMucus();
		}




		if ( player3Score < 10 )
			p3.text = "0" + player3Score.ToString();

		else if (player3Score >=10)
		{
			Debug.Log ("OHHHHHHHHHHHHHHH");
			p3.text = player3Score.ToString();
			winner = 4;
			end.WinScreen(winner);
			player1Score = 0;
			player2Score = 0;
			player3Score = 0;
			player4Score = 0;
			
			//m.destroyMucus();
		}




		if ( player4Score < 10 )
			p4.text = "0" + player4Score.ToString();

		else if (player4Score >=10)
		{

			Debug.Log ("UHHHHHHHHHHHHHHH");
			p4.text = player4Score.ToString();
			winner = 5;
			end.WinScreen(winner);
			player1Score = 0;
			player2Score = 0;
			player3Score = 0;
			player4Score = 0;

			//m.destroyMucus();
		}

	
	}
}
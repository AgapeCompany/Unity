using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GamePointColl : MonoBehaviour
{
	public static int overCollected;
	public static int addScore = 10;
	public static int CheckVibro;
	public AudioClip BulkSound; // для звука
	//public static int AllScore;
	Text ScoreText;
	
	public void Start()
	{
		ScoreText = GameObject.FindGameObjectWithTag ( "Score" ).GetComponent<Text>();
		CheckVibro = BallonSettings.VibroB;
		ScoreText.text = overCollected.ToString();
	//	overCollected = 0;
	}
	
		// Проверка на клики
		void OnMouseDown()
	{
	 // Вызываем проверку на нужный шарик
	Givepoint();
	// Вызываем проверку на неправильный шарик
	OverBallon ();
	}
	
// Проверка на нужный шарик
	public void Givepoint ()
	{
		if ( gameObject.tag == "TrueB" )
		{
		overCollected = overCollected + addScore;
		ScoreText.text = overCollected.ToString();
		Debug.Log ( "Collect=" + overCollected ) ;
		AudioSource.PlayClipAtPoint (BulkSound, transform.position);
		Destroy(this.gameObject);
		}
	}
		// Проверка на неправильный шарик
	public void OverBallon ()
	{ 
		if ( gameObject.tag == "FalseB" )
		{
		AudioSource.PlayClipAtPoint (BulkSound, transform.position);
		Vibro();
		Gameover();
		}
	}

	public void Gameover ()
	{
		GameController.boolallscore = true;
		//GameController.BalloonScore = 0;
		SceneManager.LoadScene("ReklamaColl", LoadSceneMode.Single);
	}
	public void Vibro()
	{
		if ( CheckVibro == 1 )
		{
			Handheld.Vibrate (); // Вибрация
		}
	}
			
}

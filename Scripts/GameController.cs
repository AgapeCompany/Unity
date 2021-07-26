using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public static float gamespeed = 0.2f; //Скорость шарика
	public static float SpawnDelayControl = 1.4f; // Переменная времени спавна шаров
	public static int BalloonScore;
	//public static int BalloonScoreColl;
	public static int lowhard = 30;
	public static int onehard = 50;
	public static int twohard = 100;
	public static int threehard = 150;
	public static int fourhard = 200;
	public static int fivehard = 250; //
	public static int sixhard = 350;
	public static int sevenhard = 450;
	public static int eighthard = 550;
	public static int ninehard = 650;
	public static int tenhard = 750;
	public static int GameTSpeed = 1;
	public static bool boolallscore;

	
	public void Start()
	{
		Debug.Log("Score=" + BalloonScore);
		//Debug.Log("Score=" + BalloonScoreColl);
		Time.timeScale = GameTSpeed;
	}
	
	public void Update()
	{
		BalloonScore = GamePoint.overCollected;
		//BalloonScoreColl = GamePointColl.overCollected;
		Addhard();
		//Addhardcoll();
	}
	
	//Проверка достигла ли игра 1 усложнения
	public void Addhard()
	{
		if ( BalloonScore < lowhard )
		{
			GameTSpeed = 1;
		Time.timeScale = GameTSpeed;
		}
		if ( BalloonScore >= lowhard )
		{
			Time.timeScale = 1.3f;
		}
		if ( BalloonScore >= onehard )
		{
			Time.timeScale = 1.5f;
		}
		if ( BalloonScore >= twohard )
		{
			Time.timeScale = 1.7f;
		}
		if ( BalloonScore >= threehard )
		{
			Time.timeScale = 1.9f;
		}
		if ( BalloonScore >= fourhard )
		{
			Time.timeScale = 2.1f;
		}
		if ( BalloonScore >= fivehard )
		{
			Time.timeScale = 2.3f;
		}
		if ( BalloonScore >= sixhard ) 
		{
			Time.timeScale = 2.5f;
		}
		if ( BalloonScore >= sevenhard )
		{
			Time.timeScale = 2.7f;
		}
		if ( BalloonScore >= eighthard )
		{
			Time.timeScale = 2.9f;
		}
		if ( BalloonScore >= ninehard )
		{
			Time.timeScale = 3.1f;
		}
		if ( BalloonScore >= tenhard )
		{
			Time.timeScale = 3.3f;
		}
	}
	
/*	//Проверка достигла ли игра coll усложнения
	public void Addhardcoll()
	{
		if ( BalloonScoreColl < lowhard )
		{
			GameTSpeed = 1;
		Time.timeScale = GameTSpeed;
		}
		if ( BalloonScoreColl >= lowhard )
		{
			Time.timeScale = 1.3f;
		}
		if ( BalloonScoreColl >= onehard )
		{
			Time.timeScale = 1.5f;
		}
		if ( BalloonScoreColl >= twohard )
		{
			Time.timeScale = 1.7f;
		}
		if ( BalloonScoreColl >= threehard )
		{
			Time.timeScale = 1.9f;
		}
		if ( BalloonScoreColl >= fourhard )
		{
			Time.timeScale = 2.1f;
		}
		if ( BalloonScoreColl >= fivehard )
		{
			Time.timeScale = 2.3f;
		}
	} */
}

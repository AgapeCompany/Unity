using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GameOverScr : MonoBehaviour
{
	public static int GameOScore;
	public static int BestScore;
	public static int OldBest;
	private const string leaderboard = "CgkIrqaj-7gEEAIQAA";
	Text GOScore;
	Text BestText;
	
	public void Start ()
	{
	GOScore = GameObject.FindGameObjectWithTag ( "ScoreGO" ).GetComponent<Text>();
	BestText = GameObject.FindGameObjectWithTag ( "Best" ).GetComponent<Text>();
	GameOScore = GamePoint.overCollected; // берётся из GamePoint, кол-во за уровень
	GOScore.text = GameOScore.ToString(); // Выводим рекорд за уровень
	LoadBest(); // Загружаем лучший рекорд
	BestScore = OldBest;
	CheckeBest(); //Вызываем проверку рекорда
	Time.timeScale = 1f;
	}
	//Проверка рекорда
	public void CheckeBest()
	{
		if ( BestScore < GameOScore )
		{
			BestText.text = GameOScore.ToString();
			OldBest = GameOScore;
			SaveBest();
			AddLeaderboard();
			GamePoint.overCollected = 0;
		}
		else
		{
			BestText.text = OldBest.ToString();
			AddLeaderboard();
			GamePoint.overCollected = 0;
		}
	}
	public void AddLeaderboard()
	{
			Social.ReportScore( OldBest, leaderboard, (bool success) =>
			{
				if (success) print("Удачно добавлен в таблицу");
			});	
	}
	
	//Сохранения лучшего рекорда
	public void SaveBest()
	{
		PlayerPrefs.SetInt("OldBest", OldBest);
		PlayerPrefs.Save();
	}
	//Загрузка лучшего рекорда
	public void LoadBest()
	{
		if (PlayerPrefs.HasKey("OldBest"))
		{
			OldBest = PlayerPrefs.GetInt("OldBest");
		}
	}	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCollOverScr : MonoBehaviour
{
	public static int GameOScore;
	public static int BestCollScore;
	public static int OldCollBest;
	private const string leaderboard = "CgkIrqaj-7gEEAIQAA";
	Text GOScoreColl; 
	Text BestTextColl; 
	
	public void Start ()
	{
	GOScoreColl = GameObject.FindGameObjectWithTag ( "ScoreGOColl" ).GetComponent<Text>();
	BestTextColl = GameObject.FindGameObjectWithTag ( "BestColl" ).GetComponent<Text>();
	GameOScore = GamePointColl.overCollected; // берётся из GamePoint, кол-во за уровень
	GOScoreColl.text = GameOScore.ToString(); // Выводим рекорд за уровень
	LoadBest(); // Загружаем лучший рекорд
	BestCollScore = OldCollBest;
	CheckeBest(); //Вызываем проверку рекорда
	Time.timeScale = 1f;
	}
	//Проверка рекорда
	public void CheckeBest()
	{
		if ( BestCollScore < GameOScore )
		{
			BestTextColl.text = GameOScore.ToString();
			OldCollBest = GameOScore;
			SaveBest();
			AddLeaderboard();
			GamePointColl.overCollected = 0;
		}
		else
		{
			BestTextColl.text = OldCollBest.ToString();
			GamePointColl.overCollected = 0;
		}
	}
	public void AddLeaderboard()
	{
			Social.ReportScore( OldCollBest, leaderboard, (bool success) =>
			{
				if (success) print("Удачно добавлен в таблицу");
			});	
	}

	//Сохранения лучшего рекорда
	public void SaveBest()
	{
		PlayerPrefs.SetInt("OldCollBest", OldCollBest);
		PlayerPrefs.Save();
	}
	//Загрузка лучшего рекорда
	public void LoadBest()
	{
		if (PlayerPrefs.HasKey("OldCollBest"))
		{
			OldCollBest = PlayerPrefs.GetInt("OldCollBest");
		}
	}	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallonSettings : MonoBehaviour
{
	public static int VibroB;
	public static int Lang; // 1 - Rus; 2 - Eng; 3 - Jap;
	Text VibroText;
	public static string VibroONRus = "Вибро Вкл";
	public static string VibroOFFRus = "Вибро Выкл";
	public static string VibroONEng = "Vibro ON";
	public static string VibroOFFEng = "Vibro OFF";
	public static string VibroONJap = "バイブロオン";
	public static string VibroOFFJap = "バイブロオフ";

	public void Start()
	{
		VibroText = GameObject.FindGameObjectWithTag ( "Vibro" ).GetComponent<Text>();
		VibroB = 1;
		LoadVibro();
		CheckStart();
	}
	public void Update()
	{
		LoadLang();
		LoadVibro();
		CheckStart();
	}
	public void OnBtnClick()
    {
		Check();
	}
	public void Check()
	{
		if ( VibroB == 1 )
		{
			//VibroText.text = VibroOFF.ToString();
			VibroB = 0;
			SaveVibro();
			Debug.Log ( "Vibro - Выключена") ;
		}
		else
		{
			//VibroText.text = VibroON.ToString();
			VibroB = 1;	
			Handheld.Vibrate (); // Вибрация
			SaveVibro();
			Debug.Log ( "Vibro - Включена" );
		}
	}
	public void CheckStart()
	{
		if (VibroB == 1 && Lang == 1)
		{
			VibroText.text = VibroONRus.ToString();
		}
		if (VibroB == 0 && Lang == 1)
		{
			VibroText.text = VibroOFFRus.ToString();
		}
		if (VibroB == 1 && Lang == 2)
		{
			VibroText.text = VibroONEng.ToString();
		}
		if (VibroB == 0 && Lang == 2)
		{
			VibroText.text = VibroOFFEng.ToString();
		}
		if (VibroB == 1 && Lang == 3)
		{
			VibroText.text = VibroONJap.ToString();
		}
		if (VibroB == 0 && Lang == 3)
		{
			VibroText.text = VibroOFFJap.ToString();
		}
	}

	//Сохранения лучшего рекорда
	public void SaveVibro()
	{
		PlayerPrefs.SetInt("VibroB", VibroB);
		PlayerPrefs.Save();
	}
	//Загрузка лучшего рекорда
	public void LoadVibro()
	{
		if (PlayerPrefs.HasKey("VibroB"))
		{
			VibroB = PlayerPrefs.GetInt("VibroB");
		}
	}
	//Загрузка языка
	public void LoadLang()
	{
		if (PlayerPrefs.HasKey("Lang"))
		{
			Lang = PlayerPrefs.GetInt("Lang");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musicclang : MonoBehaviour
{
	public static int Lang; // 1 - Rus; 2 - Eng; 3 - Jap;
	Text MusicText;
	public static string MusicRus = "Музыка"; // Музыка
	public static string MusicEng = "Music"; // Музыка
	public static string MusicJap = "音楽"; // Музыка

	public void Start()
	{
		MusicText = GameObject.FindGameObjectWithTag("Music").GetComponent<Text>();
		LoadLang();
		CheckStart();
	}
	public void Update()
	{
		LoadLang();
		CheckStart();
	}
	public void CheckStart()
	{
		if (Lang == 1)
		{
			MusicText.text = MusicRus.ToString();
		}
		if (Lang == 2)
		{
			MusicText.text = MusicEng.ToString();
		}
		if (Lang == 3)
		{
			MusicText.text = MusicJap.ToString();
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

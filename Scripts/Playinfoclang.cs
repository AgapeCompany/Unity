using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playinfoclang : MonoBehaviour
{
	public static int Lang; // 1 - Rus; 2 - Eng; 3 - Jap;
	Text PlayInfoText;
	public static string PlayInfoRus = "Нажми чтобы продолжить"; // Меню
	public static string PlayInfoEng = "Tap to Continue"; // Меню
	public static string VPlayInfoJap = "タップして続行"; // Меню

	public void Start()
	{
		PlayInfoText = GameObject.FindGameObjectWithTag("TTC").GetComponent<Text>();
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
			PlayInfoText.text = PlayInfoRus.ToString();
		}
		if (Lang == 2)
		{
			PlayInfoText.text = PlayInfoEng.ToString();
		}
		if (Lang == 3)
		{
			PlayInfoText.text = VPlayInfoJap.ToString();
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

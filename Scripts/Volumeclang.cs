using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumeclang : MonoBehaviour
{
	public static int Lang; // 1 - Rus; 2 - Eng; 3 - Jap;
	Text VolumeText;
	public static string VolumeRus = "Громкость музыки"; // Меню
	public static string VolumeEng = "Music Volume"; // Меню
	public static string VolumeJap = "音楽ボリューム"; // Меню

	public void Start()
	{
		VolumeText = GameObject.FindGameObjectWithTag("Volume").GetComponent<Text>();
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
			VolumeText.text = VolumeRus.ToString();
		}
		if (Lang == 2)
		{
			VolumeText.text = VolumeEng.ToString();
		}
		if (Lang == 3)
		{
			VolumeText.text = VolumeJap.ToString();
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

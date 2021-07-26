using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menuclang : MonoBehaviour
{
	public static int Lang; // 1 - Rus; 2 - Eng; 3 - Jap;
	Text MenuText;
	public static string MenuRus = "Меню"; // Меню
	public static string MenuEng = "Menu"; // Меню
	public static string MenuJap = "メニュー"; // Меню

	public void Start()
	{
		MenuText = GameObject.FindGameObjectWithTag("Menu").GetComponent<Text>();
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
			MenuText.text = MenuRus.ToString();
		}
		if (Lang == 2)
		{
			MenuText.text = MenuEng.ToString();
		}
		if (Lang == 3)
		{
			MenuText.text = MenuJap.ToString();
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

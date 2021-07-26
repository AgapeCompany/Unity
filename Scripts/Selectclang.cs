using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selectclang : MonoBehaviour
{
	public static int Lang; // 1 - Rus; 2 - Eng; 3 - Jap;
	Text SelectText;
	public static string SelectRus = "← выбор →"; // Меню
	public static string SelecEng = "← select →"; // Меню
	public static string SelecJap = "← 選択肢 →"; // Меню

	public void Start()
	{
		SelectText = GameObject.FindGameObjectWithTag("Select").GetComponent<Text>();
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
			SelectText.text = SelectRus.ToString();
		}
		if (Lang == 2)
		{
			SelectText.text = SelecEng.ToString();
		}
		if (Lang == 3)
		{
			SelectText.text = SelecJap.ToString();
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
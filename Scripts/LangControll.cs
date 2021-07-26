using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangControll : MonoBehaviour
{
	public static int Lang = 1; // 1 - Rus; 2 - Eng; 3 - Jap;
	
	
	public void Start ()
	{
		LoadLang();
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
	

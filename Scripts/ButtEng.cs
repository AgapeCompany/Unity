using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtEng : MonoBehaviour
{
	public static int Eng = 2;
	
    public void OnBtnClick()
    {
		LangControll.Lang = Eng;
		SaveLang();
	}
		//Сохранения языка
	public void SaveLang()
	{
		PlayerPrefs.SetInt("Lang", Eng);
		PlayerPrefs.Save();
	}
}

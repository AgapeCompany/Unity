using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtRus : MonoBehaviour
{
	public static int Rus = 1;
	
    public void OnBtnClick()
    {
		LangControll.Lang = Rus;
		SaveLang();
	}
		//Сохранения языка
	public void SaveLang()
	{
		PlayerPrefs.SetInt("Lang", Rus);
		PlayerPrefs.Save();
	}
}

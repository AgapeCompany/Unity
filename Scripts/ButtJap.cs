using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtJap : MonoBehaviour
{
	public static int Jap = 3;
	
    public void OnBtnClick()
    {
		LangControll.Lang = Jap;
		SaveLang();
	}
		//Сохранения языка
	public void SaveLang()
	{
		PlayerPrefs.SetInt("Lang", Jap);
		PlayerPrefs.Save();
	}
}

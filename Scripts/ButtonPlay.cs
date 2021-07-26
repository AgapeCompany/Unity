using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlay : MonoBehaviour
{
	public static int Language;
	public static int Info = 1;
	
	public void Start ()
	{
		Language = LangControll.Lang;
		LoadInfo();
	}
	
	void OnMouseDown()
	{
		if ( gameObject.tag == "Game1" )
		{
			PlayStart();
		}
	}

    public void PlayStart()
    {
		if ( Info == 1 )
		{
			CheckLangInfo();
		}
		if ( Info == 0 )
		{
		CheckLang ();
		}
	}
		
		public void CheckLang ()
		{
		if ( Language == 1 )
		{
	   SceneManager.LoadScene("GameRus", LoadSceneMode.Single);
		}
		if ( Language == 2 )
		{
	   SceneManager.LoadScene("GameEng", LoadSceneMode.Single);
		}
		if ( Language == 3 )
		{
	   SceneManager.LoadScene("GameJap", LoadSceneMode.Single);
		}
	}
			public void CheckLangInfo ()
		{
		if ( Language == 1 )
		{
	   SceneManager.LoadScene("InfoRus", LoadSceneMode.Single);
		}
		if ( Language == 2 )
		{
	   SceneManager.LoadScene("InfoEng", LoadSceneMode.Single);
		}
		if ( Language == 3 )
		{
	   SceneManager.LoadScene("InfoJap", LoadSceneMode.Single);
		}
	}
		//Загрузка языка
	public void LoadInfo()
	{
		if (PlayerPrefs.HasKey("Info"))
		{
			Info = PlayerPrefs.GetInt("Info");
		}
	}
  
}

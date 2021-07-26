using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
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
		if ( gameObject.tag == "Game2" )
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
	   SceneManager.LoadScene("GameCollorRus", LoadSceneMode.Single);
		}
		if ( Language == 2 )
		{
	   SceneManager.LoadScene("GameCollorEng", LoadSceneMode.Single);
		}
		if ( Language == 3 )
		{
	   SceneManager.LoadScene("GameCollorJap", LoadSceneMode.Single);
		}
	}
			public void CheckLangInfo ()
		{
		if ( Language == 1 )
		{
	   SceneManager.LoadScene("InfoCollRus", LoadSceneMode.Single);
		}
		if ( Language == 2 )
		{
	   SceneManager.LoadScene("InfoCollEng", LoadSceneMode.Single);
		}
		if ( Language == 3 )
		{
	   SceneManager.LoadScene("InfoCollJap", LoadSceneMode.Single);
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

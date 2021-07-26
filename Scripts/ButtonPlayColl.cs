using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayColl : MonoBehaviour
{
	public static int Language;
	
	public void Start ()
	{
		Language = LangControll.Lang;
	}


    public void OnBtnClick()
    {
		CheckLang ();
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
  
}
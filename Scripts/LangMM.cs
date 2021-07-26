using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangMM : MonoBehaviour
{
	public static int Langs;
	Image Rus;
	Image Eng;
	Image Jap;
	
	public void Start ()
	{
		Rus = GameObject.FindGameObjectWithTag ( "Rus" ).GetComponent<Image>();
		Eng = GameObject.FindGameObjectWithTag ( "Eng" ).GetComponent<Image>();
		Jap = GameObject.FindGameObjectWithTag ( "Jap" ).GetComponent<Image>();
	}
	
	public void Update ()
	{
		Langs = LangControll.Lang;
		SelectedLang();
	}
	
	public void SelectedLang ()
	{
		if ( Langs == 1 )
		{
			Rus.color = new Color(255, 255, 255, 1);
			Eng.color = new Color(255, 255, 255, 0.5f);
			Jap.color = new Color(255, 255, 255, 0.5f);
		}
				if ( Langs == 2 )
		{
			Rus.color = new Color(255, 255, 255, 0.5f);
			Eng.color = new Color(255, 255, 255, 1);
			Jap.color = new Color(255, 255, 255, 0.5f);
		}
				if ( Langs == 3 )
		{
			Rus.color = new Color(255, 255, 255, 0.5f);
			Eng.color = new Color(255, 255, 255, 0.5f);
			Jap.color = new Color(255, 255, 255, 1);
		}
	}
}

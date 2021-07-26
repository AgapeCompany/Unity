using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainmenuRecord : MonoBehaviour
{

	public static int Best;
	public static int BestColl;
	public static int BestSurp;
	Text BestText;
	Text BestCollText;
	Text BestSurpText;
	
		public void Start ()
		{
		BestText = GameObject.FindGameObjectWithTag ( "BestMM" ).GetComponent<Text>();
		BestCollText = GameObject.FindGameObjectWithTag ( "BestCollMM" ).GetComponent<Text>();
		BestSurpText = GameObject.FindGameObjectWithTag ( "BestSurpMM" ).GetComponent<Text>();
		LoadBest();
		BestText.text = Best.ToString();
		BestCollText.text = BestColl.ToString();
		BestSurpText.text = BestSurp.ToString();
		}
		
		public void LoadBest()
		{
			if (PlayerPrefs.HasKey("OldBest"))
			{
				Best = PlayerPrefs.GetInt("OldBest");
			}
			if (PlayerPrefs.HasKey("OldCollBest"))
			{
				BestColl = PlayerPrefs.GetInt("OldCollBest");
			}
			if (PlayerPrefs.HasKey("OldSurpBest"))
			{
				BestSurp = PlayerPrefs.GetInt("OldSurpBest");
			}
		}
}

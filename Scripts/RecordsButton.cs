using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;

public class RecordsButton : MonoBehaviour
{
	public void OnBtnClick()
	{
		PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIrqaj-7gEEAIQAA");
	}
}

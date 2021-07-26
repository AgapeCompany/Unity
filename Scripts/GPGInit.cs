using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;




public class GPGInit : MonoBehaviour
{


	
	//private const string leaderboard = "CgkIrqaj-7gEEAIQAA";
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesPlatform.Activate();
		Social.localUser.Authenticate((bool success) => {
			if (success) print("Удачно вошел");
			else print ("Неудачно вошел");
		});

    }
		public void OnBtnClick()
		{
        PlayGamesPlatform.Activate();
		Social.localUser.Authenticate((bool success) => {
			if (success) print("Удачно вошел");
			else print ("Неудачно вошел");
		});
		}

}

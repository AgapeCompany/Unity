using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttonssvr : MonoBehaviour
{
    public int sceneIndex;

    public void OnBtnClick()
    {
		//sceneIndex = Random.Range(1,4);
       // SceneManager.LoadScene(sceneIndex);
	   SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }
}

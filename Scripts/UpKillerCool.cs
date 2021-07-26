using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UpKillerCool : MonoBehaviour
{
	
	
	//выполнится, если другой объект с коллайдером2Д коснулся этот объект
	public void OnCollisionEnter2D (Collision2D something) {

		if (something.gameObject.tag == "Finish") {
			
			Handheld.Vibrate (); // Вибрация
			//удалить объект из сцены
	
			Destroy (gameObject);
			
				SceneManager.LoadScene("ReklamaColl", LoadSceneMode.Single);
		}
	}
}
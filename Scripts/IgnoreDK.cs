using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreDK : MonoBehaviour
{
	//выполнится, если другой объект с коллайдером2Д коснулся этот объект
	public void OnCollisionEnter2D (Collision2D something) {

		if (something.gameObject.tag == "Finish") {
			//удалить объект из сцены
			Destroy (gameObject);
		}
	}
}

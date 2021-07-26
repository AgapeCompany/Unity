using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
	public static float speed = 4; // переменная скорости
	Rigidbody2D rb; //переменная для ссылки на Rigidbody2D
	
	//выполнится 1 раз при старте скрипта
	void Start () {
		

		rb = GetComponent < Rigidbody2D > ();
		//декларируем новый вектор с инициализацией направления движения
		Vector3 move = new Vector3 (6, 0, -10);
		//меняем вектор движения
		rb.velocity = move * speed;
	}
}

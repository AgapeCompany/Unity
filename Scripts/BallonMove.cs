using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonMove : MonoBehaviour
{

	public static float speed; // переменная скорости
	Rigidbody2D rb; //переменная для ссылки на Rigidbody2D
	
	//выполнится 1 раз при старте скрипта
	void Start () {
		
		speed = GameController.gamespeed; // берём скорость из GC

		rb = GetComponent < Rigidbody2D > ();
		//декларируем новый вектор с инициализацией направления движения
		Vector3 move = new Vector3 (0, 10, 0);
		//меняем вектор движения
		rb.velocity = move * speed;
	}
		//исполнится если объект перестал отображаться на экране
	void OnBecameInvisible () {
		//уничтожить объект
		Destroy (gameObject);
	}
}

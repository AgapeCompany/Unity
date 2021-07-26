﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnB2 : MonoBehaviour
{
	//переменная для ссылки на позицию, которую будем использовать как правую границу спавна
	public Transform RightPosition;
	//задержка между спавнами
	float spawnDelay = 1;
	//массив для объектов спавна
	public GameObject [] Item;

	//выполняется один раз
	public void Start () {

		//запуск периодичного вызова функции для спавна
		InvokeRepeating ("Spawn", spawnDelay, spawnDelay);
	}


	//функция спавна
	void Spawn () {
		//случайная позиция между Spawner и RSpawner
		Vector3 spawnPos = new Vector3 (Random.Range (transform.position.x, RightPosition.position.x), transform.position.y, 0);
		//случайное int значение от 0 до максимальной длины массива (количество объектов в нём)
		int i = Random.Range (0, Item.Length);
		//поместить оьъект на случайную позицию
		Instantiate (Item [i], spawnPos, transform.rotation);
	}
}

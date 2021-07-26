using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CamScroller : MonoBehaviour
{
		public float speed;
		//private Vector2 startPos;
		public Camera cam;
		//private float targetPos;
	//	private float ttt;
	
	private void Start()
	{
		//cam = GetComponent<Camera>();
		//targetPos = transform.position.x;
		
	}

	void OnMouseDown()
	{
		if ( gameObject.tag == "RightS" )
		{
			Butright();
		}
		if ( gameObject.tag == "LeftS" )
		{
			Butleft();
		}
	} 
			
	public void Butright()
	{
		cam.transform.position = new Vector3 ( 6, 0, -10 );
	}
	
	public void Butleft()
	{
		cam.transform.position = new Vector3 ( 0, 0, -10 );
	}
		
/*	private void Update()
	{
		if ( Input.GetMouseButtonDown(0)) startPos = cam.ScreenToWorldPoint(Input.mousePosition);
		
		else if (Input.GetMouseButton(0))
		{
			float pos = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
			//transform.position = new Vector3 (Mathf.Clamp(transform.position.x - pos, 0f, 6f), transform.position.y, transform.position.z);
			targetPos = Mathf.Clamp (transform.position.x - pos, 0f, 6f);
		}
			transform.position = new Vector3 ( Mathf.Lerp(transform.position.x, targetPos, speed * Time.deltaTime), transform.position.y, transform.position.z);
	}*/
	
}
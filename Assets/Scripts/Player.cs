using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	private Vector2 mousePos;
	private KillCounter _counter;

    void Start()
    {
		_counter = GameObject.Find("Kill count").GetComponent<KillCounter>();
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//mousePos = Input.mousePosition;
			//Debug.Log(mousePos);
			if (Physics.Raycast(ray))
			{
				_counter.AddScore();
				Debug.Log(ray);
			}
		}
    }
}

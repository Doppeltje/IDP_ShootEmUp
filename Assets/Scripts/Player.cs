using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	private Vector2 mousePos;
	private KillCounter _counter;
    public GameObject enemy;
    Vector3 lastPos;

    void Start()
    {
		_counter = GameObject.Find("Kill count").GetComponent<KillCounter>();
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
        lastPos = enemy.transform.position;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //mousePos = Input.mousePosition;
            //Debug.Log(mousePos);
            RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				_counter.AddScore();
                Instantiate(enemy, lastPos, Quaternion.identity);
                lastPos = hit.collider.gameObject.transform.position;
                Destroy(hit.collider.gameObject);

				Debug.Log(ray);
			}
		}
    }
}

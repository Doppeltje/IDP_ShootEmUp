using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{

	public Text killValue;

	public int value;

    void Start()
    {
		value = 0;
    }

    void Update()
    {
        
    }

	public void AddScore()
	{
		value += 1;
		killValue.text = value.ToString();
	}
}

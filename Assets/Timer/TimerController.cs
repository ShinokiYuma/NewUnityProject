using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
	public Text timerText;

	public static float totalTime;
	int seconds;


	public static float gettime()
    {
		return totalTime;
    }


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		totalTime += Time.deltaTime;
		seconds = (int)totalTime;
		timerText.text = seconds.ToString();

	}

	
}
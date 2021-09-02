using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{

    public Text ScoreText;
    float totalTime;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = TimerController.gettime();

        ScoreText.text = string.Format("Time:{0}", totalTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

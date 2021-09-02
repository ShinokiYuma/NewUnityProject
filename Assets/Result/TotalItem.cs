using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalItem : MonoBehaviour
{

    public Text ScoreText;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = ItemPickUp.getitem();

        ScoreText.text = string.Format("Star:{0}", count);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

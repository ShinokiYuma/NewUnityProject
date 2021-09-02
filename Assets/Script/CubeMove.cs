using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using System.Threading.Tasks;
//using System.Threading;


public class CubeMove : MonoBehaviour
{

    public Text gameOverText;

    void Update()
    {
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        this.transform.Translate(-0.1f, 0.0f, 0.0f);
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        this.transform.Translate(0.1f, 0.0f, 0.0f);
    //    }
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        this.transform.Translate(0.0f, 0.0f, 0.1f);
    //    }
    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        this.transform.Translate(0.0f, 0.0f, -0.1f);
    //    }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "GameOver")
        {
            
            gameOverText.text = "YOU DIED";
            print("YOU DIED");
            //static async void DelaySample()
            //{
            //    await Task.Delay(5000);
            //}
            //Thread.Sleep(1000);
            Invoke("Scene", 3f);

        }
    }

    private void Scene()
    {
        SceneManager.LoadScene("Game");
    }
}
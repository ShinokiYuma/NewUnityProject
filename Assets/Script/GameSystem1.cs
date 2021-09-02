using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem1 : MonoBehaviour
{

	//　スタートボタンを押したら実行する
	public void Retry()
	{
		SceneManager.LoadScene("Title");
	}
}
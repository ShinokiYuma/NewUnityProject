using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem1 : MonoBehaviour
{

	//�@�X�^�[�g�{�^��������������s����
	public void Retry()
	{
		SceneManager.LoadScene("Title");
	}
}
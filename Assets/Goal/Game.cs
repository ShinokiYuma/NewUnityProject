using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    //Inspector�ŃL�����N�^�[�ƃS�[���I�u�W�F�N�g�̎w����o����l�ɂ��܂��B
    public GameObject chara;
    public GameObject gameclea;


    private void OnTriggerEnter(Collider other)
    {
        //�����S�[���I�u�W�F�N�g�̃R���C�_�[�ɐڐG�������̏����B
        if (other.name == chara.name)
        {
            //�B
            SceneManager.LoadScene("Result");

        }
    }

}
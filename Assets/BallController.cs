using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //�ۑ�F�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�ۑ�F���_�̒l�̕ϐ���������
    private int score = 0;

 
    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");


        //�ۑ�F�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");

        //test
        Debug.Log("Score:" + score);
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";

            //���K�Fthis.gameoverText.GetComponent<Text> ().text = "Game Over";�̉E�ӂ̕������ύX�����
            //GameOvreText�̕\�����ς�邱�Ƃ��m�F���Ă݂܂��傤�B
            //this.gameoverText.GetComponent<Text>().text = "�A�E�g�ł�";
        }
    }


    //�ۑ�F�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 3;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
        }
        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
}

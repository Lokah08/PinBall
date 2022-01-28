using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;

    // Use this for initialization
    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //�����L�[�������������t���b�p�[�𓮂���
        //�ۑ�FA�L�[�������������t���b�p�[�𓮂���
        //�i�Q�Ɨp�jif (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
       if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[�����������E�t���b�p�[�𓮂���
        //�ۑ�FD�L�[�����������E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //���L�[�����ꂽ���t���b�p�[�����ɖ߂�
        //�ۑ�FA�L�[�𗣂������t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        //�ۑ�FD�L�[�𗣂������t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        //�ۑ�FS�L�[�܂��͉����L�[���������������ɍ��E�̃t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetAngle(this.flickAngle);
        }
        //�ۑ�FS�L�[�܂��͉����L�[�𗣂������t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            SetAngle(this.defaultAngle);
        }
    }

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}

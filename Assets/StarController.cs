using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    // ��]���x
    //���K�ۑ�@rotSpeed�̒l��ς��ē��������m�F����
    private float rotSpeed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}

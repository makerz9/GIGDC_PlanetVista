using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{


    public Transform[] trans; // []�� �迭   0 ���� 1 �̵� 2 ž����  / []�� �迭   0 ���� 1 �̵� 2 ž����
    //[SerializeField] private Transform[] trans; 



    // Update is called once per frame
    void Update()
    {
        //trans[0].position += Time.deltaTime * 10f;
        trans[0].Translate(Vector3.left * Time.deltaTime * 4f); //ž




        for (int i = 0; i < trans.Length; i++)   //����� -12�� �Ǹ� 12�� �̵���Ű��ʹ�
        {
            if (trans[i].localPosition.x <= -204.5f)    //���������� (�ڽĻ���)
            {
                Vector3 vec3 = trans[i].localPosition;
                vec3.x = 204.5f;
                trans[i].localPosition = vec3; //����ϸ� -12�Ǹ� 12�� �̵�
            }
        }
    }
}

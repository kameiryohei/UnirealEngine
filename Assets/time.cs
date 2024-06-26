using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ����2�s��ǉ�����.
using TMPro; // ����2�s��ǉ�����.

public class time : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextTime;
    [SerializeField] private TextMeshProUGUI GoalMesseage;
    private float elapsedTime;
    private int f_Goal; // �S�[���ɓ��B��������1�ƂȂ�t���O��ǉ�����
                        // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0.0F;
        f_Goal = 0; // ��~�t���O������������


    }
    // Update is called once per frame
    void Update()
    {
        if (f_Goal == 0) // �S�[���ɓ��B���Ă��Ȃ��ꍇ�������Ԃ����Z����
        {
            elapsedTime += Time.deltaTime;
        }
        TextTime.text = string.Format("Time {0:f2} sec", elapsedTime);
    }
    // �Փ˂𔻒肷�鏈����ǉ�����
    void OnCollisionEnter(Collision other) // �Փ˂𔻒肷��֐����Ă�
    {
        if (other.gameObject.name == "�S�[��") // �Փ˂������̂��u�S�[���v�Ȃ�(��)
        {
            f_Goal = 1; // �Փ˃t���O���グ��
            GoalMesseage.text = "Goal!";

        }
       
    }
}
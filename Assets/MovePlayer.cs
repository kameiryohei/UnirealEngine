using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    // �u�Ԉړ�����ڕW�̍��W
    public Vector3 teleportDestination = new Vector3(50, 0, 0);

    // �Փˎ��Ƀe���|�[�g����I�u�W�F�N�g�̖��O
    public string teleportTriggerName = "Goal";
    void Start()
    {
        // �K�v�ɉ����ď�����������ǉ�
    }

    void Update()
    {
        // �K�v�ɉ����čX�V������ǉ�
    }

    // ���̃I�u�W�F�N�g�Ƃ̏Փ˂����o
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == teleportTriggerName)
        {
            // �w�肳�ꂽ�I�u�W�F�N�g�ɏՓ˂�����u�Ԉړ�
            Teleport();
        }
    }

    // �u�Ԉړ��̏���
    void Teleport()
    {
        // �v���C���[�̈ʒu��ڕW���W�ɐݒ�
        transform.position = teleportDestination;
        Debug.Log("�e���|�[�g���܂����I");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [System.Serializable]
    public class TeleportTarget
    {
        public string triggerName; // �Փˎ��Ƀe���|�[�g����I�u�W�F�N�g�̖��O
        public Vector3 destination; // �u�Ԉړ�����ڕW�̍��W
    }

    // �e���|�[�g�^�[�Q�b�g�̃��X�g
    public List<TeleportTarget> teleportTargets = new List<TeleportTarget>();

    void Start()
    {
        // �K�v�ɉ����ď�����������ǉ�
    }

    void Update()
    {

    }

    // ���̃I�u�W�F�N�g�Ƃ̏Փ˂����o
    void OnCollisionEnter(Collision collision)
    {
        foreach (TeleportTarget target in teleportTargets)
        {
            if (collision.gameObject.name == target.triggerName)
            {
                // �w�肳�ꂽ�I�u�W�F�N�g�ɏՓ˂�����u�Ԉړ�
                Teleport(target.destination);
                return; // ��x�e���|�[�g�����烋�[�v���I��
            }
        }
    }

    // �u�Ԉړ��̏���
    void Teleport(Vector3 destination)
    {
        // �v���C���[�̈ʒu��ڕW���W�ɐݒ�
        transform.position = destination;
        Debug.Log("�e���|�[�g���܂����I �V�����ʒu: " + destination);
    }
}

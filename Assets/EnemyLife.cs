using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private int enemyLife = 3; // �G�̃��C�t�������l�Ƃ���3�ɐݒ�
    private bool isDead = false; // �G������ł��邩�ǂ����̃t���O

    // �Փ˂𔻒肷�鏈����ǉ�����
    void OnCollisionEnter(Collision other) // �Փ˂𔻒肷��֐����Ă�
    {
        if (other.gameObject.name == "�v���C���[") // �Փ˂������̂��v���C���[�̃v���W�F�N�^�C���Ȃ�
        {
            DecreaseLife(); // ���C�t�����炷
        }
    }

    // ���C�t�����������郁�\�b�h
    void DecreaseLife()
    {
        if (enemyLife > 0)
        {
            enemyLife--;
            if (enemyLife <= 0)
            {
                isDead = true;
                // �G�̃I�u�W�F�N�g���폜
                Destroy(gameObject);
            }
        }
    }
}
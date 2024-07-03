using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextLife; // ���C�t��\�����邽�߂�TextMeshProUGUI
    [SerializeField] private TextMeshProUGUI GameOverTitle; // �Q�[���I�[�o�[���̃^�C�g����\������TextMeshProUGUI
    private int playerLife = 3; // �v���C���[�̃��C�t�������l�Ƃ���3�ɐݒ�
    private bool isGameOver = false; // �Q�[���I�[�o�[�t���O

    // Start is called before the first frame update
    void Start()
    {
        UpdateLifeText(); // �������C�t��\��
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            // �Q�[���I�[�o�[���̏����i�Ⴆ�΃J�[�\�����\���ɂ���Ȃǁj
            DisablePlayerInput();
            return; // �Q�[���I�[�o�[���͈ȍ~�̏������s��Ȃ�
        }

        // �ʏ�̓��͏����������ɋL�q����
    }

    // �v���C���[�̓��͂𖳌������郁�\�b�h
    void DisablePlayerInput()
    {
        // ��: �J�[�\�����\���ɂ���
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // ���̓��͕��@�ɂ��Ă����l�ɖ���������K�v������Βǉ�����
    }

    // �Փ˂𔻒肷�鏈����ǉ�����
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            DecreaseLife(); // ���C�t�����炷
        }
    }

    // ���C�t�����������郁�\�b�h
    void DecreaseLife()
    {
        if (playerLife > 0)
        {
            playerLife--;
            UpdateLifeText();
            if (playerLife <= 0)
            {
                isGameOver = true;
                // �Q�[���I�[�o�[���̏����i�Ⴆ�΃e�L�X�g�\���Ȃǁj
                GameOverTitle.text = "Game Over!";
            }
        }
    }

    // ���C�t���X�V���郁�\�b�h
    void UpdateLifeText()
    {
        TextLife.text = string.Format("Life: {0}", playerLife);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ����2�s��ǉ�����.
using TMPro; // ����2�s��ǉ�����.

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextLife; // ���C�t��\�����邽�߂�TextMeshProUGUI
    [SerializeField] private TextMeshProUGUI GameOverTitle; // ���C�t��\�����邽�߂�TextMeshProUGUI
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
           
        }
    }

    // �Փ˂𔻒肷�鏈����ǉ�����
    void OnCollisionEnter(Collision other) // �Փ˂𔻒肷��֐����Ă�
    {
        if (other.gameObject.name == "Enemy") // �Փ˂������̂��uEnemy�v�Ȃ�
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
                // �Q�[���I�[�o�[���̏����i�K�v�ɉ����Ēǉ��j
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
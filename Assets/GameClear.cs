using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameClear : MonoBehaviour
{
    public GameObject targetObject;
    [SerializeField] private TextMeshProUGUI winText;

    void Start()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (targetObject == null && winText != null)
        {
            winText.gameObject.SetActive(true);  // �Ď��I�u�W�F�N�g����������\������
            winText.text = "GAME CLEAR!";
            GameManager.Instance.IsGameClear = true;  // �Q�[���N���A��Ԃ�ݒ�
        }
    }
}

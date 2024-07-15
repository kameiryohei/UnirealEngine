using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro���g�p���邽�߂ɕK�v

public class GameClear : MonoBehaviour
{
    public GameObject targetObject;  
    public TextMeshProUGUI winText;  // �uYOU WIN�v��\������TextMeshPro��Text�I�u�W�F�N�g

    // Start is called before the first frame update
    void Start()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject == null && winText != null)
        {
            winText.gameObject.SetActive(true);  // �Ď��I�u�W�F�N�g����������\������
            winText.text = "YOU WIN";
        }
    }
}

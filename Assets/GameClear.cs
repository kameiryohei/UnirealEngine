using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProを使用するために必要

public class GameClear : MonoBehaviour
{
    public GameObject targetObject;  
    public TextMeshProUGUI winText;  // 「YOU WIN」を表示するTextMeshProのTextオブジェクト

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
            winText.gameObject.SetActive(true);  // 監視オブジェクトが消えたら表示する
            winText.text = "YOU WIN";
        }
    }
}

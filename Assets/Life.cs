using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // この2行を追加する.
using TMPro; // この2行を追加する.

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextLife; // ライフを表示するためのTextMeshProUGUI
    [SerializeField] private TextMeshProUGUI GameOverTitle; // ライフを表示するためのTextMeshProUGUI
    private int playerLife = 3; // プレイヤーのライフを初期値として3に設定
    private bool isGameOver = false; // ゲームオーバーフラグ

    // Start is called before the first frame update
    void Start()
    {
        UpdateLifeText(); // 初期ライフを表示
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
           
        }
    }

    // 衝突を判定する処理を追加する
    void OnCollisionEnter(Collision other) // 衝突を判定する関数を呼ぶ
    {
        if (other.gameObject.name == "Enemy") // 衝突した物体が「Enemy」なら
        {
            DecreaseLife(); // ライフを減らす
        }
    }

    // ライフを減少させるメソッド
    void DecreaseLife()
    {
        if (playerLife > 0)
        {
            playerLife--;
            UpdateLifeText();
            if (playerLife <= 0)
            {
                isGameOver = true;
                // ゲームオーバー時の処理（必要に応じて追加）
                GameOverTitle.text = "Game Over!";
            }
        }
    }

    // ライフを更新するメソッド
    void UpdateLifeText()
    {
        TextLife.text = string.Format("Life: {0}", playerLife);
    }

   
}
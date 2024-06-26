using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextLife; // ライフを表示するためのTextMeshProUGUI
    [SerializeField] private TextMeshProUGUI GameOverTitle; // ゲームオーバー時のタイトルを表示するTextMeshProUGUI
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
            // ゲームオーバー時の処理（例えばカーソルを非表示にするなど）
            DisablePlayerInput();
            return; // ゲームオーバー時は以降の処理を行わない
        }

        // 通常の入力処理をここに記述する
    }

    // プレイヤーの入力を無効化するメソッド
    void DisablePlayerInput()
    {
        // 例: カーソルを非表示にする
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // 他の入力方法についても同様に無効化する必要があれば追加する
    }

    // 衝突を判定する処理を追加する
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Enemy")
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
                // ゲームオーバー時の処理（例えばテキスト表示など）
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
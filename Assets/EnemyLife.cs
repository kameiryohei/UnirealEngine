using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private int enemyLife = 3; // 敵のライフを初期値として3に設定
    private bool isDead = false; // 敵が死んでいるかどうかのフラグ

    // 衝突を判定する処理を追加する
    void OnCollisionEnter(Collision other) // 衝突を判定する関数を呼ぶ
    {
        if (other.gameObject.name == "プレイヤー") // 衝突した物体がプレイヤーのプロジェクタイルなら
        {
            DecreaseLife(); // ライフを減らす
        }
    }

    // ライフを減少させるメソッド
    void DecreaseLife()
    {
        if (enemyLife > 0)
        {
            enemyLife--;
            if (enemyLife <= 0)
            {
                isDead = true;
                // 敵のオブジェクトを削除
                Destroy(gameObject);
            }
        }
    }
}
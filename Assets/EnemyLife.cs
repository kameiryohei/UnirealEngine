using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private int enemyLife = 3; // 敵のライフを初期値3に設定
    private bool isDead = false; // 敵が死んでいるかどうかのフラグ

    // 衝突を検知するメソッド
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Bullet(Clone)" && !isDead) // 衝突したのがプレイヤーの弾丸で、敵がまだ死んでいない場合
        {
            DecreaseLife(); // ライフを減らす
        }
    }

    // ライフを減らすメソッド
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private int enemyLife = 3;
    private bool isDead = false;
    public bool isBoss = false; // ボスかどうかのフラグ

    // イベントを発生させるためのデリゲートとイベント
    public delegate void BossDefeatedHandler();
    public static event BossDefeatedHandler OnBossDefeated;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet(Clone)" && !isDead)
        {
            DecreaseLife();
        }
    }

    void DecreaseLife()
    {
        if (enemyLife > 0)
        {
            enemyLife--;
            if (enemyLife <= 0)
            {
                isDead = true;
                if (isBoss)
                {
                    // ボスが倒されたことを通知
                    OnBossDefeated?.Invoke();
                }
                Destroy(gameObject);
            }
        }
    }
}

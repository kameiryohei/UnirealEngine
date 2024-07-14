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
        if (!isDead)
        {
            if (other.gameObject.name == "Bullet(Clone)")
            {
                DecreaseLife(1); // Bullet に当たった場合は -1
            }
            else if (other.gameObject.name == "Bullet2(Clone)")
            {
                DecreaseLife(200); // Bullet2 に当たった場合は -200
            }
        }
    }

    void DecreaseLife(int damage)
    {
        if (enemyLife > 0)
        {
            enemyLife -= damage;
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

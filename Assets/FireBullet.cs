using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public List<GameObject> bullets;
    public Transform muzzle;
    private int currentWeaponIndex = 0;
    private bool isBossWeaponUnlocked = false;
    private Life playerLife; // プレイヤーのLifeスクリプトへの参照

    void OnEnable()
    {
        EnemyLife.OnBossDefeated += UnlockBossWeapon;
    }

    void OnDisable()
    {
        EnemyLife.OnBossDefeated -= UnlockBossWeapon;
    }

    void Start()
    {
        // プレイヤーのLifeスクリプトを取得
        playerLife = GetComponent<Life>();
        if (playerLife == null)
        {
            Debug.LogError("Life script not found on the player object!");
        }
    }

    void Update()
    {
        // プレイヤーの体力が0以下の場合、すべての操作を無効化
        if (playerLife != null && playerLife.IsGameOver)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Q) && isBossWeaponUnlocked)
        {
            SwitchWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCurrentWeapon();
        }
    }

    void SwitchWeapon()
    {
        currentWeaponIndex++;
        if (currentWeaponIndex >= bullets.Count)
        {
            currentWeaponIndex = 0;
        }
        Debug.Log("Current Weapon: " + currentWeaponIndex);
    }

    void FireCurrentWeapon()
    {
        GameObject bullet = Instantiate(bullets[currentWeaponIndex], muzzle.position, muzzle.rotation);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript != null)
        {
            bulletScript.speed = bulletScript.speed;
        }
        Destroy(bullet, 0.8f);
    }

    void UnlockBossWeapon()
    {
        isBossWeaponUnlocked = true;
        Debug.Log("Boss weapon unlocked");
    }
}
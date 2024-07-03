using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    // bullet prefabのリスト
    public List<GameObject> bullets;

    // 弾丸発射点
    public Transform muzzle;

    // 現在の武器インデックス
    private int currentWeaponIndex = 0;

    // 武器のアンロック
    private bool isBossWeaponUnlocked = false;

    void OnEnable()
    {
        EnemyLife.OnBossDefeated += UnlockBossWeapon;
    }

    void OnDisable()
    {
        EnemyLife.OnBossDefeated -= UnlockBossWeapon;
    }

    // Use this for initialization 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 武器の切り替え
        if (Input.GetKeyDown(KeyCode.Q) && isBossWeaponUnlocked)
        {
            SwitchWeapon();
        }

        // space キーが押された時
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
        // 現在の武器の弾丸の複製
        GameObject bullet = Instantiate(bullets[currentWeaponIndex]) as GameObject;

        // 弾丸の位置を調整
        bullet.transform.position = muzzle.position;

        // 弾丸の向きをプレイヤーの向いている方向に設定
        bullet.transform.rotation = muzzle.rotation;

        // Bulletスクリプトの参照を取得し、速度を設定
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript != null)
        {
            bulletScript.speed = bulletScript.speed; // Bulletスクリプトで設定された速度を使用
        }

        // 弾丸を0.8秒後に破壊
        Destroy(bullet, 0.8f);
    }

    void UnlockBossWeapon()
    {
        isBossWeaponUnlocked = true;
        // 武器リストにボスの武器を追加する
        // 例えば、bullets.Add(bossBulletPrefab);
        Debug.Log("Boss weapon unlocked");
    }
}

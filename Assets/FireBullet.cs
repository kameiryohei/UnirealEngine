using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    // bullet prefabのリスト
    public List<GameObject> bullets;

    // 弾丸発射点
    public Transform muzzle;

    // 弾丸の速度
    public float speed = 1000;

    // 現在の武器インデックス
    private int currentWeaponIndex = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 武器の切り替え
        if (Input.GetKeyDown(KeyCode.Q))
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

        Vector3 force;

        force = this.gameObject.transform.forward * speed;

        // Rigidbodyに力を加えて発射
        bullet.GetComponent<Rigidbody>().AddForce(force);

        // 弾丸の位置を調整
        bullet.transform.position = muzzle.position;

        // 弾丸を0.8秒後に破壊
        Destroy(bullet, 0.8f);
    }
}

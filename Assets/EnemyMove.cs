using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 100f; // 敵の移動速度
    public GameObject bulletPrefab; // 弾丸のプレハブ
    public Transform muzzle; // 弾丸発射点
    public float fireInterval = 2f; // 弾を発射する間隔
    public Transform player; // プレイヤーのTransform

    private float nextFireTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Fire();
    }

    void Move()
    {
        if (player != null)
        {
            // プレイヤーの方向を向く
            Vector3 direction = (player.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * moveSpeed);

            // プレイヤーに向かって移動
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    void Fire()
    {
        if (player != null && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireInterval;
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            Bullet bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                bulletScript.rb = bullet.GetComponent<Rigidbody>();
                bulletScript.rb.AddForce(muzzle.forward * bulletScript.speed);
            }
            Destroy(bullet, 2f); // 弾丸を2秒後に破壊
        }
    }
}

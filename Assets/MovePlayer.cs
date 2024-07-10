using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    // 瞬間移動する目標の座標
    public Vector3 teleportDestination = new Vector3(50, 0, 0);

    // 衝突時にテレポートするオブジェクトの名前
    public string teleportTriggerName = "Goal";
    void Start()
    {
        // 必要に応じて初期化処理を追加
    }

    void Update()
    {
        // 必要に応じて更新処理を追加
    }

    // 他のオブジェクトとの衝突を検出
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == teleportTriggerName)
        {
            // 指定されたオブジェクトに衝突したら瞬間移動
            Teleport();
        }
    }

    // 瞬間移動の処理
    void Teleport()
    {
        // プレイヤーの位置を目標座標に設定
        transform.position = teleportDestination;
        Debug.Log("テレポートしました！");
    }
}

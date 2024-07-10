using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [System.Serializable]
    public class TeleportTarget
    {
        public string triggerName; // 衝突時にテレポートするオブジェクトの名前
        public Vector3 destination; // 瞬間移動する目標の座標
    }

    // テレポートターゲットのリスト
    public List<TeleportTarget> teleportTargets = new List<TeleportTarget>();

    void Start()
    {
        // 必要に応じて初期化処理を追加
    }

    void Update()
    {

    }

    // 他のオブジェクトとの衝突を検出
    void OnCollisionEnter(Collision collision)
    {
        foreach (TeleportTarget target in teleportTargets)
        {
            if (collision.gameObject.name == target.triggerName)
            {
                // 指定されたオブジェクトに衝突したら瞬間移動
                Teleport(target.destination);
                return; // 一度テレポートしたらループを終了
            }
        }
    }

    // 瞬間移動の処理
    void Teleport(Vector3 destination)
    {
        // プレイヤーの位置を目標座標に設定
        transform.position = destination;
        Debug.Log("テレポートしました！ 新しい位置: " + destination);
    }
}

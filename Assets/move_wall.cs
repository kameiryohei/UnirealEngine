using UnityEngine;

public class move_wall : MonoBehaviour
{
    Transform myTransform;
    Vector3 position_start;
    Vector3 position_now;
    Vector3 moveDirection = Vector3.back; // 初期の移動方向を設定
    float moveTimer = 0f; // 移動時間を計測するタイマー
    float stopTimer = 0f; // 停止時間を計測するタイマー
    const float moveTime = 5f; // 移動する時間（秒）
    const float stopTime = 1f; // 停止する時間（秒）
    bool isMoving = true; // 移動中かどうかを表すフラグ
    Color32 color1 = new Color32(255, 0, 0, 1); // 行き色
    Color32 color2 = new Color32(0, 255, 0, 1); // 帰り色

    void Start()
    {
        myTransform = transform;
        position_start = myTransform.position;
        position_now = position_start;
        GetComponent<Renderer>().material.color = color1; // 初期色を設定
    }

    void Update()
    {
        if (isMoving)
        {
            moveTimer += Time.deltaTime;
            position_now += moveDirection * Time.deltaTime *2.5f;
            if (moveTimer >= moveTime)
            {
                isMoving = false;
                moveTimer = 0f;
            }
        }
        else
        {
            stopTimer += Time.deltaTime;
            if (stopTimer >= stopTime)
            {
                isMoving = true;
                stopTimer = 0f;
                moveDirection = -moveDirection; // 移動方向を逆転
                GetComponent<Renderer>().material.color = (GetComponent<Renderer>().material.color == color1) ? color2 : color1; // 色を切り替え
            }
        }
        myTransform.position = position_now;
    }
}
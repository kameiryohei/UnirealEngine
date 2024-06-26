using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour
{
   Transform myTransform; // 物体の transform 情報を格納する変数
Vector3 origin = new Vector3(0f, 1f, -3f); // 回転中心
Vector3 axis = new Vector3(0f, 1f, 0f); // 回転軸(Y 軸)
// Start is called before the first frame update
void Start()
{
myTransform = this.transform; // transform 情報を取得
}
// Update is called once per frame
void Update()
{
myTransform.RotateAround(origin, axis, 5f); // origin を中心に axis 周りに5度回転する
}
}

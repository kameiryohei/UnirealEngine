using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour
{
   Transform myTransform; // ���̂� transform �����i�[����ϐ�
Vector3 origin = new Vector3(0f, 1f, -3f); // ��]���S
Vector3 axis = new Vector3(0f, 1f, 0f); // ��]��(Y ��)
// Start is called before the first frame update
void Start()
{
myTransform = this.transform; // transform �����擾
}
// Update is called once per frame
void Update()
{
myTransform.RotateAround(origin, axis, 5f); // origin �𒆐S�� axis �����5�x��]����
}
}

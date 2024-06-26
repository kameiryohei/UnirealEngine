using UnityEngine;

public class move_wall : MonoBehaviour
{
    Transform myTransform;
    Vector3 position_start;
    Vector3 position_now;
    Vector3 moveDirection = Vector3.back; // �����̈ړ�������ݒ�
    float moveTimer = 0f; // �ړ����Ԃ��v������^�C�}�[
    float stopTimer = 0f; // ��~���Ԃ��v������^�C�}�[
    const float moveTime = 5f; // �ړ����鎞�ԁi�b�j
    const float stopTime = 1f; // ��~���鎞�ԁi�b�j
    bool isMoving = true; // �ړ������ǂ�����\���t���O
    Color32 color1 = new Color32(255, 0, 0, 1); // �s���F
    Color32 color2 = new Color32(0, 255, 0, 1); // �A��F

    void Start()
    {
        myTransform = transform;
        position_start = myTransform.position;
        position_now = position_start;
        GetComponent<Renderer>().material.color = color1; // �����F��ݒ�
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
                moveDirection = -moveDirection; // �ړ��������t�]
                GetComponent<Renderer>().material.color = (GetComponent<Renderer>().material.color == color1) ? color2 : color1; // �F��؂�ւ�
            }
        }
        myTransform.position = position_now;
    }
}
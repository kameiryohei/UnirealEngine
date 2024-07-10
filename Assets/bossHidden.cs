using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHidden : MonoBehaviour
{
    public GameObject targetObject1;  // Unity Inspector ����Z�b�g����1�ڂ̃I�u�W�F�N�g
    public GameObject targetObject2;  // Unity Inspector ����Z�b�g����2�ڂ̃I�u�W�F�N�g
    private Renderer bossRenderer;
    private BoxCollider bossCollider;

    private void Start()
    {
        // �R���|�[�l���g�̎擾
        bossRenderer = GetComponent<Renderer>();
        bossCollider = GetComponent<BoxCollider>();

        // ������ԂŔ�\���E�������ɂ���
        SetVisibilityAndCollider(false);
    }

    private void Update()
    {
        if ((targetObject1 == null && targetObject2 == null) && !IsVisible())
        {
            // ������targetObject�����݂��Ȃ��inull�j�ꍇ�A���̃I�u�W�F�N�g��\���E�L��������
            SetVisibilityAndCollider(true);
        }
        else if ((targetObject1 != null || targetObject2 != null) && IsVisible())
        {
            // �ǂ��炩��targetObject�����݂���ꍇ�A���̃I�u�W�F�N�g���\���E����������
            SetVisibilityAndCollider(false);
        }
    }

    private void SetVisibilityAndCollider(bool isVisible)
    {
        if (bossRenderer != null)
        {
            bossRenderer.enabled = isVisible;
        }

        if (bossCollider != null)
        {
            bossCollider.enabled = isVisible;
        }
    }

    private bool IsVisible()
    {
        return (bossRenderer != null && bossRenderer.enabled) ||
               (bossCollider != null && bossCollider.enabled);
    }
}
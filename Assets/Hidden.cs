using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{
    public GameObject targetObject;  // Unity Inspector ����Z�b�g����I�u�W�F�N�g
    private Renderer objectRenderer;
    private BoxCollider boxCollider;

    private void Start()
    {
        // �R���|�[�l���g�̎擾
        objectRenderer = GetComponent<Renderer>();
        boxCollider = GetComponent<BoxCollider>();

        // ������ԂŔ�\���E�������ɂ���
        SetVisibilityAndCollider(false);
    }

    private void Update()
    {
        if (targetObject == null && !IsVisible())
        {
            // targetObject �����݂��Ȃ��inull�j�ꍇ�A���̃I�u�W�F�N�g��\���E�L��������
            SetVisibilityAndCollider(true);
        }
        else if (targetObject != null && IsVisible())
        {
            // targetObject �����݂���ꍇ�A���̃I�u�W�F�N�g���\���E����������
            SetVisibilityAndCollider(false);
        }
    }

    private void SetVisibilityAndCollider(bool isVisible)
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = isVisible;
        }

        if (boxCollider != null)
        {
            boxCollider.enabled = isVisible;
        }
    }

    private bool IsVisible()
    {
        return (objectRenderer != null && objectRenderer.enabled) ||
               (boxCollider != null && boxCollider.enabled);
    }
}

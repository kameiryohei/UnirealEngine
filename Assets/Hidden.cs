using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{
    public GameObject targetObject;  // Unity Inspector からセットするオブジェクト
    private Renderer objectRenderer;
    private BoxCollider boxCollider;

    private void Start()
    {
        // コンポーネントの取得
        objectRenderer = GetComponent<Renderer>();
        boxCollider = GetComponent<BoxCollider>();

        // 初期状態で非表示・無効化にする
        SetVisibilityAndCollider(false);
    }

    private void Update()
    {
        if (targetObject == null && !IsVisible())
        {
            // targetObject が存在しない（null）場合、このオブジェクトを表示・有効化する
            SetVisibilityAndCollider(true);
        }
        else if (targetObject != null && IsVisible())
        {
            // targetObject が存在する場合、このオブジェクトを非表示・無効化する
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

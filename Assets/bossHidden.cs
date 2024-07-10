using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHidden : MonoBehaviour
{
    public GameObject targetObject1;  // Unity Inspector からセットする1つ目のオブジェクト
    public GameObject targetObject2;  // Unity Inspector からセットする2つ目のオブジェクト
    private Renderer bossRenderer;
    private BoxCollider bossCollider;

    private void Start()
    {
        // コンポーネントの取得
        bossRenderer = GetComponent<Renderer>();
        bossCollider = GetComponent<BoxCollider>();

        // 初期状態で非表示・無効化にする
        SetVisibilityAndCollider(false);
    }

    private void Update()
    {
        if ((targetObject1 == null && targetObject2 == null) && !IsVisible())
        {
            // 両方のtargetObjectが存在しない（null）場合、このオブジェクトを表示・有効化する
            SetVisibilityAndCollider(true);
        }
        else if ((targetObject1 != null || targetObject2 != null) && IsVisible())
        {
            // どちらかのtargetObjectが存在する場合、このオブジェクトを非表示・無効化する
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
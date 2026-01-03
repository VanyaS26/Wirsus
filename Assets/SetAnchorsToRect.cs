#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public class AnchorTools : EditorWindow
{
    #region df
    [MenuItem("Tools/Set Anchors To Rect &q")]
    static void SetAnchorsToRect()
    {
        if (Selection.activeTransform == null) return;

        RectTransform rectTransform = Selection.activeTransform as RectTransform;
        if (rectTransform == null || rectTransform.parent == null) return;

        RectTransform parent = rectTransform.parent as RectTransform;
        if (parent == null) return;

        // нормализованные координаты (0..1) относительно родителя
        Vector2 newAnchorMin = new Vector2(
            rectTransform.offsetMin.x / parent.rect.width + rectTransform.anchorMin.x,
            rectTransform.offsetMin.y / parent.rect.height + rectTransform.anchorMin.y
        );

        Vector2 newAnchorMax = new Vector2(
            rectTransform.offsetMax.x / parent.rect.width + rectTransform.anchorMax.x,
            rectTransform.offsetMax.y / parent.rect.height + rectTransform.anchorMax.y
        );

        Undo.RecordObject(rectTransform, "Set Anchors To Rect");

        rectTransform.anchorMin = newAnchorMin;
        rectTransform.anchorMax = newAnchorMax;

        // сбрасываем offsets → теперь anchors точно совпадают с реальным положением объекта
        rectTransform.offsetMin = Vector2.zero;
        rectTransform.offsetMax = Vector2.zero;
    }
    #endregion
}
#endif
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(UnityEngine.Grid))]
    public class GridInspector : UnityEditor.Editor
    {
        private UnityEngine.Object cellPrefab;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            cellPrefab = EditorGUILayout.ObjectField("Cell Prefab", cellPrefab, typeof(GridCell));
            EditorGUI.BeginDisabledGroup(cellPrefab == null);
            if (GUILayout.Button("Generate Grid"))
            {
                Grid grid = target as Grid;
                grid.width = 99;

                //1 check if there already are grid cells and delete em ok thats cool but literally how do i do that aaaaa

                //2 iterate thru all x-coords
                //          iterate thru all y-coords
                //          instantiate cell prefab
                //          assign to array (at correct index)
                EditorUtility.SetDirty(grid);
            }
            EditorGUI.EndDisabledGroup();
            GUI.enabled = true;
            GUILayout.Button("Hello");
        }
    }
}



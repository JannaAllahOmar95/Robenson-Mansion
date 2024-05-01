#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(QuestsManager))]
public class QuestsManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        QuestsManager questsManager = (QuestsManager)target;

        EditorGUILayout.LabelField("Active Quest", EditorStyles.boldLabel);
        questsManager.activeQuest = (Quest)EditorGUILayout.ObjectField("Active Quest", questsManager.activeQuest, typeof(Quest), false);

        EditorGUILayout.Space();

        EditorGUILayout.LabelField("Quests", EditorStyles.boldLabel);
        for (int i = 0; i < questsManager.Quests.Count; i++)
        {
            EditorGUILayout.BeginHorizontal();
            questsManager.Quests[i] = (Quest)EditorGUILayout.ObjectField("Quest " + (i + 1), questsManager.Quests[i], typeof(Quest), false);
            if (GUILayout.Button("Remove"))
            {
                questsManager.Quests.RemoveAt(i);
            }
            EditorGUILayout.EndHorizontal();
        }

        if (GUILayout.Button("Add Quest"))
        {
            questsManager.Quests.Add(null);
        }

        EditorGUILayout.Space();

        DrawDefaultInspector();

        if (GUI.changed)
        {
            EditorUtility.SetDirty(questsManager);
        }
    }
}
#endif

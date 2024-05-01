using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Objectives", fileName = "New Objective")]
public class Objective : ScriptableObject
{
    public string ObjectiveTitle;
    public bool IsCompleted;
    public bool IsBlocked;
}

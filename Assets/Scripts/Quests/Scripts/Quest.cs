using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Quests", fileName = "New Quest")]
public class Quest : ScriptableObject
{
    public string QuestTitle;
    public Objective currentObjective;
    // public string QuestDescription;
    public bool IsCompleted;
    public List<Objective> Objectives = new List<Objective>();
}

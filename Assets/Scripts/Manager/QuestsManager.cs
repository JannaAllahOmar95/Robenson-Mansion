using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class CustomEvent : UnityEvent<Quest> { }
[Serializable]
public class BoolenQuestEvent : UnityEvent<bool> { }
public class QuestsManager : MonoBehaviour
{
    public Quest activeQuest;
    public List<Quest> Quests = new List<Quest>();
    public CustomEvent CallWhenAssign;
    public UnityEvent ObjectiveIsCompleted;
    public BoolenQuestEvent questEvent;

    public void AssignActiveQuest(Quest quest)
    {
        if (activeQuest == quest)
        {
            return;
        }
        activeQuest = quest;
        CallWhenAssign.Invoke(quest);
    }
    public void SetObjectiveCompleted()
    {
        activeQuest.currentObjective.IsCompleted = true;
        ObjectiveIsCompleted.Invoke();
        SetQuestCompleted();
    }
    public void SetQuestCompleted()
    {
        foreach (var objective in activeQuest.Objectives)
        {
            if (objective.IsCompleted == false)
            {
                activeQuest.IsCompleted = false;
                break;
            }
            else if (objective.IsCompleted == true)
            {
                activeQuest.IsCompleted = true;

            }
        }
        questEvent.Invoke(activeQuest.IsCompleted);
    }
}

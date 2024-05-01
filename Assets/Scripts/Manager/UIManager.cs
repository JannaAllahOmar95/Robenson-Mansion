using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Quest1Title;
    [SerializeField] private TextMeshProUGUI ObjectiveTitle;

    public void SetUIText(Quest quest)
    {
        if (quest == null)
        {
            Quest1Title.text = "";
            ObjectiveTitle.text = "";
            return;
        }
        Quest1Title.color = Color.red;
        ObjectiveTitle.color = Color.red;

        Quest1Title.text = quest.QuestTitle;
        ObjectiveTitle.text = quest.currentObjective.ObjectiveTitle;
    }

    public void SetObjectiveCompleted()
    {
        ObjectiveTitle.color = Color.green;
    }
    public void SetQuestCompleted()
    {
        Quest1Title.color = Color.green;
    }

}

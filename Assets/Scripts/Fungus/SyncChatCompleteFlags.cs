using Fungus;
using System.Collections.Generic;
using UnityEngine;

[CommandInfo("Custom Command", "Sync Chat Complete Flags", "Synchronuises the chats complete flags")]
[AddComponentMenu("")]
public class SyncChatCompleteFlags : Command
{
    [SerializeField] List<string> ChatID;
    public override void OnEnter()
    {
        // Running multiple times - Update the status of the chat completion flags
        var linkedFlowchart = GetFlowchart();
        foreach (var ChatID in ChatID)
        {
            bool isComplete = PlayerPrefs.GetInt($"{ChatID}.Complete", 0) == 1;
            linkedFlowchart.SetBooleanVariable($"{ChatID} Completed", isComplete);
        }
        Continue();
    }
    public override string GetSummary()
    {
        return "Synchronuises the chats complete flags";
    }
    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}
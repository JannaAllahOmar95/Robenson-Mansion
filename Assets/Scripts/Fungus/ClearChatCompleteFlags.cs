using Fungus;
using System.Collections.Generic;
using UnityEngine;

[CommandInfo("Custom Command", "Clear Chat Complete Flags", "Clear the chats complete flags")]
[AddComponentMenu("")]
public class ClearChatCompleteFlags : Command
{
    [SerializeField] List<string> ChatID;
    public override void OnEnter()
    {
        // Clear the status of the chat completion flags
        var linkedFlowchart = GetFlowchart();
        foreach (var ChatID in ChatID)
        {
            PlayerPrefs.SetInt($"{ChatID}.Complete", 0);
        }
        PlayerPrefs.Save()
; Continue();
    }
    public override string GetSummary()
    {
        return "Clear the chats complete flags";
    }
    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}

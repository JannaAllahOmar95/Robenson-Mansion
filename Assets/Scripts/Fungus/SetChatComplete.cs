using Fungus;
using UnityEngine;

[CommandInfo("Custom Command", "Set Chat Complete", "Marks a Chat as being Completed")]
[AddComponentMenu("")]
public class SetChatComplete : Command
{
    [SerializeField] string ChatID;
    public override void OnEnter()
    {
        PlayerPrefs.SetInt($"{ChatID}.Completed", 1);
        PlayerPrefs.Save();
        Continue();
    }
    public override string GetSummary()
    {
        return $"Chat {ChatID} is Completed";
    }
    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}

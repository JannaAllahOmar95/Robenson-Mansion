using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public string message;
    public UnityEvent onInteract;
    public UnityEvent onShowMessage;
    public UnityEvent onHideMessage;

    public TextMeshProUGUI messageText;

    public bool isMessageActive = false;

    public void Interaction()
    {
        onInteract.Invoke();

        if (isMessageActive)
        {
            HideMessage();
        }
        else
        {
            ShowMessage();
        }
    }

    public void ShowMessage()
    {
        isMessageActive = true;
        messageText.gameObject.SetActive(true);
        messageText.text = message;

        onShowMessage.Invoke();
    }

    public void HideMessage()
    {
        isMessageActive = false;
        messageText.gameObject.SetActive(false);

        onHideMessage.Invoke();
    }
}
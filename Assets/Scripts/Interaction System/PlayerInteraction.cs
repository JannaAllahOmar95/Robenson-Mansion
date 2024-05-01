using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 2f;
    private Interactable currentInteractable;

    private void Update()
    {
        if (currentInteractable != null && Input.GetKeyDown(KeyCode.I))
        {
            currentInteractable.Interaction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            Interactable newInteractable = other.gameObject.GetComponent<Interactable>();

            if (newInteractable != null && !newInteractable.isMessageActive)
            {
                SetNewCurrentInteractable(newInteractable);
                newInteractable.ShowMessage();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            Interactable oldInteractable = other.gameObject.GetComponent<Interactable>();

            if (oldInteractable == currentInteractable)
            {
                currentInteractable.HideMessage();
                currentInteractable = null;
            }
        }
    }

    private void SetNewCurrentInteractable(Interactable newInteractable)
    {
        if (currentInteractable != null)
        {
            currentInteractable.onInteract.RemoveAllListeners();
        }

        currentInteractable = newInteractable;

        if (currentInteractable != null)
        {
            currentInteractable.onInteract.AddListener(Interact);
        }
    }

    private void Interact()
    {
        currentInteractable = null;
    }
}
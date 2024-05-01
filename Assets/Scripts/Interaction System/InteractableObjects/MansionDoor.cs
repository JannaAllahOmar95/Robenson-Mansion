using UnityEngine;

public class MansionDoor : MonoBehaviour
{
    public bool isLocked = true;
    [SerializeField] private Animator animator;

    public void OnDoorInteracted()
    {
        if (!isLocked)
        {
            animator.Play("OpenRightMansionDoor");
        }
    }

    public void SetIsLocked()
    {
        isLocked = false;
    }
}
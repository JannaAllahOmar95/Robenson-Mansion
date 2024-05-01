using UnityEngine;

public class InsideDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (other.CompareTag("Player"))
            {
                animator.SetBool("open", true);
            }
            else
            {
                animator.SetBool("open", false);
            }
        }
    }
}

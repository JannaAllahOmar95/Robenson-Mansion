using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerArea : MonoBehaviour
{
    [SerializeField] List<string> TagsToCheck;
    [SerializeField] UnityEvent OnTriggered = new UnityEvent();
    private void OnTriggerEnter(Collider other)
    {
        if (TagsToCheck.Contains(other.tag))
        {
            Debug.Log(gameObject.name);
            OnTriggered.Invoke();
        }
    }
}

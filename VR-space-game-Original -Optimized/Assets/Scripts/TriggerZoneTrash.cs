using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZoneTrash : MonoBehaviour
{
    public string TargetTag;
    public UnityEvent<GameObject> OnEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == TargetTag)
        {
            OnEnterEvent.Invoke(other.gameObject);
        }
    }
}

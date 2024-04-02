using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSetActiveFalse : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZoneTrash>().OnEnterEvent.AddListener(InsideTrash);
    }

    public void InsideTrash(GameObject trash)
    {
        trash.SetActive(false);
    }
}

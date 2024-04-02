using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timeToBreak = 2;
    public float timer = 0;
    void Start()
    {
        foreach (var obj in breakablePieces)
        {
            obj.SetActive(false);
        }
    }
    private void Break()
    {
        timer += Time.deltaTime;
        if(timer > timeToBreak)
        {
            foreach (var obj in breakablePieces)
            {
                obj.SetActive(true);
                obj.transform.parent = null;
            }
            gameObject.SetActive(false);
        }
    }
}

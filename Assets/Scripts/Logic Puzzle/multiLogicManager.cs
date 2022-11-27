using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiLogicManager : MonoBehaviour
{
    [SerializeField] private bool ANDGate = false;
    [SerializeField] private bool ORGate = false;
    [SerializeField] private logicDecider logicDecider1;
    [SerializeField] private logicDecider logicDecider2;

    private bool completed;
    private void Start()
    {
        completed = false;      
    }

    // Update is called once per frame
    private void Update()
    {
        if (!completed)
        {
            checkState();
            if (completed)
            {
                Debug.Log("puzzle completed");
            }
        }    
    }

    private void checkState()
    {
        // If both switch is true
        if (ANDGate)
        {
            if (logicDecider1.readState() && logicDecider2.readState())
                setState();
        }
        // If one of them are true
        else if (ORGate)
        {
            if (logicDecider1.readState() || logicDecider2.readState())
                setState();
        }
    }

    private void setState()
    {
        completed = !completed;
    }

    public bool readState()
    {
        return completed;
    }

}

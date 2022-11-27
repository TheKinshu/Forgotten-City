using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicDecider : MonoBehaviour
{
    [SerializeField] private bool ANDGate = false;
    [SerializeField] private bool ORGate = false;
    [SerializeField] private bool XORGate = false;
    [SerializeField] private logicObject switch1;    
    [SerializeField] private logicObject switch2;    

    private bool completed;
    private void Start()
    {
        completed = false;
    }

    private void Update() 
    {
        if (!completed)
        {
            checkState();
        }

    }

    private void checkState()
    {
        // If both switch is true
        if (ANDGate)
        {
            if (switch1.checkState() && switch2.checkState())
                setState();
        }
        // If one of them are true
        else if (ORGate)
        {
            if (switch1.checkState() || switch2.checkState())
                setState();
        }
        // only one switch is on
        else if (XORGate)
        {
        //
            if ((switch1.checkState() || switch2.checkState()) && !(switch1.checkState() && switch2.checkState()))
            {
                setState();
            }
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

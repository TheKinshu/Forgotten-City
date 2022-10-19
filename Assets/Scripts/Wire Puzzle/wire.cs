using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire : MonoBehaviour
{
    [SerializeField] private bool currentState = false;
    // Start is called before the first frame update
    void Start()
    {
        currentState = false;
    }

    private void changeState() {
        currentState = true;
    }

    public bool checkState(){
        return currentState;
    }

}

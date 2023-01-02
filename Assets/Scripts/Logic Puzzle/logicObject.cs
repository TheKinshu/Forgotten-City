using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicObject : MonoBehaviour
{
    [SerializeField] private bool currentState = false;
    [SerializeField] private GameObject button;
    private bool triggerPuzzle = false;
    // Start is called before the first frame update
    private void Start()
    {
        //currentState = false;
    }

    private void Update()
    {
        if (triggerPuzzle)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                button.SetActive(currentState);
                changeState();

            }
        }
    }

    private void changeState()
    {
        currentState = !currentState;
    }

    public bool checkState()
    {
        return currentState;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            triggerPuzzle = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            triggerPuzzle = false;
    }
}

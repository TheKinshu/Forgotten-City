using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private string[] character = new string[15];
    [SerializeField] private string[] dialog = new string[15];
    [SerializeField] private conversation chatbox;
    // Start is called before the first frame update
    [SerializeField] private bool endTrigger;
    [SerializeField] private bool startConv;
    private void Start()
    {
        endTrigger = false;
        startConv = false;
    }

    private void Update()
    {
        if (startConv)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                chatbox.converse(endTrigger);
                startConv = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!endTrigger)
        {
            if (other.gameObject.name == "Player")
            {
                chatbox.load(dialog, character);
                startConv = true;
                endTrigger = true;
            }

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        endTrigger = false;
        startConv = false;
    }

}

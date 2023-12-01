using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleTrigger : MonoBehaviour
{
    [SerializeField] private GameObject puzzleUI;
    [SerializeField] private bool triggerPuzzle = false;

    private void Start()
    {
        puzzleUI.SetActive(false);
    }

    private void Update()
    {
        if (triggerPuzzle)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                puzzleUI.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("something");
        if (other.gameObject.name == "Player")
            triggerPuzzle = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("something");

        if (other.gameObject.name == "Player")
            triggerPuzzle = false;
    }



}

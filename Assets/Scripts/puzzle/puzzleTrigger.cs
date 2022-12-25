using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleTrigger : MonoBehaviour
{
    [SerializeField] private GameObject puzzleUI;
    private bool triggerPuzzle = false;

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

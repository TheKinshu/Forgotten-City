using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    [SerializeField] private string[] NameOfLevel;
    [SerializeField] private string ExitPoint;

    private PlayerMovement playerController;

    private PlayerStartPoint startPointController;

    [SerializeField] private GameObject playerObject;
    [SerializeField] private bool checkTrophies;
    private bool completed, startLevel;
    // Start is called before the first frame update
    private void Start()
    {
        playerController = Object.FindObjectOfType<PlayerMovement>();
        startPointController = Object.FindObjectOfType<PlayerStartPoint>();
        playerObject = GameObject.FindGameObjectWithTag("Player");
        completed = false;
        startLevel = false;
    }

    private void Update()
    {
        // check if player has gotten the required trophy
        if (checkTrophies)
        {

        }

        if (!completed)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (startLevel)
                {
                    int levelPicker = Random.Range(0, NameOfLevel.Length);
                    SceneManager.LoadScene(NameOfLevel[levelPicker]);
                    startLevel = false;
                    completed = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D playerCollider)
    {
        if (playerCollider.gameObject.name == "Player")
        {
            playerController = Object.FindObjectOfType<PlayerMovement>();
            playerController.setStartPoint(ExitPoint);
            playerObject.GetComponent<PlayerMovement>().setStartPoint(ExitPoint);
            startLevel = true;
        }
    }

    private void OnTriggerExit2D(Collider2D playerCollider)
    {
        if (playerCollider.gameObject.name == "Player")
        {
            startLevel = false;
        }
    }
}

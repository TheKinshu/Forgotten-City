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
    [SerializeField] private int whichTrophy;
    [SerializeField] private bool nextLevel;
    [SerializeField] private string nextLevelName;
    private bool completed, startLevel;
    [SerializeField] private inventory inven;
    private Animator flagAnimation;
    // Start is called before the first frame update
    private void Start()
    {

        playerController = Object.FindObjectOfType<PlayerMovement>();
        startPointController = Object.FindObjectOfType<PlayerStartPoint>();
        playerObject = GameObject.FindGameObjectWithTag("Player");
        inven = Object.FindObjectOfType<inventory>();
        completed = false;
        nextLevel = false;
        startLevel = false;
    }

    private void Update()
    {
        if (nextLevel)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(this.nextLevelName);
            }
        } else {
        // check if player has gotten the required trophy
        if (checkTrophies)
        {
            flagAnimation = GetComponent<Animator>();
            if (inven.checkAchieved(whichTrophy))
            {
                flagAnimation.SetBool("achieved", true);
                checkTrophies = false;
                Destroy(this);
            }
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

    }

    private void OnTriggerEnter2D(Collider2D playerCollider)
    {
        if (playerCollider.gameObject.name == "Player")
        {
            playerController = Object.FindObjectOfType<PlayerMovement>();
            playerController.setStartPoint(ExitPoint);
            playerObject.GetComponent<PlayerMovement>().setStartPoint(ExitPoint);
            startLevel = true;

            if (this.inven.getTrophyAchieved() == 4)
            {
                Debug.Log("You have completed the game!");
                nextLevel = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D playerCollider)
    {
        if (playerCollider.gameObject.name == "Player")
        {
            startLevel = false;
            nextLevel = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    [SerializeField] private string NameOfLevel;
    [SerializeField] private string ExitPoint;

    private PlayerMovement playerController;

    private PlayerStartPoint startPointController;

    [SerializeField] private GameObject playerObject;
    // Start is called before the first frame update
    private void Start()
    {
        playerController = Object.FindObjectOfType<PlayerMovement>();
        startPointController = Object.FindObjectOfType<PlayerStartPoint>();
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D playerCollider)
    {
        if (playerCollider.gameObject.name == "Player")
        {
            playerController = Object.FindObjectOfType<PlayerMovement>();
            playerController.setStartPoint(ExitPoint);
            playerObject.GetComponent<PlayerMovement>().setStartPoint(ExitPoint);

            SceneManager.LoadScene(NameOfLevel);
        }
    }
}

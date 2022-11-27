using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

    private PlayerMovement playerController;
    private GameObject playerObject;

    // This tells the game where the player originally started. Not used?
    [SerializeField] private string sceneName;
    // The old version is Start point. Not used?
    [SerializeField] private GameObject prevLocation;
    // The old version is point name.
    [SerializeField] private string locationName;

    // Start is called before the first frame update
    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerController = Object.FindObjectOfType<PlayerMovement>();

        // If the player location is empty set the player-controller location to the player-object location
        if (playerController.getStartPoint().Equals(""))
        {
            // If the player start position is empty get a new location.
            playerController.setStartPoint(playerObject.GetComponent<PlayerMovement>().getStartPoint());
        }

        // Check if player got teleport to the correct location
        if (playerController.getStartPoint().Equals(locationName))
        {
            // Teleport the player to a new location position
            playerObject.transform.position = transform.position;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject exitDoor;
    [SerializeField] private inventory inven;
    [SerializeField] private int badgeNum;
    private void Start()
    {
        inven = Object.FindObjectOfType<inventory>();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1;
            winPanel.SetActive(false);
            exitDoor.SetActive(true);

            inven.setAchieved(badgeNum);
        }
    }
}


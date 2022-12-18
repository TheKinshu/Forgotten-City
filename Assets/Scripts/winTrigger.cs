using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private string lobby;
    [SerializeField] private GameObject leaveLevel;
    private inventory inven;
    private void Start()
    {

    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1;
            winPanel.SetActive(false);
            leaveLevel.SetActive(true);
        }
    }
}


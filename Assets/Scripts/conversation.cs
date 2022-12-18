using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class conversation : MonoBehaviour
{
    [SerializeField] private GameObject currentCanvas;
    [SerializeField] private TextMeshProUGUI chat;
    private string[] dialog;
    private string[] speaker;
    [SerializeField] private int counter;
    [SerializeField] private int conversationSize;

    [SerializeField] private Sprite[] images;
    [SerializeField] private string[] imagesName;
    private Sprite portrait;

    // Start is called before the first frame update

    public void load(string[] log, string[] character)
    {
        dialog = log;
        speaker = character;
        conversationSize = log.Length;
        counter = 0;
        chat.text = dialog[counter];

    }

    public void converse(bool conv)
    {
        Time.timeScale = 0;
        currentCanvas.SetActive(true);
    }

    private void Update()
    {
        if (counter != conversationSize)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                chat.text = dialog[counter];
                counter++;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                currentCanvas.SetActive(false);
                Time.timeScale = 1;
            }
        }

    }
}

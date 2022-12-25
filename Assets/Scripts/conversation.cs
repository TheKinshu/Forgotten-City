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
    private Sprite portrait;

    [SerializeField] private GameObject currentTalker;

    // Start is called before the first frame update

    private void Start()
    {
        portrait = null;
    }

    public void load(string[] log, string[] character)
    {
        dialog = log;
        speaker = character;
        conversationSize = log.Length;
        counter = 0;
        loadText();
    }

    public void converse(bool conv)
    {
        Time.timeScale = 0;
        currentCanvas.SetActive(true);
        counter++;
    }

    private void Update()
    {
        if (counter != conversationSize)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                loadText();
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

    private void loadText()
    {
        chat.text = dialog[counter];
        chooseSpeaker();
        currentTalker.GetComponent<Image>().sprite = portrait;
        //currentTalker.sprite = portrait;
    }

    private void chooseSpeaker()
    {
        if (speaker[counter].Equals("frog"))
            portrait = images[1];
        else if (speaker[counter].Equals("virtual"))
            portrait = images[0];
        else if (speaker[counter].Equals("pink"))
            portrait = images[2];
        else if (speaker[counter].Equals("tika"))
            portrait = images[3];
    }

}

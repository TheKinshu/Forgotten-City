using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class Logic : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private Button option1, option2, option3, option4;
    [SerializeField] private ListQuestions trivias;
    // Start is called before the first frame update
    private List<string> questions;
    private List<string> options;
    private List<string> answers;
    private int questionSelector;

    private List<string> currentOptions;

    private Dictionary<Button, string> dicOption = new Dictionary<Button, string>();
    private void Start()
    {
        // Get question, options, answers
        questions = new List<string>(trivias.getQuestion());
        options = new List<string>(trivias.getOptions());
        answers = new List<string>(trivias.getAnswers());
        // Select a random number
        questionSelector = (int)Random.Range(0, questions.Count);
        // Set the initial questoin
        questionText.text = questions[questionSelector];
        currentOptions = new List<string>(options[questionSelector].Split(" "));
        Shuffle(currentOptions);
        changeBtnTxt();
        setOptions();
    }

    // Update is called once per frame
    private void Awake()
    {
        option1.onClick.AddListener(delegate { changeState(option1, answers[questionSelector]); });
        option2.onClick.AddListener(delegate { changeState(option2, answers[questionSelector]); });
        option3.onClick.AddListener(delegate { changeState(option3, answers[questionSelector]); });
        option4.onClick.AddListener(delegate { changeState(option4, answers[questionSelector]); });
    }

    private void setOptions()
    {
        dicOption.Add(option1, currentOptions[0].ToString());
        dicOption.Add(option2, currentOptions[1].ToString());
        dicOption.Add(option3, currentOptions[2].ToString());
        dicOption.Add(option4, currentOptions[3].ToString());

    }

    private void changeState(Button option, string answer)
    {
        string temp = dicOption[option];
        string temp2 = answer.Split("\n")[0];
        int isCorrect = 0;
        if (temp.Length == temp2.Length)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Equals(temp2[i]))
                {
                    isCorrect += 1;
                }
            }
        }

        if (isCorrect == temp2.Length)
            Debug.Log("correct answer");

    }

    private void changeBtnTxt()
    {
        option1.GetComponentInChildren<TextMeshProUGUI>().text = currentOptions[0].ToString();
        option2.GetComponentInChildren<TextMeshProUGUI>().text = currentOptions[1].ToString();
        option3.GetComponentInChildren<TextMeshProUGUI>().text = currentOptions[2].ToString();
        option4.GetComponentInChildren<TextMeshProUGUI>().text = currentOptions[3].ToString();
    }

    public void Shuffle<T>(List<T> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            T temp = list[i];
            int rand = Random.Range(i, list.Count);
            list[i] = list[rand];
            list[rand] = temp;
        }
    }
}

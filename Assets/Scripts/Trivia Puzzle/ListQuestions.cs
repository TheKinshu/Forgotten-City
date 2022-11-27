using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ListQuestions : MonoBehaviour
{
    [SerializeField] private TextAsset QuestionFile;
    [SerializeField] private TextAsset OptionListFile;
    [SerializeField] private TextAsset AnswerFile;

    private List<string> Questions = new List<string>();
    private List<string> OptionList = new List<string>();
    private List<string> Answers = new List<string>();

    public List<string> getQuestion()
    {
        Questions.AddRange(QuestionFile.text.Split("\n"[0]));
        return Questions;
    }
    public List<string> getOptions()
    {
        OptionList.AddRange(OptionListFile.text.Split("\n"[0]));
        return OptionList;
    }
    public List<string> getAnswers()
    {
        Answers.AddRange(AnswerFile.text.Split(" "[0]));
        return Answers;
    }
}

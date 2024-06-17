using System;
using System.Collections.Generic;
using static Globals;
using UnityEngine;


public class ProcessManager : MonoBehaviour
{
    public const int FirstQuestionLength = 24;
    public const int SecondQuestionLength = 72;

    // first 24 questions 
    public FirstQuestion[] FirstQuestionsList = new FirstQuestion[FirstQuestionLength];
    // rest 76 questions
    public SecondQuestion[] SecondQuestionsList = new SecondQuestion[SecondQuestionLength];

    // ordered questions that actually shows in game; should have same order as answers
    public Question[] OrderedQuestionsList = new Question[FirstQuestionLength + SecondQuestionLength];   

    public List<Action> ActionLogs = new();
    

    // the last question user arrived; we can track 6 questions before the last (except arrives a filler)
    public int LastQuestion = 0;
    public int CurrentQuestion = 0;

    // path to bgm file? not sure how unity handles bgm function so this may change accrodingly
    public List<string> AvailableBgms = new();
    public List<string> SelectedBgms = new();
    public string CurrentBgm = "";

    // test result
    public Dictionary<Dimension, int> Result = new();
    // answer to each question; range from 1 to 5 (totally disagree -> totally agree)
    public int[] Answers;

    // default by white;
    public Color BgColor {get; set;}

    // since we only want one instance of this class, so use a static variable to store the created instance
    // singleton design pattern
    public static ProcessManager Instance { get; private set; }

    public bool CanChangeBgm = false;

    private void Awake(){
        if (Instance == null){
            Instance = this;
            Initialize();
        } else {
            DestroyImmediate(gameObject);
        }
    }

    private void Initialize(){
        LoadFirstQuestions();
        LoadSecondQuestions();
        InitializeBgm();
        InitializeResult();
        LoadNextQuestions();
        OpenMainPage();
    }

    private void InitializeResult(){
        foreach (Dimension dim in Enum.GetValues(typeof(Dimension)))
        {
            Result[dim] = 0;
        }
    }

    // TODO
    private void SubmitAnswer(){
        throw new NotImplementedException();
    }

    // TODO
    private void NavigateToQuestion(int id){
        throw new NotImplementedException();
    }

    // TODO
    private void LoadFirstQuestions(){
        // read first 24 questions from FirstQuestions.csv and store in FirstQuestionsList
        throw new NotImplementedException();
    }

    // TODO
    private void LoadSecondQuestions(){
        // load rest 72 questions from SecondQuestions.csv and store in SecondQuestionsList
        throw new NotImplementedException();
    }

    // TODO
    private void LoadNextQuestions(){
        // choose next set of questions based on current state and update OrderedQuestionList
        throw new NotImplementedException();
    }

    // TODO
    private void InitializeBgm(){
        // load inital bgm when opening the application
        throw new NotImplementedException();
    }

    // TODO
    private void SelectBgm(){
        throw new NotImplementedException();
    }

    // TODO
    private void ChangeBgm(){
        // load inital bgm when opening the application
        throw new NotImplementedException();
    }

    // TODO
    private void StopBgm() {
        throw new NotImplementedException();
    }

    // TODO
    private void openFillerPage(){
        throw new NotImplementedException();
    }

    // TODO
    private void openBgmPage(){
        throw new NotImplementedException();
    }

    // TODO
    private void OpenMainPage(){
        throw new NotImplementedException();
    }

    // TODO
    private void OpenFinalPage(){
        throw new NotImplementedException();
    }

    // For each close page function, which page to be opened next should also be handled in the function
    // TODO
    private void CloseFillerPage(){
        throw new NotImplementedException();
    }

    // TODO
    private void CloseBgmPage(){
        throw new NotImplementedException();
    }

    // TODO
    private void CloseMainPage(){
        throw new NotImplementedException();
    }
    
    // TODO
    private void CloseFinalPage(){
        throw new NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class SceneController : MonoBehaviour
{
   //private List<string> sceneHistory = new List<string>();  //running history of scenes
    //The last string in the list is always the current scene running
    static List<string> sceneList = new List<string>();

    private int correctAnswer;

    private int NUM_OF_QUESTIONS_1 = 80;
    private int NUM_OF_QUESTIONS_2 = 29;
    private int NUM_OF_JOBS = 40;

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;

    private Dictionary<string, string> My_dict1;
    private Dictionary<string, string> My_dict2;
    private Dictionary<string, string> My_dict3;
    private Dictionary<string, string> My_dict4;
    private Dictionary<string, string> My_dict5;

    private QuizParser qp = new QuizParser();

    public Text qNum;
 
    void Start()
    {
        Scene m_Scene;
        string sceneName;

        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;

        if (sceneName != "Story0" && sceneName != "Story1" && sceneName != "Story2" 
        && sceneName != "Story3" && sceneName != "Story4"
        && sceneName != "Story5" && sceneName != "Story6"){
            sceneList.Add(sceneName);
        }

        correctAnswer = 0;

        Debug.Log(sceneName);
    }

    void Update(){
        
    }
 
    //Call this whenever you want to load a new scene
    //It will add the new scene to the sceneHistory list
    public void LoadScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void LoadSceneStory(string newScene){
        string job = StaticClass.CrossSceneInformation;
        Scene m_Scene;
        string sceneName;

        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;

        if(newScene == "Story0" && sceneName == "Story6"){
            try{
                int number = int.Parse(job);
                number++;
                if (number > NUM_OF_JOBS){
                    number = 1;
                }
                string numberString = number.ToString();
                StaticClass.CrossSceneInformation = numberString;
            }catch(ArithmeticException e){
                Debug.Log("Could not load next scene: " + e.ToString());
                return;
            }
        }

        if(newScene == "Story6" && sceneName == "Story0"){
            try{
                int number = int.Parse(job);
                number--;
                if (number < 1){
                    number = NUM_OF_JOBS;
                }
                string numberString = number.ToString();
                StaticClass.CrossSceneInformation = numberString;
            }catch(ArithmeticException e){
                Debug.Log("Could not load next scene: " + e.ToString());
                return;
            }
        }

        SceneManager.LoadScene(newScene);
    }

    public void LoadSceneWithParameter(int number){
        Image image;
        Sprite sprite;
        string word;
        string[] p;

        switch(number)
        {
            case 1:
                image = b1.GetComponent<Image>();
                break;
            case 2:
                image = b2.GetComponent<Image>();
                break;
            case 3:
                image = b3.GetComponent<Image>();
                break;
            case 4:
                image = b4.GetComponent<Image>();
                break;
            default:
                return;
        }

        sprite = image.sprite;
        word = sprite.ToString();
        p = word.Split('_');
        string param = p[0];

        StaticClass.CrossSceneInformation = param;
        sceneList.Add("Story0");
        LoadScene("Story0");
    }


    IEnumerator waiter(){
        yield return new WaitForSeconds(4);
    }
 
    private IEnumerator WaitForSceneLoad1() {
        yield return new WaitForSeconds(2);
        LoadScene("EndOfQuiz1"); 
    }

    private IEnumerator WaitForSceneLoad2(){
        yield return new WaitForSeconds(2);
        LoadScene("EndOfQuiz2");
    }

    private IEnumerator WaitForNextQuestion(int pathNumber, int counter){
        yield return new WaitForSeconds(2.5f);
        increaseQuestionNumber(pathNumber, counter);
    }
    
    public void answerNO(string num_and_path_number){

        string[] splitArray;
        splitArray = num_and_path_number.Split('_');

        int num = int.Parse(splitArray[0]);
        int pathNumber = int.Parse(splitArray[1]);

        My_dict1 = qp.returnDictionary(1, pathNumber);
        My_dict2 = qp.returnDictionary(2, pathNumber);
        My_dict3 = qp.returnDictionary(3, pathNumber);
        My_dict4 = qp.returnDictionary(4, pathNumber);
        My_dict5 = qp.returnDictionary(5, pathNumber);

        string text1 = My_dict2[StaticClass.QuizNumberInformation];
        string text2 = My_dict3[StaticClass.QuizNumberInformation];
        string text3 = My_dict4[StaticClass.QuizNumberInformation];
        string text4 = My_dict5[StaticClass.QuizNumberInformation];

        bool check = false;
        
        if(num == 1){
            if(string.Equals(text4.Trim(), text1.Trim())) {
                check = true;
                StaticClass.OK1IsOn = true;
            }else{
                StaticClass.X1IsOn = true;
            }
        }
        else if(num == 2){
            if(string.Equals(text4.Trim(), text2.Trim())) {
                check = true;
                StaticClass.OK2IsOn = true;
            }else{
                StaticClass.X2IsOn = true;
            }
        }
        else{
            if(string.Equals(text4.Trim(), text3.Trim())) {
                check = true;
                StaticClass.OK3IsOn = true;
            }else{
                StaticClass.X3IsOn = true;
            }
        }

        if (check == true){

            int counter = StaticClass.CounterNO;
            counter++;
            StaticClass.CounterNO = counter;

            if(counter<7){
                correctAnswer++;
                
                    if(correctAnswer==5){
                        StaticClass.Star5IsOn = true;
                    }
                    else if(correctAnswer==4){
                        StaticClass.Star4IsOn = true;
                    }
                    else if(correctAnswer==3){
                        StaticClass.Star3IsOn = true;
                    }
                    else if(correctAnswer==2){
                        StaticClass.Star2IsOn = true;
                    }
                    else if(correctAnswer==1){
                        StaticClass.Star1IsOn = true;
                    }

                StaticClass.AnswerCorrect = true;
            
                if(counter==6){
                    if (pathNumber == 1){
                        StartCoroutine(WaitForSceneLoad1());
                    }
                    else{
                        StartCoroutine(WaitForSceneLoad2());
                    }
                    
                }
                else{
                    StartCoroutine(WaitForNextQuestion(pathNumber, counter));
                }       
            }
                 
        }
        else{
            StaticClass.AnswerIncorrect = true;
        }
    }

    private void increaseQuestionNumber(int pathNumber, int counter){
        int qn = int.Parse(StaticClass.QuizNumberInformation);
        qn++;
        if(pathNumber==1){
            if(qn>NUM_OF_QUESTIONS_1) qn = 1;
        }
        else{
            if(qn>NUM_OF_QUESTIONS_2) qn = 1;
        }
        qNum.text = counter.ToString() + "/5";
        StaticClass.QuizNumberInformation = qn.ToString();
        StaticClass.ChangeQuestion = true;
    }

    //Call this whenever you want to load the previous scene
    //It will remove the current scene from the history and then load the new last scene in the history
    //It will return false if we have not moved between scenes enough to have stored a previous scene in the history
    public void PreviousScene()
    {
        if (sceneList.Count >= 2)  //Checking that we have actually switched scenes enough to go back to a previous scene
        {
            string prevScene = sceneList[sceneList.Count -2];
            Debug.Log("returning to" + prevScene);
            sceneList.RemoveAt(sceneList.Count -1);
            sceneList.RemoveAt(sceneList.Count -1);
            LoadScene(prevScene);
        }
    }

}

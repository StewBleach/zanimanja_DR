using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ZadaciHandler : MonoBehaviour
{
    private Dictionary<string, string> My_dict1;
    private Dictionary<string, string> My_dict2;
    private Dictionary<string, string> My_dict3;
    private Dictionary<string, string> My_dict4;
    private Dictionary<string, string> My_dict5;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public Sprite sprite12;
    public Sprite sprite13;
    public Sprite sprite14;
    public Sprite sprite15;
    public Sprite sprite16;
    public Sprite sprite17;
    public Sprite sprite18;
    public Sprite sprite19;
    public Sprite sprite20;
    public Sprite sprite21;
    public Sprite sprite22;
    public Sprite sprite23;
    public Sprite sprite24;
    public Sprite sprite25;
    public Sprite sprite26;
    public Sprite sprite27;
    public Sprite sprite28;
    public Sprite sprite29;
    public Sprite sprite30;
    public Sprite sprite31;
    public Sprite sprite32;
    public Sprite sprite33;
    public Sprite sprite34;
    public Sprite sprite35;
    public Sprite sprite36;
    public Sprite sprite37;
    public Sprite sprite38;
    public Sprite sprite39;
    public Sprite sprite40;

    public Button button1;
    public Button button2;
    public Button button3;
    public Text textTitle;

    private string questionNumber;
    private int counter;

    private QuizParser qp = new QuizParser();
    private ManageStaticClasses msc = new ManageStaticClasses();

    // Start is called before the first frame update
    void Start()
    {
        My_dict1 = qp.returnDictionary(1, 2);
        My_dict2 = qp.returnDictionary(2, 2);
        My_dict3 = qp.returnDictionary(3, 2);
        My_dict4 = qp.returnDictionary(4, 2);
        My_dict5 = qp.returnDictionary(5, 2);

        StaticClass.CounterNO = 1;

        int randNumber = UnityEngine.Random.Range(1, 29);
        StaticClass.QuizNumberInformation = randNumber.ToString();
        StaticClass.ChangeQuestion = false;

        msc.SetAllXsAndOKsToFalse();
        ChangeQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticClass.ChangeQuestion == true){
            StaticClass.ChangeQuestion = false;
            msc.SetAllXsAndOKsToFalse();
            ChangeQuestion();
        }

        if(StaticClass.X1IsOn){
            button1.enabled = false;
        }

        if(StaticClass.X2IsOn){
            button2.enabled = false;
        }
        
        if(StaticClass.X3IsOn){
            button3.enabled = false;
        }

        if(StaticClass.OK1IsOn){
            button1.enabled = false;
            button2.enabled = false;
            button3.enabled = false;
        }

        if(StaticClass.OK2IsOn){
            button1.enabled = false;
            button2.enabled = false;
            button3.enabled = false;
        }

        if(StaticClass.OK3IsOn){
            button1.enabled = false;
            button2.enabled = false;
            button3.enabled = false;
        }
    }

    private void ChangeQuestion(){
        button1.enabled = true;
        button2.enabled = true;
        button3.enabled = true;

        Image theImage1 = button1.GetComponent<Image>();
        Image theImage2 = button2.GetComponent<Image>();
        Image theImage3 = button3.GetComponent<Image>();

        string text1 = My_dict1[StaticClass.QuizNumberInformation];
        string text2 = My_dict2[StaticClass.QuizNumberInformation];
        string text3 = My_dict3[StaticClass.QuizNumberInformation];
        string text4 = My_dict4[StaticClass.QuizNumberInformation];

        ChangeSprite(theImage1, text2);
        ChangeSprite(theImage2, text3);
        ChangeSprite(theImage3, text4);
        
        StaticClass.AudioSoundNumber = StaticClass.QuizNumberInformation;

        textTitle.text = text1;
        
    }

    private void ChangeSprite(Image img, string num){
        switch(num){
                case "1":
                    img.sprite = sprite1;
                    break;
                case "2":
                    img.sprite = sprite2;
                    break;
                case "3":
                    img.sprite = sprite3;
                    break;
                case "4":
                    img.sprite = sprite4;
                    break;
                case "5":
                    img.sprite = sprite5;
                    break;
                case "6":
                    img.sprite = sprite6;
                    break;
                case "7":
                    img.sprite = sprite7;
                    break;
                case "8":
                    img.sprite = sprite8;
                    break;
                case "9":
                    img.sprite = sprite9;
                    break;
                case "10":
                    img.sprite = sprite10;
                    break;
                case "11":
                    img.sprite = sprite11;
                    break;
                case "12":
                    img.sprite = sprite12;
                    break;
                case "13":
                    img.sprite = sprite13;
                    break;
                case "14":
                    img.sprite = sprite14;
                    break;
                case "15":
                    img.sprite = sprite15;
                    break;
                case "16":
                    img.sprite = sprite16;
                    break;
                case "17":
                    img.sprite = sprite17;
                    break;
                case "18":
                    img.sprite = sprite18;
                    break;
                case "19":
                    img.sprite = sprite19;
                    break;
                case "20":
                    img.sprite = sprite20;
                    break;
                case "21":
                    img.sprite = sprite21;
                    break;
                case "22":
                    img.sprite = sprite22;
                    break;
                case "23":
                    img.sprite = sprite23;
                    break;
                case "24":
                    img.sprite = sprite24;
                    break;
                case "25":
                    img.sprite = sprite25;
                    break;
                case "26":
                    img.sprite = sprite26;
                    break;
                case "27":
                    img.sprite = sprite27;
                    break;
                case "28":
                    img.sprite = sprite28;
                    break;
                case "29":
                    img.sprite = sprite29;
                    break;
                case "30":
                    img.sprite = sprite30;
                    break;
                case "31":
                    img.sprite = sprite31;
                    break;
                case "32":
                    img.sprite = sprite32;
                    break;
                case "33":
                    img.sprite = sprite33;
                    break;
                case "34":
                    img.sprite = sprite34;
                    break;
                case "35":
                    img.sprite = sprite35;
                    break;
                case "36":
                    img.sprite = sprite36;
                    break;
                case "37":
                    img.sprite = sprite37;
                    break;
                case "38":
                    img.sprite = sprite38;
                    break;
                case "39":
                    img.sprite = sprite39;
                    break;
                case "40":
                    img.sprite = sprite40;
                    break;
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class NOHandler : MonoBehaviour
{
    private Dictionary<string, string> My_dict1;
    private Dictionary<string, string> My_dict2;
    private Dictionary<string, string> My_dict3;
    private Dictionary<string, string> My_dict4;
    private Dictionary<string, string> My_dict5;

    public Sprite sprite1M;
    public Sprite sprite2M;
    public Sprite sprite3M;
    public Sprite sprite4M;
    public Sprite sprite5M;
    public Sprite sprite6M;
    public Sprite sprite7M;
    public Sprite sprite8M;
    public Sprite sprite9M;
    public Sprite sprite10M;
    public Sprite sprite11M;
    public Sprite sprite12M;
    public Sprite sprite13M;
    public Sprite sprite14M;
    public Sprite sprite15M;
    public Sprite sprite16M;
    public Sprite sprite17M;
    public Sprite sprite18M;
    public Sprite sprite19M;
    public Sprite sprite20M;
    public Sprite sprite21M;
    public Sprite sprite22M;
    public Sprite sprite23M;
    public Sprite sprite24M;
    public Sprite sprite25M;
    public Sprite sprite26M;
    public Sprite sprite27M;
    public Sprite sprite28M;
    public Sprite sprite29M;
    public Sprite sprite30M;
    public Sprite sprite31M;
    public Sprite sprite32M;
    public Sprite sprite33M;
    public Sprite sprite34M;
    public Sprite sprite35M;
    public Sprite sprite36M;
    public Sprite sprite37M;
    public Sprite sprite38M;
    public Sprite sprite39M;
    public Sprite sprite40M;

    public Sprite sprite1F;
    public Sprite sprite2F;
    public Sprite sprite3F;
    public Sprite sprite4F;
    public Sprite sprite5F;
    public Sprite sprite6F;
    public Sprite sprite7F;
    public Sprite sprite8F;
    public Sprite sprite9F;
    public Sprite sprite10F;
    public Sprite sprite11F;
    public Sprite sprite12F;
    public Sprite sprite13F;
    public Sprite sprite14F;
    public Sprite sprite15F;
    public Sprite sprite16F;
    public Sprite sprite17F;
    public Sprite sprite18F;
    public Sprite sprite19F;
    public Sprite sprite20F;
    public Sprite sprite21F;
    public Sprite sprite22F;
    public Sprite sprite23F;
    public Sprite sprite24F;
    public Sprite sprite25F;
    public Sprite sprite26F;
    public Sprite sprite27F;
    public Sprite sprite28F;
    public Sprite sprite29F;
    public Sprite sprite30F;
    public Sprite sprite31F;
    public Sprite sprite32F;
    public Sprite sprite33F;
    public Sprite sprite34F;
    public Sprite sprite35F;
    public Sprite sprite36F;
    public Sprite sprite37F;
    public Sprite sprite38F;
    public Sprite sprite39F;
    public Sprite sprite40F;

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
     My_dict1 = qp.returnDictionary(1, 1);
     My_dict2 = qp.returnDictionary(2, 1);
     My_dict3 = qp.returnDictionary(3, 1);
     My_dict4 = qp.returnDictionary(4, 1);
     My_dict5 = qp.returnDictionary(5, 1);

     StaticClass.CounterNO = 1;

     int randNumber = UnityEngine.Random.Range(1, 80);
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
        string text5 = My_dict5[StaticClass.QuizNumberInformation];

        Result result1 = qp.parseSpriteName(text2);
        Result result2 = qp.parseSpriteName(text3);
        Result result3 = qp.parseSpriteName(text4);
        Result result4 = qp.parseSpriteName(text5);

        ChangeSprite(theImage1, result1.getNumber(), result1.getGender());
        ChangeSprite(theImage2, result2.getNumber(), result2.getGender());
        ChangeSprite(theImage3, result3.getNumber(), result3.getGender());

        StaticClass.AudioSoundNumber = result4.getNumber();

        textTitle.text = text1;
        
    }

    private void ChangeSprite(Image img, string num, string gen){
        if (gen == "m"){
            switch(num){
                case "1":
                    img.sprite = sprite1M;
                    break;
                case "2":
                    img.sprite = sprite2M;
                    break;
                case "3":
                    img.sprite = sprite3M;
                    break;
                case "4":
                    img.sprite = sprite4M;
                    break;
                case "5":
                    img.sprite = sprite5M;
                    break;
                case "6":
                    img.sprite = sprite6M;
                    break;
                case "7":
                    img.sprite = sprite7M;
                    break;
                case "8":
                    img.sprite = sprite8M;
                    break;
                case "9":
                    img.sprite = sprite9M;
                    break;
                case "10":
                    img.sprite = sprite10M;
                    break;
                case "11":
                    img.sprite = sprite11M;
                    break;
                case "12":
                    img.sprite = sprite12M;
                    break;
                case "13":
                    img.sprite = sprite13M;
                    break;
                case "14":
                    img.sprite = sprite14M;
                    break;
                case "15":
                    img.sprite = sprite15M;
                    break;
                case "16":
                    img.sprite = sprite16M;
                    break;
                case "17":
                    img.sprite = sprite17M;
                    break;
                case "18":
                    img.sprite = sprite18M;
                    break;
                case "19":
                    img.sprite = sprite19M;
                    break;
                case "20":
                    img.sprite = sprite20M;
                    break;
                case "21":
                    img.sprite = sprite21M;
                    break;
                case "22":
                    img.sprite = sprite22M;
                    break;
                case "23":
                    img.sprite = sprite23M;
                    break;
                case "24":
                    img.sprite = sprite24M;
                    break;
                case "25":
                    img.sprite = sprite25M;
                    break;
                case "26":
                    img.sprite = sprite26M;
                    break;
                case "27":
                    img.sprite = sprite27M;
                    break;
                case "28":
                    img.sprite = sprite28M;
                    break;
                case "29":
                    img.sprite = sprite29M;
                    break;
                case "30":
                    img.sprite = sprite30M;
                    break;
                case "31":
                    img.sprite = sprite31M;
                    break;
                case "32":
                    img.sprite = sprite32M;
                    break;
                case "33":
                    img.sprite = sprite33M;
                    break;
                case "34":
                    img.sprite = sprite34M;
                    break;
                case "35":
                    img.sprite = sprite35M;
                    break;
                case "36":
                    img.sprite = sprite36M;
                    break;
                case "37":
                    img.sprite = sprite37M;
                    break;
                case "38":
                    img.sprite = sprite38M;
                    break;
                case "39":
                    img.sprite = sprite39M;
                    break;
                case "40":
                    img.sprite = sprite40M;
                    break;
            }
        }else{
            switch(num){
                case "1":
                    img.sprite = sprite1F;
                    break;
                case "2":
                    img.sprite = sprite2F;
                    break;
                case "3":
                    img.sprite = sprite3F;
                    break;
                case "4":
                    img.sprite = sprite4F;
                    break;
                case "5":
                    img.sprite = sprite5F;
                    break;
                case "6":
                    img.sprite = sprite6F;
                    break;
                case "7":
                    img.sprite = sprite7F;
                    break;
                case "8":
                    img.sprite = sprite8F;
                    break;
                case "9":
                    img.sprite = sprite9F;
                    break;
                case "10":
                    img.sprite = sprite10F;
                    break;
                case "11":
                    img.sprite = sprite11F;
                    break;
                case "12":
                    img.sprite = sprite12F;
                    break;
                case "13":
                    img.sprite = sprite13F;
                    break;
                case "14":
                    img.sprite = sprite14F;
                    break;
                case "15":
                    img.sprite = sprite15F;
                    break;
                case "16":
                    img.sprite = sprite16F;
                    break;
                case "17":
                    img.sprite = sprite17F;
                    break;
                case "18":
                    img.sprite = sprite18F;
                    break;
                case "19":
                    img.sprite = sprite19F;
                    break;
                case "20":
                    img.sprite = sprite20F;
                    break;
                case "21":
                    img.sprite = sprite21F;
                    break;
                case "22":
                    img.sprite = sprite22F;
                    break;
                case "23":
                    img.sprite = sprite23F;
                    break;
                case "24":
                    img.sprite = sprite24F;
                    break;
                case "25":
                    img.sprite = sprite25F;
                    break;
                case "26":
                    img.sprite = sprite26F;
                    break;
                case "27":
                    img.sprite = sprite27F;
                    break;
                case "28":
                    img.sprite = sprite28F;
                    break;
                case "29":
                    img.sprite = sprite29F;
                    break;
                case "30":
                    img.sprite = sprite30F;
                    break;
                case "31":
                    img.sprite = sprite31F;
                    break;
                case "32":
                    img.sprite = sprite32F;
                    break;
                case "33":
                    img.sprite = sprite33F;
                    break;
                case "34":
                    img.sprite = sprite34F;
                    break;
                case "35":
                    img.sprite = sprite35F;
                    break;
                case "36":
                    img.sprite = sprite36F;
                    break;
                case "37":
                    img.sprite = sprite37F;
                    break;
                case "38":
                    img.sprite = sprite38F;
                    break;
                case "39":
                    img.sprite = sprite39F;
                    break;
                case "40":
                    img.sprite = sprite40F;
                    break;
            }
        }
    }
}

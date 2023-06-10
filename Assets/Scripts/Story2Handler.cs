using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Story2Handler : MonoBehaviour
{
    private Dictionary<string, string> My_dict1;
    private Dictionary<string, string> My_dict2;
    

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
    public Text textF;
    public Text textTitle;

    private TextParserClass tpc = new TextParserClass();

    // Start is called before the first frame update
    void Start()
    {
        My_dict1 = tpc.returnDictionary(1);
        My_dict2 = tpc.returnDictionary(3);

        ChangeStory2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeStory2(){
        Image theImage1 = button1.GetComponent<Image>();

        switch(StaticClass.CrossSceneInformation){
            case "1":
                theImage1.sprite = sprite1;
                textF.text = My_dict2["1"];
                textTitle.text = My_dict1["1"];
                break;
            case "2":
                theImage1.sprite = sprite2;
                textF.text = My_dict2["2"];
                textTitle.text = My_dict1["2"];
                break;
            case "3":
                theImage1.sprite = sprite3;
                textF.text = My_dict2["3"];
                textTitle.text = My_dict1["3"];
                break;
            case "4":
                theImage1.sprite = sprite4;
                textF.text = My_dict2["4"];
                textTitle.text = My_dict1["4"];
                break;
            case "5":
                theImage1.sprite = sprite5;
                textF.text = My_dict2["5"];
                textTitle.text = My_dict1["5"];
                break;
            case "6":
                theImage1.sprite = sprite6;
                textF.text = My_dict2["6"];
                textTitle.text = My_dict1["6"];
                break;
            case "7":
                theImage1.sprite = sprite7;
                textF.text = My_dict2["7"];
                textTitle.text = My_dict1["7"];
                break;
            case "8":
                theImage1.sprite = sprite8;
                textF.text = My_dict2["8"];
                textTitle.text = My_dict1["8"];
                break;
            case "9":
                theImage1.sprite = sprite9;
                textF.text = My_dict2["9"];
                textTitle.text = My_dict1["9"];
                break;
            case "10":
                theImage1.sprite = sprite10;
                textF.text = My_dict2["10"];
                textTitle.text = My_dict1["10"];
                break;
            case "11":
                theImage1.sprite = sprite11;
                textF.text = My_dict2["11"];
                textTitle.text = My_dict1["11"];
                break;
            case "12":
                theImage1.sprite = sprite12;
                textF.text = My_dict2["12"];
                textTitle.text = My_dict1["12"];
                break;
            case "13":
                theImage1.sprite = sprite13;
                textF.text = My_dict2["13"];
                textTitle.text = My_dict1["13"];
                break;
            case "14":
                theImage1.sprite = sprite14;
                textF.text = My_dict2["14"];
                textTitle.text = My_dict1["14"];
                break;
            case "15":
                theImage1.sprite = sprite15;
                textF.text = My_dict2["15"];
                textTitle.text = My_dict1["15"];
                break;
            case "16":
                theImage1.sprite = sprite16;
                textF.text = My_dict2["16"];
                textTitle.text = My_dict1["16"];
                break;
            case "17":
                theImage1.sprite = sprite17;
                textF.text = My_dict2["17"];
                textTitle.text = My_dict1["17"];
                break;
            case "18":
                theImage1.sprite = sprite18;
                textF.text = My_dict2["18"];
                textTitle.text = My_dict1["18"];
                break;
            case "19":
                theImage1.sprite = sprite19;
                textF.text = My_dict2["19"];
                textTitle.text = My_dict1["19"];
                break;
            case "20":
                theImage1.sprite = sprite20;
                textF.text = My_dict2["20"];
                textTitle.text = My_dict1["20"];
                break;
            case "21":
                theImage1.sprite = sprite21;
                textF.text = My_dict2["21"];
                textTitle.text = My_dict1["21"];
                break;
            case "22":
                theImage1.sprite = sprite22;
                textF.text = My_dict2["22"];
                textTitle.text = My_dict1["22"];
                break;
            case "23":
                theImage1.sprite = sprite23;
                textF.text = My_dict2["23"];
                textTitle.text = My_dict1["23"];
                break;
            case "24":
                theImage1.sprite = sprite24;
                textF.text = My_dict2["24"];
                textTitle.text = My_dict1["24"];
                break;
            case "25":
                theImage1.sprite = sprite25;
                textF.text = My_dict2["25"];
                textTitle.text = My_dict1["25"];
                break;
            case "26":
                theImage1.sprite = sprite26;
                textF.text = My_dict2["26"];
                textTitle.text = My_dict1["26"];
                break;
            case "27":
                theImage1.sprite = sprite27;
                textF.text = My_dict2["27"];
                textTitle.text = My_dict1["27"];
                break;
            case "28":
                theImage1.sprite = sprite28;
                textF.text = My_dict2["28"];
                textTitle.text = My_dict1["28"];
                break;
            case "29":
                theImage1.sprite = sprite29;
                textF.text = My_dict2["29"];
                textTitle.text = My_dict1["29"];
                break;
            case "30":
                theImage1.sprite = sprite30;
                textF.text = My_dict2["30"];
                textTitle.text = My_dict1["30"];
                break;
            case "31":
                theImage1.sprite = sprite31;
                textF.text = My_dict2["31"];
                textTitle.text = My_dict1["31"];
                break;
            case "32":
                theImage1.sprite = sprite32;
                textF.text = My_dict2["32"];
                textTitle.text = My_dict1["32"];
                break;
            case "33":
                theImage1.sprite = sprite33;
                textF.text = My_dict2["33"];
                textTitle.text = My_dict1["33"];
                break;
            case "34":
                theImage1.sprite = sprite34;
                textF.text = My_dict2["34"];
                textTitle.text = My_dict1["34"];
                break;
            case "35":
                theImage1.sprite = sprite35;
                textF.text = My_dict2["35"];
                textTitle.text = My_dict1["35"];
                break;
            case "36":
                theImage1.sprite = sprite36;
                textF.text = My_dict2["36"];
                textTitle.text = My_dict1["36"];
                break;
            case "37":
                theImage1.sprite = sprite37;
                textF.text = My_dict2["37"];
                textTitle.text = My_dict1["37"];
                break;
            case "38":
                theImage1.sprite = sprite38;
                textF.text = My_dict2["38"];
                textTitle.text = My_dict1["38"];
                break;
            case "39":
                theImage1.sprite = sprite39;
                textF.text = My_dict2["39"];
                textTitle.text = My_dict1["39"];
                break;
            case "40":
                theImage1.sprite = sprite40;
                textF.text = My_dict2["40"];
                textTitle.text = My_dict1["40"];
                break;
        }
    }
}

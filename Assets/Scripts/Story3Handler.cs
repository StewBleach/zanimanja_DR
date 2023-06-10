using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Story3Handler : MonoBehaviour
{
    private Dictionary<string, string> My_dict1;
    private Dictionary<string, string> My_dict4;

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
    public Text textD;
    public Text textTitle;

    private TextParserClass tpc = new TextParserClass();

    // Start is called before the first frame update
    void Start()
    {
        My_dict1 = tpc.returnDictionary(1);
        My_dict4 = tpc.returnDictionary(4);

        ChangeStory3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeStory3(){
        Image theImage1 = button1.GetComponent<Image>();
        Image theImage2 = button2.GetComponent<Image>();

        switch(StaticClass.CrossSceneInformation){
            case "1":
                theImage1.sprite = sprite1M;
                theImage2.sprite = sprite1F;
                textD.text = My_dict4["1"];
                textTitle.text = My_dict1["1"];
                break;
            case "2":
                theImage1.sprite = sprite2M;
                theImage2.sprite = sprite2F;
                textD.text = My_dict4["2"];
                textTitle.text = My_dict1["2"];
                break;
            case "3":
                theImage1.sprite = sprite3M;
                theImage2.sprite = sprite3F;
                textD.text = My_dict4["3"];
                textTitle.text = My_dict1["3"];
                break;
            case "4":
                theImage1.sprite = sprite4M;
                theImage2.sprite = sprite4F;
                textD.text = My_dict4["4"];
                textTitle.text = My_dict1["4"];
                break;
            case "5":
                theImage1.sprite = sprite5M;
                theImage2.sprite = sprite5F;
                textD.text = My_dict4["5"];
                textTitle.text = My_dict1["5"];
                break;
            case "6":
                theImage1.sprite = sprite6M;
                theImage2.sprite = sprite6F;
                textD.text = My_dict4["6"];
                textTitle.text = My_dict1["6"];
                break;
            case "7":
                theImage1.sprite = sprite7M;
                theImage2.sprite = sprite7F;
                textD.text = My_dict4["7"];
                textTitle.text = My_dict1["7"];
                break;
            case "8":
                theImage1.sprite = sprite8M;
                theImage2.sprite = sprite8F;
                textD.text = My_dict4["8"];
                textTitle.text = My_dict1["8"];
                break;
            case "9":
                theImage1.sprite = sprite9M;
                theImage2.sprite = sprite9F;
                textD.text = My_dict4["9"];
                textTitle.text = My_dict1["9"];
                break;
            case "10":
                theImage1.sprite = sprite10M;
                theImage2.sprite = sprite10F;
                textD.text = My_dict4["10"];
                textTitle.text = My_dict1["10"];
                break;
            case "11":
                theImage1.sprite = sprite11M;
                theImage2.sprite = sprite11F;
                textD.text = My_dict4["11"];
                textTitle.text = My_dict1["11"];
                break;
            case "12":
                theImage1.sprite = sprite12M;
                theImage2.sprite = sprite12F;
                textD.text = My_dict4["12"];
                textTitle.text = My_dict1["12"];
                break;
            case "13":
                theImage1.sprite = sprite13M;
                theImage2.sprite = sprite13F;
                textD.text = My_dict4["13"];
                textTitle.text = My_dict1["13"];
                break;
            case "14":
                theImage1.sprite = sprite14M;
                theImage2.sprite = sprite14F;
                textD.text = My_dict4["14"];
                textTitle.text = My_dict1["14"];
                break;
            case "15":
                theImage1.sprite = sprite15M;
                theImage2.sprite = sprite15F;
                textD.text = My_dict4["15"];
                textTitle.text = My_dict1["15"];
                break;
            case "16":
                theImage1.sprite = sprite16M;
                theImage2.sprite = sprite16F;
                textD.text = My_dict4["16"];
                textTitle.text = My_dict1["16"];
                break;
            case "17":
                theImage1.sprite = sprite17M;
                theImage2.sprite = sprite17F;
                textD.text = My_dict4["17"];
                textTitle.text = My_dict1["17"];
                break;
            case "18":
                theImage1.sprite = sprite18M;
                theImage2.sprite = sprite18F;
                textD.text = My_dict4["18"];
                textTitle.text = My_dict1["18"];
                break;
            case "19":
                theImage1.sprite = sprite19M;
                theImage2.sprite = sprite19F;
                textD.text = My_dict4["19"];
                textTitle.text = My_dict1["19"];
                break;
            case "20":
                theImage1.sprite = sprite20M;
                theImage2.sprite = sprite20F;
                textD.text = My_dict4["20"];
                textTitle.text = My_dict1["20"];
                break;
            case "21":
                theImage1.sprite = sprite21M;
                theImage2.sprite = sprite21F;
                textD.text = My_dict4["21"];
                textTitle.text = My_dict1["21"];
                break;
            case "22":
                theImage1.sprite = sprite22M;
                theImage2.sprite = sprite22F;
                textD.text = My_dict4["22"];
                textTitle.text = My_dict1["22"];
                break;
            case "23":
                theImage1.sprite = sprite23M;
                theImage2.sprite = sprite23F;
                textD.text = My_dict4["23"];
                textTitle.text = My_dict1["23"];
                break;
            case "24":
                theImage1.sprite = sprite24M;
                theImage2.sprite = sprite24F;
                textD.text = My_dict4["24"];
                textTitle.text = My_dict1["24"];
                break;
            case "25":
                theImage1.sprite = sprite25M;
                theImage2.sprite = sprite25F;
                textD.text = My_dict4["25"];
                textTitle.text = My_dict1["25"];
                break;
            case "26":
                theImage1.sprite = sprite26M;
                theImage2.sprite = sprite26F;
                textD.text = My_dict4["26"];
                textTitle.text = My_dict1["26"];
                break;
            case "27":
                theImage1.sprite = sprite27M;
                theImage2.sprite = sprite27F;
                textD.text = My_dict4["27"];
                textTitle.text = My_dict1["27"];
                break;
            case "28":
                theImage1.sprite = sprite28M;
                theImage2.sprite = sprite28F;
                textD.text = My_dict4["28"];
                textTitle.text = My_dict1["28"];
                break;
            case "29":
                theImage1.sprite = sprite29M;
                theImage2.sprite = sprite29F;
                textD.text = My_dict4["29"];
                textTitle.text = My_dict1["29"];
                break;
            case "30":
                theImage1.sprite = sprite30M;
                theImage2.sprite = sprite30F;
                textD.text = My_dict4["30"];
                textTitle.text = My_dict1["30"];
                break;
            case "31":
                theImage1.sprite = sprite31M;
                theImage2.sprite = sprite31F;
                textD.text = My_dict4["31"];
                textTitle.text = My_dict1["31"];
                break;
            case "32":
                theImage1.sprite = sprite32M;
                theImage2.sprite = sprite32F;
                textD.text = My_dict4["32"];
                textTitle.text = My_dict1["32"];
                break;
            case "33":
                theImage1.sprite = sprite33M;
                theImage2.sprite = sprite33F;
                textD.text = My_dict4["33"];
                textTitle.text = My_dict1["33"];
                break;
            case "34":
                theImage1.sprite = sprite34M;
                theImage2.sprite = sprite34F;
                textD.text = My_dict4["34"];
                textTitle.text = My_dict1["34"];
                break;
            case "35":
                theImage1.sprite = sprite35M;
                theImage2.sprite = sprite35F;
                textD.text = My_dict4["35"];
                textTitle.text = My_dict1["35"];
                break;
            case "36":
                theImage1.sprite = sprite36M;
                theImage2.sprite = sprite36F;
                textD.text = My_dict4["36"];
                textTitle.text = My_dict1["36"];
                break;
            case "37":
                theImage1.sprite = sprite37M;
                theImage2.sprite = sprite37F;
                textD.text = My_dict4["37"];
                textTitle.text = My_dict1["37"];
                break;
            case "38":
                theImage1.sprite = sprite38M;
                theImage2.sprite = sprite38F;
                textD.text = My_dict4["38"];
                textTitle.text = My_dict1["38"];
                break;
            case "39":
                theImage1.sprite = sprite39M;
                theImage2.sprite = sprite39F;
                textD.text = My_dict4["39"];
                textTitle.text = My_dict1["39"];
                break;
            case "40":
                theImage1.sprite = sprite40M;
                theImage2.sprite = sprite40F;
                textD.text = My_dict4["40"];
                textTitle.text = My_dict1["40"];
                break;
        }
    }
}

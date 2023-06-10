using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Story6Handler : MonoBehaviour
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

    public Sprite sprite1L;
    public Sprite sprite2L;
    public Sprite sprite3L;
    public Sprite sprite4L;
    public Sprite sprite5L;
    public Sprite sprite6L;
    public Sprite sprite7L;
    public Sprite sprite8L;
    public Sprite sprite9L;
    public Sprite sprite10L;
    public Sprite sprite11L;
    public Sprite sprite12L;
    public Sprite sprite13L;
    public Sprite sprite14L;
    public Sprite sprite15L;
    public Sprite sprite16L;
    public Sprite sprite17L;
    public Sprite sprite18L;
    public Sprite sprite19L;
    public Sprite sprite20L;
    public Sprite sprite21L;
    public Sprite sprite22L;
    public Sprite sprite23L;
    public Sprite sprite24L;
    public Sprite sprite25L;
    public Sprite sprite26L;
    public Sprite sprite27L;
    public Sprite sprite28L;
    public Sprite sprite29L;
    public Sprite sprite30L;
    public Sprite sprite31L;
    public Sprite sprite32L;
    public Sprite sprite33L;
    public Sprite sprite34L;
    public Sprite sprite35L;
    public Sprite sprite36L;
    public Sprite sprite37L;
    public Sprite sprite38L;
    public Sprite sprite39L;
    public Sprite sprite40L;

    public Button button1;
    public Button button2;
    public Button button3;
    public Text textD;
    public Text textTitle;

    private TextParserClass tpc = new TextParserClass();

    // Start is called before the first frame update
    void Start()
    {
        My_dict1 = tpc.returnDictionary(1);
        My_dict4 = tpc.returnDictionary(7);

        ChangeStory6();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeStory6(){
        Image theImage1 = button1.GetComponent<Image>();
        Image theImage2 = button2.GetComponent<Image>();
        Image theImage3 = button3.GetComponent<Image>();

        switch(StaticClass.CrossSceneInformation){
            case "1":
                theImage1.sprite = sprite1M;
                theImage2.sprite = sprite1F;
                theImage3.sprite = sprite1L;
                textD.text = My_dict4["1"];
                textTitle.text = My_dict1["1"];
                break;
            case "2":
                theImage1.sprite = sprite2M;
                theImage2.sprite = sprite2F;
                theImage3.sprite = sprite2L;
                textD.text = My_dict4["2"];
                textTitle.text = My_dict1["2"];
                break;
            case "3":
                theImage1.sprite = sprite3M;
                theImage2.sprite = sprite3F;
                theImage3.sprite = sprite3L;
                textD.text = My_dict4["3"];
                textTitle.text = My_dict1["3"];
                break;
            case "4":
                theImage1.sprite = sprite4M;
                theImage2.sprite = sprite4F;
                theImage3.sprite = sprite4L;
                textD.text = My_dict4["4"];
                textTitle.text = My_dict1["4"];
                break;
            case "5":
                theImage1.sprite = sprite5M;
                theImage2.sprite = sprite5F;
                theImage3.sprite = sprite5L;
                textD.text = My_dict4["5"];
                textTitle.text = My_dict1["5"];
                break;
            case "6":
                theImage1.sprite = sprite6M;
                theImage2.sprite = sprite6F;
                theImage3.sprite = sprite6L;
                textD.text = My_dict4["6"];
                textTitle.text = My_dict1["6"];
                break;
            case "7":
                theImage1.sprite = sprite7M;
                theImage2.sprite = sprite7F;
                theImage3.sprite = sprite7L;
                textD.text = My_dict4["7"];
                textTitle.text = My_dict1["7"];
                break;
            case "8":
                theImage1.sprite = sprite8M;
                theImage2.sprite = sprite8F;
                theImage3.sprite = sprite8L;
                textD.text = My_dict4["8"];
                textTitle.text = My_dict1["8"];
                break;
            case "9":
                theImage1.sprite = sprite9M;
                theImage2.sprite = sprite9F;
                theImage3.sprite = sprite9L;
                textD.text = My_dict4["9"];
                textTitle.text = My_dict1["9"];
                break;
            case "10":
                theImage1.sprite = sprite10M;
                theImage2.sprite = sprite10F;
                theImage3.sprite = sprite10L;
                textD.text = My_dict4["10"];
                textTitle.text = My_dict1["10"];
                break;
            case "11":
                theImage1.sprite = sprite11M;
                theImage2.sprite = sprite11F;
                theImage3.sprite = sprite11L;
                textD.text = My_dict4["11"];
                textTitle.text = My_dict1["11"];
                break;
            case "12":
                theImage1.sprite = sprite12M;
                theImage2.sprite = sprite12F;
                theImage3.sprite = sprite12L;
                textD.text = My_dict4["12"];
                textTitle.text = My_dict1["12"];
                break;
            case "13":
                theImage1.sprite = sprite13M;
                theImage2.sprite = sprite13F;
                theImage3.sprite = sprite13L;
                textD.text = My_dict4["13"];
                textTitle.text = My_dict1["13"];
                break;
            case "14":
                theImage1.sprite = sprite14M;
                theImage2.sprite = sprite14F;
                theImage3.sprite = sprite14L;
                textD.text = My_dict4["14"];
                textTitle.text = My_dict1["14"];
                break;
            case "15":
                theImage1.sprite = sprite15M;
                theImage2.sprite = sprite15F;
                theImage3.sprite = sprite15L;
                textD.text = My_dict4["15"];
                textTitle.text = My_dict1["15"];
                break;
            case "16":
                theImage1.sprite = sprite16M;
                theImage2.sprite = sprite16F;
                theImage3.sprite = sprite16L;
                textD.text = My_dict4["16"];
                textTitle.text = My_dict1["16"];
                break;
            case "17":
                theImage1.sprite = sprite17M;
                theImage2.sprite = sprite17F;
                theImage3.sprite = sprite17L;
                textD.text = My_dict4["17"];
                textTitle.text = My_dict1["17"];
                break;
            case "18":
                theImage1.sprite = sprite18M;
                theImage2.sprite = sprite18F;
                theImage3.sprite = sprite18L;
                textD.text = My_dict4["18"];
                textTitle.text = My_dict1["18"];
                break;
            case "19":
                theImage1.sprite = sprite19M;
                theImage2.sprite = sprite19F;
                theImage3.sprite = sprite19L;
                textD.text = My_dict4["19"];
                textTitle.text = My_dict1["19"];
                break;
            case "20":
                theImage1.sprite = sprite20M;
                theImage2.sprite = sprite20F;
                theImage3.sprite = sprite20L;
                textD.text = My_dict4["20"];
                textTitle.text = My_dict1["20"];
                break;
            case "21":
                theImage1.sprite = sprite21M;
                theImage2.sprite = sprite21F;
                theImage3.sprite = sprite21L;
                textD.text = My_dict4["21"];
                textTitle.text = My_dict1["21"];
                break;
            case "22":
                theImage1.sprite = sprite22M;
                theImage2.sprite = sprite22F;
                theImage3.sprite = sprite22L;
                textD.text = My_dict4["22"];
                textTitle.text = My_dict1["22"];
                break;
            case "23":
                theImage1.sprite = sprite23M;
                theImage2.sprite = sprite23F;
                theImage3.sprite = sprite23L;
                textD.text = My_dict4["23"];
                textTitle.text = My_dict1["23"];
                break;
            case "24":
                theImage1.sprite = sprite24M;
                theImage2.sprite = sprite24F;
                theImage3.sprite = sprite24L;
                textD.text = My_dict4["24"];
                textTitle.text = My_dict1["24"];
                break;
            case "25":
                theImage1.sprite = sprite25M;
                theImage2.sprite = sprite25F;
                theImage3.sprite = sprite25L;
                textD.text = My_dict4["25"];
                textTitle.text = My_dict1["25"];
                break;
            case "26":
                theImage1.sprite = sprite26M;
                theImage2.sprite = sprite26F;
                theImage3.sprite = sprite26L;
                textD.text = My_dict4["26"];
                textTitle.text = My_dict1["26"];
                break;
            case "27":
                theImage1.sprite = sprite27M;
                theImage2.sprite = sprite27F;
                theImage3.sprite = sprite27L;
                textD.text = My_dict4["27"];
                textTitle.text = My_dict1["27"];
                break;
            case "28":
                theImage1.sprite = sprite28M;
                theImage2.sprite = sprite28F;
                theImage3.sprite = sprite28L;
                textD.text = My_dict4["28"];
                textTitle.text = My_dict1["28"];
                break;
            case "29":
                theImage1.sprite = sprite29M;
                theImage2.sprite = sprite29F;
                theImage3.sprite = sprite29L;
                textD.text = My_dict4["29"];
                textTitle.text = My_dict1["29"];
                break;
            case "30":
                theImage1.sprite = sprite30M;
                theImage2.sprite = sprite30F;
                theImage3.sprite = sprite30L;
                textD.text = My_dict4["30"];
                textTitle.text = My_dict1["30"];
                break;
            case "31":
                theImage1.sprite = sprite31M;
                theImage2.sprite = sprite31F;
                theImage3.sprite = sprite31L;
                textD.text = My_dict4["31"];
                textTitle.text = My_dict1["31"];
                break;
            case "32":
                theImage1.sprite = sprite32M;
                theImage2.sprite = sprite32F;
                theImage3.sprite = sprite32L;
                textD.text = My_dict4["32"];
                textTitle.text = My_dict1["32"];
                break;
            case "33":
                theImage1.sprite = sprite33M;
                theImage2.sprite = sprite33F;
                theImage3.sprite = sprite33L;
                textD.text = My_dict4["33"];
                textTitle.text = My_dict1["33"];
                break;
            case "34":
                theImage1.sprite = sprite34M;
                theImage2.sprite = sprite34F;
                theImage3.sprite = sprite34L;
                textD.text = My_dict4["34"];
                textTitle.text = My_dict1["34"];
                break;
            case "35":
                theImage1.sprite = sprite35M;
                theImage2.sprite = sprite35F;
                theImage3.sprite = sprite35L;
                textD.text = My_dict4["35"];
                textTitle.text = My_dict1["35"];
                break;
            case "36":
                theImage1.sprite = sprite36M;
                theImage2.sprite = sprite36F;
                theImage3.sprite = sprite36L;
                textD.text = My_dict4["36"];
                textTitle.text = My_dict1["36"];
                break;
            case "37":
                theImage1.sprite = sprite37M;
                theImage2.sprite = sprite37F;
                theImage3.sprite = sprite37L;
                textD.text = My_dict4["37"];
                textTitle.text = My_dict1["37"];
                break;
            case "38":
                theImage1.sprite = sprite38M;
                theImage2.sprite = sprite38F;
                theImage3.sprite = sprite38L;
                textD.text = My_dict4["38"];
                textTitle.text = My_dict1["38"];
                break;
            case "39":
                theImage1.sprite = sprite39M;
                theImage2.sprite = sprite39F;
                theImage3.sprite = sprite39L;
                textD.text = My_dict4["39"];
                textTitle.text = My_dict1["39"];
                break;
            case "40":
                theImage1.sprite = sprite40M;
                theImage2.sprite = sprite40F;
                theImage3.sprite = sprite40L;
                textD.text = My_dict4["40"];
                textTitle.text = My_dict1["40"];
                break;
        }
    }
}

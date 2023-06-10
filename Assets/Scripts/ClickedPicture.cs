using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ClickedPicture : MonoBehaviour
{
    private Dictionary<string, string> My_dict2;
    private Dictionary<string, string> My_dict3;
    private Dictionary<string, string> My_dict4;

    public AudioSource audioData1M;
    public AudioSource audioData2M;
    public AudioSource audioData3M;
    public AudioSource audioData4M;
    public AudioSource audioData5M;
    public AudioSource audioData6M;
    public AudioSource audioData7M;
    public AudioSource audioData8M;
    public AudioSource audioData9M;
    public AudioSource audioData10M;
    public AudioSource audioData11M;
    public AudioSource audioData12M;
    public AudioSource audioData13M;
    public AudioSource audioData14M;
    public AudioSource audioData15M;
    public AudioSource audioData16M;
    public AudioSource audioData17M;
    public AudioSource audioData18M;
    public AudioSource audioData19M;
    public AudioSource audioData20M;
    public AudioSource audioData21M;
    public AudioSource audioData22M;
    public AudioSource audioData23M;
    public AudioSource audioData24M;
    public AudioSource audioData25M;
    public AudioSource audioData26M;
    public AudioSource audioData27M;
    public AudioSource audioData28M;
    public AudioSource audioData29M;
    public AudioSource audioData30M;
    public AudioSource audioData31M;
    public AudioSource audioData32M;
    public AudioSource audioData33M;
    public AudioSource audioData34M;
    public AudioSource audioData35M;
    public AudioSource audioData36M;
    public AudioSource audioData37M;
    public AudioSource audioData38M;
    public AudioSource audioData39M;
    public AudioSource audioData40M;

    public AudioSource audioData1F;
    public AudioSource audioData2F;
    public AudioSource audioData3F;
    public AudioSource audioData4F;
    public AudioSource audioData5F;
    public AudioSource audioData6F;
    public AudioSource audioData7F;
    public AudioSource audioData8F;
    public AudioSource audioData9F;
    public AudioSource audioData10F;
    public AudioSource audioData11F;
    public AudioSource audioData12F;
    public AudioSource audioData13F;
    public AudioSource audioData14F;
    public AudioSource audioData15F;
    public AudioSource audioData16F;
    public AudioSource audioData17F;
    public AudioSource audioData18F;
    public AudioSource audioData19F;
    public AudioSource audioData20F;
    public AudioSource audioData21F;
    public AudioSource audioData22F;
    public AudioSource audioData23F;
    public AudioSource audioData24F;
    public AudioSource audioData25F;
    public AudioSource audioData26F;
    public AudioSource audioData27F;
    public AudioSource audioData28F;
    public AudioSource audioData29F;
    public AudioSource audioData30F;
    public AudioSource audioData31F;
    public AudioSource audioData32F;
    public AudioSource audioData33F;
    public AudioSource audioData34F;
    public AudioSource audioData35F;
    public AudioSource audioData36F;
    public AudioSource audioData37F;
    public AudioSource audioData38F;
    public AudioSource audioData39F;
    public AudioSource audioData40F;

    AudioSource audioDataForPlay;

    private QuizParser qp = new QuizParser();

    // Start is called before the first frame update
    void Start()
    {
        My_dict2 = qp.returnDictionary(2, 1);
        My_dict3 = qp.returnDictionary(3, 1);
        My_dict4 = qp.returnDictionary(4, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(int buttonNumber){
        string text2 = My_dict2[StaticClass.QuizNumberInformation];
        string text3 = My_dict3[StaticClass.QuizNumberInformation];
        string text4 = My_dict4[StaticClass.QuizNumberInformation];

        Result result1 = qp.parseSpriteName(text2);
        Result result2 = qp.parseSpriteName(text3);
        Result result3 = qp.parseSpriteName(text4);

        if( buttonNumber == 1) ChangeAudio(result1.getNumber(), result1.getGender());
        else if( buttonNumber == 2) ChangeAudio(result2.getNumber(), result2.getGender());
        else ChangeAudio(result3.getNumber(), result3.getGender());

        audioDataForPlay.Play();
    }

    private void ChangeAudio(string num, string gen){
        if (gen == "m"){
            switch(num){
                case "1":
                    audioDataForPlay = audioData1M;
                    break;
                case "2":
                    audioDataForPlay = audioData2M;
                    break;
                case "3":
                    audioDataForPlay = audioData3M;
                    break;
                case "4":
                    audioDataForPlay = audioData4M;
                    break;
                case "5":
                    audioDataForPlay = audioData5M;
                    break;
                case "6":
                    audioDataForPlay = audioData6M;
                    break;
                case "7":
                    audioDataForPlay = audioData7M;
                    break;
                case "8":
                    audioDataForPlay = audioData8M;
                    break;
                case "9":
                    audioDataForPlay = audioData9M;
                    break;
                case "10":
                    audioDataForPlay = audioData10M;
                    break;
                case "11":
                    audioDataForPlay = audioData11M;
                    break;
                case "12":
                    audioDataForPlay = audioData12M;
                    break;
                case "13":
                    audioDataForPlay = audioData13M;
                    break;
                case "14":
                    audioDataForPlay = audioData14M;
                    break;
                case "15":
                    audioDataForPlay = audioData15M;
                    break;
                case "16":
                    audioDataForPlay = audioData16M;
                    break;
                case "17":
                    audioDataForPlay = audioData17M;
                    break;
                case "18":
                    audioDataForPlay = audioData18M;
                    break;
                case "19":
                    audioDataForPlay = audioData19M;
                    break;
                case "20":
                    audioDataForPlay = audioData20M;
                    break;
                case "21":
                    audioDataForPlay = audioData21M;
                    break;
                case "22":
                    audioDataForPlay = audioData22M;
                    break;
                case "23":
                    audioDataForPlay = audioData23M;
                    break;
                case "24":
                    audioDataForPlay = audioData24M;
                    break;
                case "25":
                    audioDataForPlay = audioData25M;
                    break;
                case "26":
                    audioDataForPlay = audioData26M;
                    break;
                case "27":
                    audioDataForPlay = audioData27M;
                    break;
                case "28":
                    audioDataForPlay = audioData28M;
                    break;
                case "29":
                    audioDataForPlay = audioData29M;
                    break;
                case "30":
                    audioDataForPlay = audioData30M;
                    break;
                case "31":
                    audioDataForPlay = audioData31M;
                    break;
                case "32":
                    audioDataForPlay = audioData32M;
                    break;
                case "33":
                    audioDataForPlay = audioData33M;
                    break;
                case "34":
                    audioDataForPlay = audioData34M;
                    break;
                case "35":
                    audioDataForPlay = audioData35M;
                    break;
                case "36":
                    audioDataForPlay = audioData36M;
                    break;
                case "37":
                    audioDataForPlay = audioData37M;
                    break;
                case "38":
                    audioDataForPlay = audioData38M;
                    break;
                case "39":
                    audioDataForPlay = audioData39M;
                    break;
                case "40":
                    audioDataForPlay = audioData40M;
                    break;
            }
        }else{
            switch(num){
                case "1":
                    audioDataForPlay = audioData1F;
                    break;
                case "2":
                    audioDataForPlay = audioData2F;
                    break;
                case "3":
                    audioDataForPlay = audioData3F;
                    break;
                case "4":
                    audioDataForPlay = audioData4F;
                    break;
                case "5":
                    audioDataForPlay = audioData5F;
                    break;
                case "6":
                    audioDataForPlay = audioData6F;
                    break;
                case "7":
                    audioDataForPlay = audioData7F;
                    break;
                case "8":
                    audioDataForPlay = audioData8F;
                    break;
                case "9":
                    audioDataForPlay = audioData9F;
                    break;
                case "10":
                    audioDataForPlay = audioData10F;
                    break;
                case "11":
                    audioDataForPlay = audioData11F;
                    break;
                case "12":
                    audioDataForPlay = audioData12F;
                    break;
                case "13":
                    audioDataForPlay = audioData13F;
                    break;
                case "14":
                    audioDataForPlay = audioData14F;
                    break;
                case "15":
                    audioDataForPlay = audioData15F;
                    break;
                case "16":
                    audioDataForPlay = audioData16F;
                    break;
                case "17":
                    audioDataForPlay = audioData17F;
                    break;
                case "18":
                    audioDataForPlay = audioData18F;
                    break;
                case "19":
                    audioDataForPlay = audioData19F;
                    break;
                case "20":
                    audioDataForPlay = audioData20F;
                    break;
                case "21":
                    audioDataForPlay = audioData21F;
                    break;
                case "22":
                    audioDataForPlay = audioData22F;
                    break;
                case "23":
                    audioDataForPlay = audioData23F;
                    break;
                case "24":
                    audioDataForPlay = audioData24F;
                    break;
                case "25":
                    audioDataForPlay = audioData25F;
                    break;
                case "26":
                    audioDataForPlay = audioData26F;
                    break;
                case "27":
                    audioDataForPlay = audioData27F;
                    break;
                case "28":
                    audioDataForPlay = audioData28F;
                    break;
                case "29":
                    audioDataForPlay = audioData29F;
                    break;
                case "30":
                    audioDataForPlay = audioData30F;
                    break;
                case "31":
                    audioDataForPlay = audioData31F;
                    break;
                case "32":
                    audioDataForPlay = audioData32F;
                    break;
                case "33":
                    audioDataForPlay = audioData33F;
                    break;
                case "34":
                    audioDataForPlay = audioData34F;
                    break;
                case "35":
                    audioDataForPlay = audioData35F;
                    break;
                case "36":
                    audioDataForPlay = audioData36F;
                    break;
                case "37":
                    audioDataForPlay = audioData37F;
                    break;
                case "38":
                    audioDataForPlay = audioData38F;
                    break;
                case "39":
                    audioDataForPlay = audioData39F;
                    break;
                case "40":
                    audioDataForPlay = audioData40F;
                    break;
            }
        }
    }
}

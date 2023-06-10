using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZadaciClickedPicture : MonoBehaviour
{
    private Dictionary<string, string> My_dict2;
    private Dictionary<string, string> My_dict3;
    private Dictionary<string, string> My_dict4;

    public AudioSource audioData1;
    public AudioSource audioData2;
    public AudioSource audioData3;
    public AudioSource audioData4;
    public AudioSource audioData5;
    public AudioSource audioData6;
    public AudioSource audioData7;
    public AudioSource audioData8;
    public AudioSource audioData9;
    public AudioSource audioData10;
    public AudioSource audioData11;
    public AudioSource audioData12;
    public AudioSource audioData13;
    public AudioSource audioData14;
    public AudioSource audioData15;
    public AudioSource audioData16;
    public AudioSource audioData17;
    public AudioSource audioData18;
    public AudioSource audioData19;
    public AudioSource audioData20;
    public AudioSource audioData21;
    public AudioSource audioData22;
    public AudioSource audioData23;
    public AudioSource audioData24;
    public AudioSource audioData25;
    public AudioSource audioData26;
    public AudioSource audioData27;
    public AudioSource audioData28;
    public AudioSource audioData29;
    public AudioSource audioData30;
    public AudioSource audioData31;
    public AudioSource audioData32;
    public AudioSource audioData33;
    public AudioSource audioData34;
    public AudioSource audioData35;
    public AudioSource audioData36;
    public AudioSource audioData37;
    public AudioSource audioData38;
    public AudioSource audioData39;
    public AudioSource audioData40;

    AudioSource audioDataForPlay;
    
    private QuizParser qp = new QuizParser();

    // Start is called before the first frame update
    void Start()
    {
        My_dict2 = qp.returnDictionary(2, 2);
        My_dict3 = qp.returnDictionary(3, 2);
        My_dict4 = qp.returnDictionary(4, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(int buttonNumber){
        string text2 = My_dict2[StaticClass.QuizNumberInformation];
        string text3 = My_dict3[StaticClass.QuizNumberInformation];
        string text4 = My_dict4[StaticClass.QuizNumberInformation];

        if( buttonNumber == 1) ChangeAudio(text2);
        else if( buttonNumber == 2) ChangeAudio(text3);
        else ChangeAudio(text4);

        audioDataForPlay.Play();
    }

    private void ChangeAudio(string num){
        switch(num){
            case "1":
                audioDataForPlay = audioData1;
                break;
            case "2":
                audioDataForPlay = audioData2;
                break;
            case "3":
                audioDataForPlay = audioData3;
                break;
            case "4":
                audioDataForPlay = audioData4;
                break;
            case "5":
                audioDataForPlay = audioData5;
                break;
            case "6":
                audioDataForPlay = audioData6;
                break;
            case "7":
                audioDataForPlay = audioData7;
                break;
            case "8":
                audioDataForPlay = audioData8;
                break;
            case "9":
                audioDataForPlay = audioData9;
                break;
            case "10":
                audioDataForPlay = audioData10;
                break;
            case "11":
                audioDataForPlay = audioData11;
                break;
            case "12":
                audioDataForPlay = audioData12;
                break;
            case "13":
                audioDataForPlay = audioData13;
                break;
            case "14":
                audioDataForPlay = audioData14;
                break;
            case "15":
                audioDataForPlay = audioData15;
                break;
            case "16":
                audioDataForPlay = audioData16;
                break;
            case "17":
                audioDataForPlay = audioData17;
                break;
            case "18":
                audioDataForPlay = audioData18;
                break;
            case "19":
                audioDataForPlay = audioData19;
                break;
            case "20":
                audioDataForPlay = audioData20;
                break;
            case "21":
                audioDataForPlay = audioData21;
                break;
            case "22":
                audioDataForPlay = audioData22;
                break;
            case "23":
                audioDataForPlay = audioData23;
                break;
            case "24":
                audioDataForPlay = audioData24;
                break;
            case "25":
                audioDataForPlay = audioData25;
                break;
            case "26":
                audioDataForPlay = audioData26;
                break;
            case "27":
                audioDataForPlay = audioData27;
                break;
            case "28":
                audioDataForPlay = audioData28;
                break;
            case "29":
                audioDataForPlay = audioData29;
                break;
            case "30":
                audioDataForPlay = audioData30;
                break;
            case "31":
                audioDataForPlay = audioData31;
                break;
            case "32":
                audioDataForPlay = audioData32;
                break;
            case "33":
                audioDataForPlay = audioData33;
                break;
            case "34":
                audioDataForPlay = audioData34;
                break;
            case "35":
                audioDataForPlay = audioData35;
                break;
            case "36":
                audioDataForPlay = audioData36;
                break;
            case "37":
                audioDataForPlay = audioData37;
                break;
            case "38":
                audioDataForPlay = audioData38;
                break;
            case "39":
                audioDataForPlay = audioData39;
                break;
            case "40":
                audioDataForPlay = audioData40;
                break;
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TextParserClass
{

    //private string path = "Assets/GameAssets/TextFiles/zanimanja_tekst.txt";

    private Dictionary<string, string> My_dict1 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict2 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict3 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict4 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict5 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict6 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict7 = new Dictionary<string, string>();

    public Dictionary<string, string> returnDictionary(int num){
        //StreamReader reader = new StreamReader(path); 
        //StreamReader reader = new StreamReader(Application.streamingAssetsPath + "/zanimanja_tekst.txt");
        TextAsset file = Resources.Load<TextAsset>("Text/zanimanja_tekst");
        string fileContent = file.text;
        List<string> lines = new List<string>(fileContent.Split('\n'));
        string textAll;
        string[] splitArray;
        
        if(My_dict1.Count == 0 && My_dict2.Count==0 && My_dict3.Count==0 
        && My_dict4.Count==0 && My_dict5.Count==0 && My_dict6.Count==0 && My_dict7.Count==0){
            foreach(string line in lines){
                textAll = line;
                if (textAll == null) break;

                splitArray = textAll.Split('/');
                My_dict1[splitArray[0]]=splitArray[1];
                My_dict2[splitArray[0]]=splitArray[2];
                My_dict3[splitArray[0]]=splitArray[3];
                My_dict4[splitArray[0]]=splitArray[4];
                My_dict5[splitArray[0]]=splitArray[5];
                My_dict6[splitArray[0]]=splitArray[6];
                My_dict7[splitArray[0]]=splitArray[7];
            }
            /*do{
                textAll = reader.ReadLine();
                if (textAll == null) break;

                splitArray = textAll.Split('/');
                My_dict1[splitArray[0]]=splitArray[1];
                My_dict2[splitArray[0]]=splitArray[2];
                My_dict3[splitArray[0]]=splitArray[3];
                My_dict4[splitArray[0]]=splitArray[4];
                My_dict5[splitArray[0]]=splitArray[5];
                My_dict6[splitArray[0]]=splitArray[6];
                My_dict7[splitArray[0]]=splitArray[7];
            } while (textAll != null);*/
        }

        //reader.Close();

        switch(num){
            case 1:
                return My_dict1;
            case 2:
                return My_dict2;
            case 3:
                return My_dict3;
            case 4:
                return My_dict4;
            case 5:
                return My_dict5;
            case 6:
                return My_dict6;
            case 7:
                return My_dict7;
            default:
                return My_dict1;
        }

    }
}

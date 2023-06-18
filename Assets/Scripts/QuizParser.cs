using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class QuizParser
{
    //private string path1 = Application.streamingAssetsPath + "/no_zadaci.txt";
    //private string path2 = Application.streamingAssetsPath + "/lokacija_zadaci.txt";
    private string path1 = "Text/no_zadaci";
    private string path2 = "Text/lokacija_zadaci";

    private Dictionary<string, string> My_dict1 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict2 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict3 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict4 = new Dictionary<string, string>();
    private Dictionary<string, string> My_dict5 = new Dictionary<string, string>();

    public Dictionary<string, string> returnDictionary(int num, int pathNumber){
        string myPath;
        string fileContent = "";

        if(pathNumber==1){
            //reader = new StreamReader(path1);
            myPath = path1;
        }
        else{
            //reader = new StreamReader(path2); 
            myPath = path2;
        }

        TextAsset file = Resources.Load<TextAsset>(myPath);
        if (file != null){
            fileContent = file.text;
            // Rest of your code handling the file content
        }
        else
        {
        Debug.LogError("Failed to load the file: " + myPath);
        }
        
        List<string> lines = new List<string>(fileContent.Split('\n'));
        string textAll;
        string[] splitArray;

        if(My_dict1.Count == 0 && My_dict2.Count==0 && My_dict3.Count==0 
        && My_dict4.Count==0 && My_dict5.Count==0){
            foreach(string line in lines){
                textAll = line;
                if (textAll == null) break;

                splitArray = textAll.Split('/');
                My_dict1[splitArray[0]]=splitArray[1];
                My_dict2[splitArray[0]]=splitArray[2];
                My_dict3[splitArray[0]]=splitArray[3];
                My_dict4[splitArray[0]]=splitArray[4];
                My_dict5[splitArray[0]]=splitArray[5];
            }
            
           /* do{
                textAll = reader.ReadLine();
                if (textAll == null) break;

                splitArray = textAll.Split('/');
                My_dict1[splitArray[0]]=splitArray[1];
                My_dict2[splitArray[0]]=splitArray[2];
                My_dict3[splitArray[0]]=splitArray[3];
                My_dict4[splitArray[0]]=splitArray[4];
                My_dict5[splitArray[0]]=splitArray[5];
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
            default:
                return My_dict1;
        }
    }

    public Result parseSpriteName(string spriteName){
        string[] splitArray;

        splitArray = spriteName.Split('_');
        return new Result(splitArray[0], splitArray[1]);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result
{
    private string num;
    private string gender;

    public Result(string num, string gender){
        this.num = num;
        this.gender = gender;
    }

    public void setNumber(string num){
        this.num = num;
    }

    public string getNumber(){
        return this.num;
    }

    public void setGender(string gender){
        this.gender = gender;
    }

    public string getGender(){
        return this.gender;
    }

}

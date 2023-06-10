using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class AnswerHandler : MonoBehaviour
{
    public AudioSource audioDataYes;
    public AudioSource audioDataNo;

    public Image correct1;
    public Image correct2;
    public Image correct3;

    public Image incorrect1;
    public Image incorrect2;
    public Image incorrect3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticClass.AnswerCorrect){
            PlayYesSound();
        }
        if(StaticClass.AnswerIncorrect){
            PlayNoSound();
        }

        if(StaticClass.X1IsOn){
            incorrect1.enabled = true;
        }else{
            incorrect1.enabled = false;
        }

        if(StaticClass.X2IsOn){
            incorrect2.enabled = true;
        }else{
            incorrect2.enabled = false;
        }
        
        if(StaticClass.X3IsOn){
            incorrect3.enabled = true;
        }else{
            incorrect3.enabled = false;
        }

        if(StaticClass.OK1IsOn){
            correct1.enabled = true;
        }else{
            correct1.enabled = false;
        }

        if(StaticClass.OK2IsOn){
            correct2.enabled = true;
        }else{
            correct2.enabled = false;
        }

        if(StaticClass.OK3IsOn){
            correct3.enabled = true;
        }else{
            correct3.enabled = false;
        }
        
    }

    void PlayYesSound(){
        StartCoroutine(waiterYes());
        StaticClass.AnswerCorrect = false;
    }

    void PlayNoSound(){
        StartCoroutine(waiterNo());
        StaticClass.AnswerIncorrect = false;
    }

    IEnumerator waiterYes(){
        yield return new WaitForSeconds(1);
        audioDataYes.Play();
    }

    IEnumerator waiterNo(){
        yield return new WaitForSeconds(1);
        audioDataNo.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class StarHandler : MonoBehaviour
{

    public Image star1;
    public Image star2;
    public Image star3;
    public Image star4;
    public Image star5;

    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;

    // Start is called before the first frame update
    void Start()
    {
        star1.enabled = false;
        StaticClass.Star1IsOn = false;
        star2.enabled = false;
        StaticClass.Star2IsOn = false;
        star3.enabled = false;
        StaticClass.Star3IsOn = false;
        star4.enabled = false;
        StaticClass.Star4IsOn = false;
        star5.enabled = false;
        StaticClass.Star5IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim1.SetBool("isCorrect", false);
        anim2.SetBool("isCorrect", false);
        anim3.SetBool("isCorrect", false);
        anim4.SetBool("isCorrect", false);
        anim5.SetBool("isCorrect", false);

        if(StaticClass.Star1IsOn == true){
            star1.enabled = true;
            anim1.SetBool("isCorrect", true);
            StaticClass.Star1IsOn = false;
        }
        if(StaticClass.Star2IsOn == true){
            star2.enabled = true;
            anim2.SetBool("isCorrect", true);
            StaticClass.Star2IsOn = false;
        }
        if(StaticClass.Star3IsOn == true){
            star3.enabled = true;
            anim3.SetBool("isCorrect", true);
            StaticClass.Star3IsOn = false;
        }
        if(StaticClass.Star4IsOn == true){
            star4.enabled = true;
            anim4.SetBool("isCorrect", true);
            StaticClass.Star4IsOn = false;
        }
        if(StaticClass.Star5IsOn == true){
            star5.enabled = true;
            anim5.SetBool("isCorrect", true);
            StaticClass.Star5IsOn = false;
        }
    }
}

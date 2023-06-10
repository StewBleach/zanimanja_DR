using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PMPFramesController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    
    int counter = 0;

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


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

        Image theImage1 = button1.GetComponent<Image>();
        theImage1.sprite = sprite1;

        Image theImage2 = button2.GetComponent<Image>();
        theImage2.sprite = sprite2;

        Image theImage3 = button3.GetComponent<Image>();
        theImage3.sprite = sprite3;

        Image theImage4 = button4.GetComponent<Image>();
        theImage4.sprite = sprite4;
    }

    // Update is called once per frame
    void Update()
    {
        Image theImage1 = button1.GetComponent<Image>();
        Image theImage2 = button2.GetComponent<Image>();
        Image theImage3 = button3.GetComponent<Image>();
        Image theImage4 = button4.GetComponent<Image>();

        switch(counter)
        {
            case 0:
                theImage1.sprite = sprite1;
                theImage2.sprite = sprite2;
                theImage3.sprite = sprite3;
                theImage4.sprite = sprite4;
                break;
            case 1:
                theImage1.sprite = sprite5;
                theImage2.sprite = sprite6;
                theImage3.sprite = sprite7;
                theImage4.sprite = sprite8;
                break;
            case 2:
                theImage1.sprite = sprite9;
                theImage2.sprite = sprite10;
                theImage3.sprite = sprite11;
                theImage4.sprite = sprite12;
                break;
            case 3:
                theImage1.sprite = sprite13;
                theImage2.sprite = sprite14;
                theImage3.sprite = sprite15;
                theImage4.sprite = sprite16;
                break;
            case 4:
                theImage1.sprite = sprite17;
                theImage2.sprite = sprite18;
                theImage3.sprite = sprite19;
                theImage4.sprite = sprite20;
                break;
            case 5:
                theImage1.sprite = sprite21;
                theImage2.sprite = sprite22;
                theImage3.sprite = sprite23;
                theImage4.sprite = sprite24;
                break;
            case 6:
                theImage1.sprite = sprite25;
                theImage2.sprite = sprite26;
                theImage3.sprite = sprite27;
                theImage4.sprite = sprite28;
                break;
            case 7:
                theImage1.sprite = sprite29;
                theImage2.sprite = sprite30;
                theImage3.sprite = sprite31;
                theImage4.sprite = sprite32;
                break;
            case 8:
                theImage1.sprite = sprite33;
                theImage2.sprite = sprite34;
                theImage3.sprite = sprite35;
                theImage4.sprite = sprite36;
                break;
            case 9:
                theImage1.sprite = sprite37;
                theImage2.sprite = sprite38;
                theImage3.sprite = sprite39;
                theImage4.sprite = sprite40;
                break;
        }
    }

    int CheckLeft(int c){
        if (c < 0){
            c = 9;
        }
        return c;
    }

    int CheckRight(int c){
        if (c > 9){
            c = 0;
        }
        return c;
    }

    public void ChoseSide(string direction){
        if (direction == "Left")
        {
            counter = CheckLeft(counter-1);
        }
        else counter = CheckRight(counter+1);

    }
}

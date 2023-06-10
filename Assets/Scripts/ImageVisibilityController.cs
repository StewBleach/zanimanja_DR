using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageVisibilityController : MonoBehaviour
{
    public Image img;
    public bool isImgOn;

    // Start is called before the first frame update
    void Start()
    {
        img.enabled = false;
        isImgOn = false;
    }

    public void ChangeVisibility(){
        if(isImgOn == false){
            isImgOn=true;
            img.enabled=true;
        }
        else{
            img.enabled = false;
            isImgOn = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageStaticClasses
{
    public void SetAllXsAndOKsToFalse(){
        StaticClass.X1IsOn = false;
        StaticClass.X2IsOn = false;
        StaticClass.X3IsOn = false;
        StaticClass.OK1IsOn = false;
        StaticClass.OK2IsOn = false;
        StaticClass.OK3IsOn = false;
    }
}

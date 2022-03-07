using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class dMyItem 
{
    public string name;
    public int id;
    public string description;
    // protected is used when you want only the classes that inherit from this base class therefore its private but accessible by child classes of dMyItem 
    public bool isStackable;
    public Sprite icon;
    // Constructor 
    public dMyItem()
    {

    }
}

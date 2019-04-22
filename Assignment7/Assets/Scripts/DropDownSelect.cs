using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect : MonoBehaviour
{
    public Dropdown bladeSize;
    public Dropdown gravity;
    public Dropdown fruitSize;
    public Dropdown spawnSpeedd;
    public Dropdown fruitSpeed;
    public Dropdown otherFruit;
    
    public Text bladeTxt;
    public Text gravityTxt;
    public Text fruitTxt;
    public Text spawnTxt;
    public Text fruitSpTxt;
    public Text otherTxt;

    static public float fruitSp = 8f;
    static public float spawnSpeed = 8f;
    static public float blade = .1f;
    public static Vector3 fruit;

    public static Vector2 fruitS;


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        switch (fruitSpeed.value)
        {
            case 1:
                fruitSpTxt.text = "Slow";
                fruitSp = 5f;
                break;
            case 2:
                fruitSpTxt.text = "Medium";
                fruitSp = 10f;
                break;
            case 3:
                fruitSpTxt.text = "Fast";
                fruitSp = 15f;
                break;
            default:
                fruitSp = 10f;
                fruitSpTxt.text = "Please Select";
                break;
        }

        switch (spawnSpeedd.value)
        {
            case 1:
                spawnTxt.text = "Slow";
                spawnSpeed = 3f;
                break;
            case 2:
                spawnTxt.text = "Medium";
                spawnSpeed = 1f;
                break;
            case 3:
                spawnTxt.text = "Fast";
                spawnSpeed = .7f;
                break;
            default:
                spawnSpeed = 1f;
                spawnTxt.text = "Please Select";
                break;
        }

        switch (fruitSize.value)
        {
            case 1:
                fruitTxt.text = "Small";
                fruit = new Vector3(.6F, .6F,1); 
                break;
            case 2:
                fruitTxt.text = "Medium";
                fruit = new Vector3(1, 1, 1);
                break;
            default:
                fruit = new Vector3(1, 1, 1);
                fruitTxt.text = "Please Select";
                break;
        }

        switch (bladeSize.value)
        {
            case 1:
                bladeTxt.text = "Small";
                blade = .1f;
                break;
            case 2:
                bladeTxt.text = "Medium";
                blade = .3f;
                break;
            default:
                blade = .1f;
                bladeTxt.text = "Please Select";
                break;
        }

        switch (gravity.value)
        {
            case 1:
                gravityTxt.text = "Lower";
                Fruit.startForce = 12f;
                break;
            case 2:
                gravityTxt.text = "Normal";
                Fruit.startForce = 14f;
                break;
            default:
                Fruit.startForce = 14f;
                gravityTxt.text = "Please Select";
                break;
        }

        
        switch (otherFruit.value)
        {
            case 1:
                otherTxt.text = "None";
                AppleSpawn.spawn = false;
                StrawSpawn.spawn = false;
                break;
            case 2:
                otherTxt.text = "Apple";
                AppleSpawn.spawn = true;
                break;
            case 3:
                otherTxt.text = "Strawberry";
                StrawSpawn.spawn = true;
                break;
            default:
                AppleSpawn.spawn = false;
                StrawSpawn.spawn = false;
                otherTxt.text = "Please Select";
                break;
        }

        switch (fruitSpeed.value)
        {
            case 1:
                fruitSpTxt.text = "Normal";
                fruitS = new Vector2(.5f, .5f);
                break;
            case 2:
                fruitSpTxt.text = "Fast";
                fruitS = new Vector2(2f, 2f);
                break;
            default:
                fruitS = new Vector2(.5f, .5f);
                fruitSpTxt.text = "Please Select";
                break;
        }

    }

}

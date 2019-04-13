using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect : MonoBehaviour
{
    public Dropdown myDropDownSpeed;
    public Dropdown myDropDownSpawn;
    public Dropdown myDropDownFrog;
    public Dropdown myDropDownCars;
    public Text myChoice;
    public Text myChoice1;
    public Text myChoice2;
    public Text myChoice3;

    static public float carSpeed = 8f;
    static public float spawnSpeed = 8f;
    public static Vector3 size;
    public static Vector3 frogSize;

    void Start()
    {
        //car = GameObject.Find("Car");
    }
    // Update is called once per frame
    void Update()
    {
        switch (myDropDownSpeed.value)
        {
            case 1:
                myChoice.text = "Slow";
                carSpeed = 5f;
                break;
            case 2:
                myChoice.text = "Medium";
                carSpeed = 10f;
                break;
            case 3:
                myChoice.text = "Fast";
                carSpeed = 15f;
                break;
            default:
                carSpeed = 10f;
                myChoice.text = "Please Select";
                break;
        }

        switch (myDropDownSpawn.value)
        {
            case 1:
                myChoice1.text = "Slow";
                spawnSpeed = .6f;
                break;
            case 2:
                myChoice1.text = "Medium";
                spawnSpeed = .4f;
                break;
            case 3:
                myChoice1.text = "Fast";
                spawnSpeed = .3f;
                break;
            default:
                spawnSpeed = .4f;
                myChoice1.text = "Please Select";
                break;
        }

        switch (myDropDownFrog.value)
        {
            case 1:
                myChoice2.text = "Small";
                size = new Vector3(1,.6F,1); 
                break;
            case 2:
                myChoice2.text = "Medium";
                size = new Vector3(1, 1, 1);
                break;
            default:
                size = new Vector3(1, 1, 1);
                myChoice2.text = "Please Select";
                break;
        }

        switch (myDropDownCars.value)
        {
            case 1:
                myChoice3.text = "Small";
                frogSize = new Vector3(1, .6F, 1);
                break;
            case 2:
                myChoice3.text = "Medium";
                frogSize = new Vector3(1, 1, 1);
                break;
            default:
                frogSize = new Vector3(1, 1, 1);
                myChoice3.text = "Please Select";
                break;
        }


    }
}

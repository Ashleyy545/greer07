using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unsliced : MonoBehaviour
{

    public Text sliced;
    public static int gameScore = 0;


    public Text unsliced;
    public static int amount = 0;

    public static int unTouched = 0;


    void Update()
    {
        sliced.text = gameScore.ToString();
        unsliced.text = unTouched.ToString();
        solve();

    }

    void solve()
    {
        unTouched = amount - gameScore;
        
    }
}

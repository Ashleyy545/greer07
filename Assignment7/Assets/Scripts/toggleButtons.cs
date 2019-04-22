using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void oneMin()
    {
        time.timePerQuestion = 60f;
    }

    public void fifteenSec()
    {
        time.timePerQuestion = 15f;
    }

    public void thirtySec()
    {
        time.timePerQuestion = 30f;
    }
}

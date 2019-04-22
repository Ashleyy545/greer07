using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeTrail : MonoBehaviour
{
    
    private TrailRenderer tr;

    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        tr.startWidth = DropDownSelect.blade;
        tr.endWidth = DropDownSelect.blade;
    }

    
}

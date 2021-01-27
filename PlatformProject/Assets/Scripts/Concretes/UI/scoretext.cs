using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    Text scoretex;
    public static int scoreValue;

    private void Start()
    {
        scoretex = GetComponent<Text>();
    }



    private void Update()
    {

        scoretex.text = scoreValue.ToString();


    }
}

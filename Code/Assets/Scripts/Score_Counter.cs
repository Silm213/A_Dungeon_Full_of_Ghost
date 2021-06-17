using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Counter : MonoBehaviour
{
    static int value = 0;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + value.ToString("d4");
    }

    public static void addvalue(int a)
    {
        value += a;
    }
}

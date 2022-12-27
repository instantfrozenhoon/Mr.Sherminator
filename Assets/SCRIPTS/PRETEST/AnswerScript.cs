using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{

    public bool isCorrect = false;
    public TestManager testManager;

    public void Answer()
    {

        if(isCorrect)
        {
            
            Debug.Log("Correct Answer");
            testManager.correct();
        }

        else
        {
          
            Debug.Log("Wrong Answer");
            testManager.wrong();
        }
    }
}
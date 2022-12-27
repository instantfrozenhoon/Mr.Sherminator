using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{

    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject TestPanel;
    public GameObject goPANEL;

    public Text QuestionText;
    public Text ScoreText;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {

        totalQuestions = QnA.Count;
        goPANEL.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    

    void GameOver()
    {

        TestPanel.SetActive(false);
        goPANEL.SetActive(true);
        ScoreText.text = score + "/" + totalQuestions;
    }

    public void correct()
    {

        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {
        
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            options[i].transform.GetChild(1).GetComponent<Image>().sprite = QnA[currentQuestion].picture[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                
                options[i].GetComponent<AnswerScript>().isCorrect = true;
                

            }
        }
    }

    void generateQuestion()
    {

        if (QnA.Count > 0)
        {

            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}
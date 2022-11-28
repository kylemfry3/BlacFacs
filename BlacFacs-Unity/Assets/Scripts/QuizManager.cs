using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour {
    public GameObject QuizScreen;
    public GameObject CorrectScreen;
    public GameObject IncorrectScreen;
    public TMP_Text IncorrectAnswerExplanation;
    public TMP_Text CorrectAnswerExplanation;
    public TMP_Text QuizPrompt;
    public Button Choice1;
    public TMP_Text Choice1Text;
    public Button Choice2;
    public TMP_Text Choice2Text;
    public Button Choice3;
    public TMP_Text Choice3Text;
    public Button Choice4;
    public TMP_Text Choice4Text;
    public Button CorrectContinueQuiz;
    public Button IncorrectContinueQuiz;

    public string GetAnswersArray(int question, int contentSelector) {
        string[,] questionBank = new string[5,3];
        questionBank[0, 0] = "What enslaved woman rose from a humble house servant to one of the most noted and most sought after chefs because of her extravagant multi-course meals?";
        questionBank[0, 1] = "Emeline Jones";
        questionBank[0, 2] = "Emeline Jones was born a slave in the 1830s, but by the 1880s, she had settled in Manhattan and established a prominent catering business. A number of prominent New York chefs trained under her and it is said that Presidents Arthur and Cleveland were so fond of her cooking that each offered her a big salary to serve as White House chef, but she refused.";

        questionBank[1, 0] = "Who was the first black graduate of architecture at the University of Pennsylvania and designer of several buildings on the Duke University campus?";
        questionBank[1, 1] = "Julian Abele";
        questionBank[1, 2] = "Julian Francis Abele was one of America’s most important architects, working as chief designer with one of the most prominent American architects, Horace Trumbauer. Abele designed the west campus of Duke University, including the university chapel, the Allen Administration Building, and the Duke Indoor Stadium. Duke's main quad was renamed the Abele Quad in 2016. Unfortunately, he was not publicly acknowledged in his lifetime.";

        questionBank[2, 0] = "What became the stage name for actor, singer, comedian, songwriter, television host and producer, Edward Marlon Bishop?";
        questionBank[2, 1] = "Jamie Foxx";
        questionBank[2, 2] = "In 1991, Jamie Foxx became a regular on 'In Living Color' until the show's end in 1994, after which he earned his own television sitcom The 'Jamie Foxx Show', in which he starred, co-created and produced, airing for five highly rated seasons from 1996 to 2001. He is likely best known for his portrayal of Ray Charles in the film 'Ray', for which he won the Academy Award, BAFTA, Screen Actors Guild Award, Critics' Choice Movie Award and Golden Globe Award for Best Actor.";

        questionBank[3, 0] = "In 1897 this Doctor became the first African American psychiatrist...";
        questionBank[3, 1] = "Solomon Carter Fuller";
        questionBank[3, 2] = "Dr. Solomon Fuller, born in Liberia, completed his college education and medical degree in the United States and studied psychiatry in Munich, Germany. Returning to the U.S. he became the first African American psychiatrist making great strides with Alzheimer's disease, schizophrenia, depression, and many other mental illnesses.";

        questionBank[4, 0] = "In what sport did the first African-American, Vonetta Flowers, win a gold medal in the 2002 Winter Olympics?";
        questionBank[4, 1] = "Bobsledding";
        questionBank[4, 2] = "On February 19, 2002, Vonetta Flowers, from Birmingham AL, became the 1st person of African descent to win a Gold Medal in the Winter Olympics; she won hers in bobsledding.";
    
        return questionBank[question, contentSelector];
    }

    int i = -1;

    void Start() {
        i++;
        QuizScreen.SetActive(true);
        CorrectScreen.SetActive(false);
        IncorrectScreen.SetActive(false);
        QuizPrompt.text = GetAnswersArray(i, 0);
        Choice1Text.text = "Not this one";
        Choice2Text.text = "Or this one";
        Choice3Text.text = "Not even this one";
        Choice4Text.text = GetAnswersArray(i, 1);

        Button choice1 = Choice1.GetComponent<Button>();
        choice1.onClick.AddListener(AnswerChoice1);

        Button choice2 = Choice2.GetComponent<Button>();
        choice2.onClick.AddListener(AnswerChoice2);

        Button choice3 = Choice3.GetComponent<Button>();
        choice3.onClick.AddListener(AnswerChoice3);

        Button choice4 = Choice4.GetComponent<Button>();
        choice4.onClick.AddListener(AnswerChoice4);

        Button incorrect_continue = IncorrectContinueQuiz.GetComponent<Button>();
        incorrect_continue.onClick.AddListener(Start);

        Button correct_continue = CorrectContinueQuiz.GetComponent<Button>();
        correct_continue.onClick.AddListener(Start); 
    }

    void AnswerChoice1() {
        string answer = GetAnswersArray(i, 1);
        if (answer.Equals(Choice1Text.text)) {
            CorrectScreen.SetActive(true);
            CorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        } else {
            IncorrectScreen.SetActive(true);
            IncorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        }
    }

    void AnswerChoice2() {
        string answer = GetAnswersArray(i, 1);
        if (answer.Equals(Choice2Text.text)) {
            CorrectScreen.SetActive(true);
            CorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        } else {
            IncorrectScreen.SetActive(true);
            IncorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        }
    }

    void AnswerChoice3() {
        string answer = GetAnswersArray(i, 1);
        if (answer.Equals(Choice3Text.text)) {
            CorrectScreen.SetActive(true);
            CorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        } else {
            IncorrectScreen.SetActive(true);
            IncorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        }
    }

    void AnswerChoice4() {
        string answer = GetAnswersArray(i, 1);
        if (answer.Equals(Choice4Text.text)) {
            CorrectScreen.SetActive(true);
            CorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        } else {
            IncorrectScreen.SetActive(true);
            IncorrectAnswerExplanation.text = GetAnswersArray(i, 2);
        }
    }
}
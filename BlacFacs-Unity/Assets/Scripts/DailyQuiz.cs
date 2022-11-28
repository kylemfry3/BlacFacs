using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DailyQuiz : MonoBehaviour {

	public Button dailyQuizStart;
    public GameObject HomeScreen;
	public GameObject QuizStartPage;

    void Start() {
        Button btn = dailyQuizStart.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        HomeScreen.SetActive(false);
        QuizStartPage.SetActive(true);
    }
}

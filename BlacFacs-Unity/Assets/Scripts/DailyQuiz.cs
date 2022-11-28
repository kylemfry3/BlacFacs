using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuiz : MonoBehaviour {

	public GameObject HomeScreen;
	public GameObject QuizStartPage;
	public Button dailyQuizStart;

    void Start() {
        Button btn = dailyQuizStart.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        HomeScreen.SetActive(false);
        QuizStartPage.SetActive(true);
    }
}

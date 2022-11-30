using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DailyQuiz : MonoBehaviour {

	public Button dailyQuizStart;
    public GameObject HomeScreen;
	public GameObject QuizStartPage;
    public GameObject QOTD_Complete_Flag;
    public GameObject QOTD_Notice;


    void Start() {
        Button btn = dailyQuizStart.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        if (QOTD_Complete_Flag.activeSelf) {
            QOTD_Notice.SetActive(true);
        } else {
            HomeScreen.SetActive(false);
            QuizStartPage.SetActive(true);
        }
    }
}

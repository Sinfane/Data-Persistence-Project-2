using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text inputName;
    public TMP_Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadScores();
        highScore.text = "High Score: " + DataManager.Instance.highScoreName + ": " + DataManager.Instance.highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        
        DataManager.Instance.playerName = inputName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }

    public void ResetScore()
    {
        DataManager.Instance.highScoreName = "";
        DataManager.Instance.highScore = 0;
        highScore.text = "High Score: " + DataManager.Instance.highScoreName + ": " + DataManager.Instance.highScore;
    }
}

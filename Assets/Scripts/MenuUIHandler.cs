using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Falaram que � interessante dar um delay no menu ent�o t� copiando.
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Bot�o Start pressionado");
    }
    public void StartMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("De volta para o Menu principal");
    }

    public void HighScores()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Top 5");
    }

    public void Exit()
    {
       // ColorPicker.SelectColor(MainManager.Instance.TeamColor);
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void NewScore(int score)
    {
        // Fun��o que faz a variavel "Score" do SubmitScore receber o novo score.

        SubmitScore.Instance.Score = score;
    }

}

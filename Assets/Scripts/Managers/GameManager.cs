
/// ----SaraSABER---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://1drv.ms/w/s!AgDnFacvwTrJgaQlvHY2xl-0eH2pVg?e=REYund
/// Editable version Here: https://1drv.ms/w/s!AgDnFacvwTrJgaQlvHY2xl-0eH2pVg?e=REYund
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

/// <summary>
/// Game Manager script (eeeeh, that is really a fast script done in a game jams, :))
/// </summary>
public class GameManager : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    private bool gameStarted;
    #endregion
    #region PUBLIC_VARIABLES

    public GameManager instance;
    public TMP_Text scoreText;
    public TMP_Text jumpText;
    public Animator UIInGameAnimator;
    public SceneVariables sceneVariables;

    [Header("Player's stuff")]
    public GameObject playerGO;
    public float maxjumps = 6;
    public float jumps=0;
    public int score = 0;


    #endregion
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE

    public void Awake()
    {
        if (instance == null) 
        {
            instance = this; 
        }
        else 
        {
            Destroy(gameObject); 
            return; 
        }
        DontDestroyOnLoad(gameObject);
    }
    //Example Method and comment
    private void Update()
    {
        if(SceneManager.GetActiveScene().name=="MainGameScene")
        {
            gameStarted = true;
        }
        if (gameStarted)
        {
            
            JumpUP();
        }
        
    }
    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC

    public void OnClickGameStart()
    {
        
        jumps = maxjumps;
        score = 0;
        jumpText.text = jumps.ToString();
        scoreText.text = score.ToString();
        SceneManager.LoadScene("MainGameScene");
        gameStarted = true;
    }
    public void OnClickGamePause()
    {
        Time.timeScale = 0;
        //Any UI activations and deactivation are setuo in the Editor :)
    }

    public void OnClickGameResume()
    {
        Time.timeScale = 1;
        //Any UI activations and deactivation are setuo in the Editor :)
    }

    public void OnClickGameRestart()
    {
        jumps = maxjumps;
        jumpText.text = jumps.ToString();
        SceneManager.LoadScene("MainGameScene");
    }

    public void ScoreUP()
    {
        
        score += 10 ;
        /*if(jumps<0)
        {
            jumps = 0;
            OnGameEnd();
        }*/
        //
        scoreText.text = ""+score;

    }

    public void JumpUP()
    {

        jumps = maxjumps - (float)Variables.ActiveScene.Get("Jumps");
        if (jumps < 0)
        {
            jumps = 0;
            OnGameEnd();
        }
        jumpText.text = "" + jumps;

    }

    public void OnGameEnd()
    {
        gameStarted = false;
        Time.timeScale = 0;
    }
    #endregion
    #endregion
}

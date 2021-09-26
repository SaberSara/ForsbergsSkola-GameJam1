
/// ----YinYangGames---2021-----
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
using UnityEngine.Scripting;


/// <summary>
/// Game Manager script (eeeeh, that is really a fast script done in a game jams, :))
/// </summary>
public class GameManager : MonoBehaviour
{
    #region PRIVATE_VARIABLES

    #endregion
    #region PUBLIC_VARIABLES

    public TMP_Text scoreText;
    public Animator UIInGameAnimator;
    

    #endregion
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    private void Update()
    {

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

    }

    public void ScoreUP()
    {

    }

    public void OnGameEnd()
    {

    }
    #endregion
    #endregion
}

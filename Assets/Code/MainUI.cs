using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public CanvasGroup resetPanel, playPanel;

    public void Start()
    {
        //reset screen ui
        Time.timeScale = 0;

        resetPanel.alpha = 0;
        playPanel.alpha = 1;

        playPanel.interactable = true;
        resetPanel.interactable = false;

        playPanel.blocksRaycasts = true;
        resetPanel.blocksRaycasts = false;
    }

    public void PlayButtonPressed()
    {
        Time.timeScale = 1;
        playPanel.alpha = 0;
        playPanel.interactable = false;
        playPanel.blocksRaycasts = false;
    }

    public void ResetButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

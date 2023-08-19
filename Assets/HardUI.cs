using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HardUI : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public Button resetButton;
    public GameObject door1;
    public GameObject door2;
    public GameObject objectToShow;
    public GameObject objectToShow2;
    public GameObject objectToShow3;
    public GameObject objectToShow4;
    public GameObject objectToShow5;
    public GameObject objectToHide;
    public GameObject objectToHide2;
    public TeleportToStart teleporter1;


    private float countdownTime = 100.0f;
    private bool isCountdownActive = false;

    private void OnEnable()
    {
        resetButton.onClick.AddListener(ResetCountdown);
        // Reset the countdown and start it again
        countdownTime = 100.0f;
        isCountdownActive = true;
        StartCoroutine(CountdownCoroutine());
    }

    private void OnDisable()
    {
        resetButton.onClick.RemoveListener(ResetCountdown);
        // Stop the countdown
        isCountdownActive = false;
    }

    private IEnumerator CountdownCoroutine()
    {
        while (countdownTime > 0 && isCountdownActive)
        {
            // Check if both objects are inactive
            if (!door1.activeSelf && !door2.activeSelf)
            {
                isCountdownActive = false;
            }

            countdownText.text = countdownTime.ToString("F1");
            yield return new WaitForSeconds(0.1f);
            countdownTime -= 0.1f;
        }

        // Check if both objects are inactive
        if (!door1.activeSelf && !door2.activeSelf)
        {
            countdownText.text = countdownTime.ToString("F1");
            isCountdownActive = false;
        }
        else
        {
            countdownText.text = "0.0";
            isCountdownActive = false;
            //teleporter1.TeleportPlayerToStart();
            ResetGame();
            objectToHide.SetActive(false);
            objectToHide2.SetActive(false);
        }
    }

    public void ResetCountdown()
    {
        // Reset the countdown and start it again
        countdownTime = 100.0f;
        countdownText.text = "100.0";
        isCountdownActive = true;
        //teleporter1.TeleportPlayerToStart();
        ResetGame();
        //StartCoroutine(CountdownCoroutine());
    }

    private void ResetGame()
    {
        teleporter1.TeleportPlayerToStart();
        objectToShow.SetActive(true);
        objectToShow2.SetActive(true);
        objectToShow3.SetActive(true);
        objectToShow4.SetActive(true);
        objectToShow5.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

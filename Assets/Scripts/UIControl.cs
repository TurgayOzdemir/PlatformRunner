using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{

    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject winPanel;

    [SerializeField] private GameObject gameoverRestartButton;
    [SerializeField] private GameObject gameoverExitButton;
    [SerializeField] private GameObject winNextButton;
    [SerializeField] private GameObject winExitButton;

    private Button _gameoverRestartButton;
    private Button _gameoverExitButton;
    private Button _winNextButton;
    private Button _winExitButton;

    private void Awake()
    {
        _gameoverRestartButton = gameoverRestartButton.GetComponent<Button>();
        _gameoverExitButton = gameoverExitButton.GetComponent<Button>();
        _winNextButton = winNextButton.GetComponent<Button>();
        _winExitButton = winExitButton.GetComponent<Button>();
    }

    private void Start()
    {
        gameoverPanel.SetActive(false);
        winPanel.SetActive(false);

        _gameoverRestartButton.onClick.AddListener(Restart);
        _gameoverExitButton.onClick.AddListener(Exit);
        _winNextButton.onClick.AddListener(Restart);
        _winExitButton.onClick.AddListener(Exit);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    void Exit()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("StaticObstacle") || other.CompareTag("HorizontalObstacle") || other.CompareTag("HalfDonut") || other.CompareTag("Fall"))
        {
            gameoverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        
        if (other.CompareTag("EndPoint"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}

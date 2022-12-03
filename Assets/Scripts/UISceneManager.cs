using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UISceneManager : MonoBehaviour
{
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Button quitButton;
    // Start is called before the first frame update
    public TMP_InputField inputField;
    void Start()
    {
        startButton.onClick.AddListener(StartGameOnClick);
        quitButton.onClick.AddListener(QuitGameOnClick);
    }

    private void StartGameOnClick()
    {
        ScoreManager.Instance.playerName = inputField.text;
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }

    private void QuitGameOnClick()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

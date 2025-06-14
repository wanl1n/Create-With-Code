using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static PlayerManager Instance;

    [SerializeField] private TMP_InputField input;
    public string playerName; // new variable declared

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        if (playerName.Length > 0)
            SceneManager.LoadScene(1);
        else
            Debug.Log("Please input name.");
    }

    public void UpdateName()
    {
        playerName = input.text;
    }
}
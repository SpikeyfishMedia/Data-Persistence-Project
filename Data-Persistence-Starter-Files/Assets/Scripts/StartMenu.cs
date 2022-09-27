using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public string playerName;
   
    public TMP_InputField playerInput;
    public static StartMenu Instance;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        playerName = playerInput.GetComponent<TMP_InputField>().text;
      //  Debug.Log("Input: "+ playerName);
      //  Debug.Log("Shu!");
        SceneManager.LoadScene(1);
        
    }

}

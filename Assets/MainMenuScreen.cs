using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    public void Setup(){
        gameObject.SetActive(true);
    }
    public void StartButton(){
        SceneManager.LoadScene("MainGame");
    }
}


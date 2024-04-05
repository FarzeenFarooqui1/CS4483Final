using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    private string sceneName = "SampleScene";
    public GameObject doNotOwn;
    
   public void MoveToScene()
    {
        if (CharacterStore.goodPack && CharacterStore.goodSuit)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            StartCoroutine(ShowMessage());
        }
    }

   public void EndGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    private IEnumerator ShowMessage()
    {
        doNotOwn.SetActive(true);
        yield return new WaitForSeconds(2);
        doNotOwn.SetActive(false);
    }
}

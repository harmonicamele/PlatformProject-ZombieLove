using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance { get; private set; }
    
    private void Awake()
    {
       
        if (Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
   
    public void LoadScene(int levelindex = 0)
    {
        StartCoroutine(LoadSceneAsync(levelindex));
        
    }

    private IEnumerator LoadSceneAsync(int levelindex)
    {
        yield return new WaitForSeconds(0);
        yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelindex);      
    }

   
    
    
    
       
    

}

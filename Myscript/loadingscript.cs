using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingscript : MonoBehaviour
{
   
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

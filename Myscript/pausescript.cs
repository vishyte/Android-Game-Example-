using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
   [SerializeField] GameObject pausegame;

   public void Pause()
   {
    pausegame.SetActive(true);
    Time.timeScale = 0f;
   }

   public void Resume()
   {
    pausegame.SetActive(false);
    Time.timeScale = 1f;
   }

//    public void Home(int SceneID)
//    {
//     Time.timeScale = 1f;
//     SceneManager.LoadScene(sceneID);

//    }
}

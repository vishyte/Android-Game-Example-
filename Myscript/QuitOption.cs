using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOption : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainCamera : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadSceneAsync("level1 1");
    }
}

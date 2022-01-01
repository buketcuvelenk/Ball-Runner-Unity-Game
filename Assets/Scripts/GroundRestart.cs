using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GroundRestart : MonoBehaviour
{
   void OnTriggerEnter()
    {
        SceneManager.LoadScene("MainScene");
    }
}

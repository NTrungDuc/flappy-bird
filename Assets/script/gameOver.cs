using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void playAgain()
    {
        SceneManager.LoadScene("playgame");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

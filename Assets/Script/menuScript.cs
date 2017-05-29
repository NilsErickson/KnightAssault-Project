using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public void miniGame2load()
    {
        SceneManager.LoadScene("2 Mini Game");
    }

    public void miniGameload()
    {
        SceneManager.LoadScene("Mini Game");
    }
}

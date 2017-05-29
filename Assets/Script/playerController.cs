using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerController : MonoBehaviour
{
    private int count;
    public Text countText;
    public Text ggText;

    //Script for collectables
    void Start()
    {
        count = 0;
        SetCountText();
        ggText.text = "";
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Collect: " + count.ToString();
        if (count >= 6)
        {
            ggText.text = "GG BRO!!!";
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{


    public float countdownTime = 30f;
    public Text countdownText; 

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(StartCountdown());
    }

    
    IEnumerator StartCountdown()
    {
        float timeRemaining = countdownTime;

        while (timeRemaining > 0)
        {
            
            if (countdownText != null)
            {
                countdownText.text = "Time remain:"+Mathf.Ceil(timeRemaining).ToString();
            }

            
            yield return new WaitForSeconds(1.0f);
            timeRemaining--;
        }

        loadscene();


    }

    public void loadscene()
    {
        SceneManager.LoadScene(1);
    }
}

    

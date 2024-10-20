using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement_Pig_Player1 : MonoBehaviour
{
    public float Speed1;
    public int score;
    public UI ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float currentSpeed = Speed1;
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentSpeed = Speed1 * 2;
        }


        //Move the Object: Control Keyboard - Player1 (W,S,A,D)
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("move forward");
            transform.Translate(0, 0, currentSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("move Backward");
            transform.Translate(0, 0, -currentSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("move Left");
            transform.Translate(Vector3.left *currentSpeed * Time.deltaTime, Camera.main.transform);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("move right");
            transform.Translate(Vector3.right * currentSpeed * Time.deltaTime, Camera.main.transform);
        }

    }



    public void Addscore(int amount)
    {
        score += amount;
        ui.SetScoreText(score);

    }
}

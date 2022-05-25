using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TajmerScript : MonoBehaviour
{
    // bool TimerOn = false;
    float currentTime = 0;
    float startingTime = 10;

    public Text txtTajmer;
  

    void Start()
    {
        // TimerOn = true;
        currentTime = startingTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            txtTajmer.text = currentTime.ToString("0");
        } else
            SceneManager.LoadScene(3);
    }
}

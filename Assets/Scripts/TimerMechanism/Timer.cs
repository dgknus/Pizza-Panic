using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timerImg;
    [SerializeField] private Text timerText;
    [SerializeField] private float currentTime;
    [SerializeField] private float duration;


    void Start()
    {
        
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(UpdateTime());

    }

    private IEnumerator UpdateTime(){
        while(currentTime >= 0){
            timerImg.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timerText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        yield return null;

    }

   
}

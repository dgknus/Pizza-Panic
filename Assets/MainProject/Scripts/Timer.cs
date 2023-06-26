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
    [SerializeField] public int pizzaNum;

    [SerializeField] public CollisionDetection cd;

    public int val;

    public GameObject healthBarContainer; // Reference to the HealthBarContainer GameObject

    void Start()
    {
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(UpdateTime());
        val = cd.k;
    }

    private IEnumerator UpdateTime()
    {
        while (currentTime >= 0)
        {
            timerImg.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timerText.text = currentTime.ToString();
            
            val = cd.k;
            print(val);

            // Check if the timer reached 60 seconds
            UpdateHealthBarFromTimer(currentTime, val);
            

            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        yield return null;
    }

    private void UpdateHealthBarFromTimer(float currentTime, int k)
    {
        int visiblePizzas =  k + Mathf.FloorToInt(currentTime / 60);  // Calculate the number of pizzas to be visible based on elapsed time
        pizzaNum = visiblePizzas;
        UpdateHealthBar(visiblePizzas); // Call the existing function to update the health bar with the updated pizza count
    }

    private void UpdateHealthBar(int pizzaCount)
    {
        for (int i = 0; i < healthBarContainer.transform.childCount; i++)
        {
            GameObject pizza = healthBarContainer.transform.GetChild(i).gameObject;

            if (i < pizzaCount)
                pizza.SetActive(true); // Enable the pizza GameObject
            else
                pizza.SetActive(false); // Disable the pizza GameObject
        }
    }
 
 
  
}
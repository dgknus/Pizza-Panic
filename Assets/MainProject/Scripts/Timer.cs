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

    public GameObject healthBarContainer; // Reference to the HealthBarContainer GameObject

    void Start()
    {
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(UpdateTime());
    }

    private IEnumerator UpdateTime()
    {
        while (currentTime >= 0)
        {
            timerImg.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timerText.text = currentTime.ToString();

            // Check if the timer reached 60 seconds
            if (currentTime % 60 == 0)
            {
                // Call a function to handle pizza visibility based on the elapsed time
                UpdateHealthBarFromTimer(currentTime);
            }

            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        yield return null;
    }

    private void UpdateHealthBarFromTimer(float currentTime)
    {
        int visiblePizzas =  1 + Mathf.FloorToInt(currentTime / 60); // Calculate the number of pizzas to be visible based on elapsed time
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
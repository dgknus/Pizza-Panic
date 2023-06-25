using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] public Text Ans;
    [SerializeField] private Button[] numberButtons;

    public string Answer = "123456";
    private ColorBlock[] defaultButtonColors;
    public float colorChangeDuration = 0.2f;

    private void Start()
    {
        // Store the default colors of the buttons
        defaultButtonColors = new ColorBlock[numberButtons.Length];
        for (int i = 0; i < numberButtons.Length; i++)
        {
            defaultButtonColors[i] = numberButtons[i].colors;
        }
    }

    public void Number(int number)
    {
        Ans.text += number.ToString();
        StartCoroutine(ChangeButtonColor(number));
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "Correct     ";
        }
        else
        {
            Ans.text = "Invalid      ";
        }
    }

    private IEnumerator ChangeButtonColor(int number)
    {
        // Get the index of the button based on the pressed number
        int buttonIndex = number;

        // Check if the button index is within the array bounds
        if (buttonIndex >= 0 && buttonIndex < numberButtons.Length)
        {
            // Change the button color to red temporarily
            ColorBlock colorBlock = numberButtons[buttonIndex].colors;
            colorBlock.normalColor = Color.red;
            numberButtons[buttonIndex].colors = colorBlock;

            // Wait for a short duration
            yield return new WaitForSeconds(colorChangeDuration);

            // Restore the button color to the default
            colorBlock.normalColor = defaultButtonColors[buttonIndex].normalColor;
            numberButtons[buttonIndex].colors = colorBlock;
        }
    }
}

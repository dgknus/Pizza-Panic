using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
 
[SerializeField] public Text Ans;

public string Answer = "123456";

public void Number(int number){

    Ans.text += number.ToString();

}

public void Execute(){

    if(Ans.text == Answer){

         Ans.text = "Correct     ";
    }
    else{

        Ans.text = "Invalid      ";
        
    }
}

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    public int max;
    public int min;
    int guess;
    public int answer = 35;
    
    void Start()
    {
        StartGame();
    }

    void StartGame() 
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number: ");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Debug.Log("Up Arrow key was pressed");
            min = guess;
            calculateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Debug.Log("Down Arrow key was pressed");
            max = guess;
            calculateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            // Debug.Log("Enter key was pressed");
            if(guess == answer){
                Debug.Log("Your number has been guessed!");
                
                StartGame();
            }else{
                Debug.Log("Guessing faild!");
            }
        }
            
    }

    void calculateGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
    }
}

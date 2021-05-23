using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State initialState;

    int[] oddNumbers = { 1, 3, 5, 7, 9 };
    State currentState;

    void Start()
    {
        currentState = initialState;
        textComponent.text = currentState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

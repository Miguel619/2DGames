using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State initialState;

    State currentState;

    void Start()
    {
        currentState = initialState;
        textComponent.text = currentState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    private void ManageState(){
        var nextStates = currentState.GetNextState();
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            currentState = nextStates[0];
            
        }else if(Input.GetKeyDown(KeyCode.Alpha2)){
            currentState = nextStates[1];
            
        }else if(Input.GetKeyDown(KeyCode.Alpha3)){
            currentState = nextStates[2];
            
        }
        textComponent.text = currentState.GetStateStory();
    }
}

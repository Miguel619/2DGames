using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(25,25)] [SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }


}

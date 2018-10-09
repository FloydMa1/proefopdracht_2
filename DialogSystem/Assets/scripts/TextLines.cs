using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLines : MonoBehaviour {

    string[] dialogs = new string[5] 
    {
        "Hey buddy!, How are you?",
        "Can i chear you up?",
        "*Giving V-Bucks*",
        "Too bad",
        "FLIP YOU!!"
    };

    string[] anwsers = new string[1]
    {
        "Give me V-Bucks"
    };

    public Dictionary<string, string> dialogTexts;

    public void Start()
    {
        dialogTexts = new Dictionary<string, string>();
        dialogTexts.Add("start", dialogs[0]);

        dialogTexts.Add("Not so happy", dialogs[1]);
        dialogTexts.Add("Give V-Bucks", dialogs[2]);
        dialogTexts.Add("anwser", anwsers[0]);

        dialogTexts.Add("i'm Good", dialogs[3]);

        dialogTexts.Add("leave", dialogs[4]);
    }

}

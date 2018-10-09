using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TreeAlgorithem : MonoBehaviour {

    public GameObject[] buttons;

    public GameObject replay;

    public Text anwserText;
    public Text dialogText;
    TextLines textLines;

    public void Start()
    {
        textLines = GetComponent<TextLines>();
        dialogText.text = textLines.dialogTexts["start"];
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Good()
    {
        dialogText.text = textLines.dialogTexts["i'm Good"];
    }

    public void Bad()
    {
        buttons[0].active = false;
        buttons[1].active = false;
        buttons[2].active = true;
        dialogText.text = textLines.dialogTexts["Not so happy"];
        anwserText.text = textLines.dialogTexts["anwser"];
    }

    public void GiveBucks()
    {
        
        dialogText.text = textLines.dialogTexts["Give V-Bucks"];
    }

    public void Leave()
    {
        dialogText.text = textLines.dialogTexts["leave"];
    }

}

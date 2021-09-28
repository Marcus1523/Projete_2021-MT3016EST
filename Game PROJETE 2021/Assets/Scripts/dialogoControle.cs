using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogoControle : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Settings")]
    public float typingSpeed;

    [Header("Custom")]
    [SerializeField()] private GameObject floatingBalloon;

    private IEnumerator sentenceEnumable;
    public bool isAlreadyOnDialogue { get; private set; }
    
    void MonoBehaviour () {
        this.ResetCanvas();
    }

    public bool Speech(Sprite p, string[] text, string actorName)
    {
        if (isAlreadyOnDialogue) return false;

        // set canvas
        profile.sprite = p;
        actorNameText.text = actorName;

        sentenceEnumable = _ChangeToNextSentence(text);
        ToNextSentence();

        return true;
    }

    IEnumerator TypeSentence(string sentence)
    {
        foreach (char letter in sentence)
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void _onDialogueStarted () {
        isAlreadyOnDialogue = true;
        dialogueObj.SetActive(true);
    }

    private void _onDialogueFinished () {
        isAlreadyOnDialogue = false;
        dialogueObj.SetActive(false);
    }

    public void ToNextSentence() {
        sentenceEnumable.MoveNext();
    }

    private IEnumerator _ChangeToNextSentence(string[] sentences)
    {
        _onDialogueStarted();

        foreach (string sentence in sentences) {
            this.ResetCanvas();
            var coroutine = StartCoroutine(TypeSentence(sentence));
            yield return true; // halts function
            StopCoroutine(coroutine);
        }

        _onDialogueFinished();
    }

    public void ResetCanvas () {
        speechText.text = "";
    }

    public GameObject GetFloatingBalloon () {
        return Instantiate(this.floatingBalloon);
    }
}
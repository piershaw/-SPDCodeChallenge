using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyButton : MonoBehaviour, IPointerClickHandler
{
    private CodeChallenge mCodeChallenge;
    private AudioSource audio;
    private int clickCount;

    void Start()
    {
        mCodeChallenge = GameObject.Find("Main").GetComponent<CodeChallenge>();
        audio = this.GetComponent<AudioSource>();
        clickCount = 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickCount > 1 || eventData.clickCount > 1)
        {
            clickCount = 0;
            mCodeChallenge.OnClickChangeColor();
            audio.Play();
        }
        else
        {
            clickCount++;
        }
    }

   }

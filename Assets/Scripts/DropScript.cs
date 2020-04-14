using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DropScript : MonoBehaviour, IDropHandler
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            //Get Circle position and make it the same as the square
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;
            score += 10;
            scoreText.text = "Score + " + score;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CodeChallenge : MonoBehaviour , IPointerClickHandler
{
    public Image rawIamge;
    public Sprite[] spriteShapes;
    public TMP_Dropdown menuShapes;
    private List<TMP_Dropdown.OptionData> optionsShapes;
    private Color color;
    private int selector;
    private string[] shapeNames;

     void Start()
    {
        selector = 0;
        shapeNames = new string[]
        {
             "Hexagon",
             "Triangle",
             "Circel",
             "Star",
             "Rectangle"
        };


        optionsShapes = new List<TMP_Dropdown.OptionData>();
        for (int s = 0; s < shapeNames.Length; s++)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();
            data.text = shapeNames[s];
            optionsShapes.Add(data);
        }

        menuShapes.AddOptions(optionsShapes);
    }


    public void OnClickChangeColor()
    {
        rawIamge.alphaHitTestMinimumThreshold = 0.001f;
        rawIamge.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
   
    }

    public void OnSelect()
    {
        int sel = menuShapes.value;
        rawIamge.sprite = spriteShapes[sel];

    }

    public void OnPointerClick(PointerEventData eventData)
    {

        Debug.Log(eventData);
        Debug.Log(eventData.clickCount);


        throw new System.NotImplementedException();
    }
}

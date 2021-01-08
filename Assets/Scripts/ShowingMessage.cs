using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum textType
{
    level_0,
    level_1,
    level_2,
}
public class ShowingMessage : MonoBehaviour
{      
    public GameObject message;
    public void CreateLogTextFromType(string text, textType level)
    {
        switch (level)
        {
            case textType.level_0:
                CreateLogText(5f, Color.green, 20f, text);
                break;
            case textType.level_1:
                CreateLogText(5f, Color.yellow, 25f, text);
                break;
            case textType.level_2:
                CreateLogText(10f, Color.red, 30f, text);
                break;
        }
    }
    void CreateLogText(float time, Color color, float size, string text)
    {
        GameObject copyText = Instantiate(message, this.transform);
        copyText.GetComponent<AboutMessage>().InitMessage(time, color, size, text);        
    }
}

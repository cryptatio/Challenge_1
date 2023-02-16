using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI TextMeshProUGUIClikedTimes;
    [SerializeField]
    private int intClickedTimes;

    public void vToClick()
    {
        this.TextMeshProUGUIClikedTimes.text = "Times Clicked: " + (++intClickedTimes).ToString();
    }
}

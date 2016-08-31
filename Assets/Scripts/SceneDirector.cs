using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SceneDirector : MonoBehaviour {
    [SerializeField] private AnswerDrawer answerDrawer;
    [SerializeField] private Text result;
    private static string answerTemplate = "Circle with radius {0} can hold maximum {1} chordes with offset of {2}";

    private static SceneDirector instance;
    public static SceneDirector Instance
    {
        get
        {
            return instance;
        }
    }

    void Start () {
        instance = this;
    }

    public void ReportResult(ChordePacker result)
    {
        ShowText(String.Format(answerTemplate, result.Radius, result.SetsPackedCount, result.OffsetLength));
        answerDrawer.DrawChords(result);
    }
	
	public void ShowText(string resultText)
    {
        result.text = resultText;
    }

    internal void Print(string toPrint)
    {
        Debug.Log(toPrint);
    }

    private void OnCalculationFinished()
    {

    }
}

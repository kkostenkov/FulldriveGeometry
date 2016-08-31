using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SceneDirector : MonoBehaviour {
    [SerializeField] private Text result;

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
	
	public void ShowResult(string resultText)
    {
        result.text = resultText;
    }

    internal void Print(string toPrint)
    {
        Debug.Log(toPrint);
    }
}

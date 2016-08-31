using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnswerDrawer : MonoBehaviour {
    [SerializeField] private GameObject chordeSetPrefab;
    private List<GameObject> drawnSets = new List<GameObject>();
	
	public void DrawChords (ChordePacker answer) {
        CrearDrawn();

        for (int i = 0; i < answer.SetsPackedCount; i++)
        {
            GameObject set = GameObject.Instantiate(chordeSetPrefab) as GameObject;
            set.GetComponent<ChordeSetPositioner>().Initialize(i, answer);
            drawnSets.Add(set);
        }

	}

    private void CrearDrawn()
    {
        foreach ( GameObject drawing in drawnSets)
        {
            Destroy(drawing);
        }
        drawnSets.Clear();
    }
}

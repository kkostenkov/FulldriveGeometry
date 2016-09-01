using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CalculateButton : MonoBehaviour {
    [SerializeField] Text radiusInputField;
    [SerializeField] Text chordeInputField;
    private float radius;
    private ulong chordeLength;

    public void OnButtonPressed()
    {
        float.TryParse(radiusInputField.text, out radius);
        ulong.TryParse(chordeInputField.text, out chordeLength);
        ChordePacker cPacker = new ChordePacker();
        cPacker.PackChordsToCircle(radius, chordeLength);
    }
}

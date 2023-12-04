using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ACTMPGUILanguage : MonoBehaviour {
[TextArea(5,20)]
    [SerializeField] List<string> text;
    TextMeshProUGUI spriteRender;

    void Start() {
        spriteRender = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        int currentlang = AC.Options.GetLanguage();
        spriteRender.text = text[currentlang];
    }
}

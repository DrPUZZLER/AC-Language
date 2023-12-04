using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class ACTMPLanguage : MonoBehaviour {
[TextArea(5,20)]
    [SerializeField] List<string> text;
    TextMeshPro spriteRender;

    void Start() {
        spriteRender = GetComponent<TextMeshPro>();
    }

    void Update() {
        int currentlang = AC.Options.GetLanguage();
        spriteRender.text = text[currentlang];
    }
}

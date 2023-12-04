using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ACImageLanguage : MonoBehaviour {
    [SerializeField] List<Sprite> sprites;
    Image spriteRender;

    void Start() {
        spriteRender = GetComponent<Image>();
    }

    void Update() {
        int currentlang = AC.Options.GetLanguage();
        spriteRender.sprite = sprites[currentlang];
    }
}

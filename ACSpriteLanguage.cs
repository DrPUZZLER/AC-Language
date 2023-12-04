using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

[RequireComponent(typeof(Sprite))]
public class ACSpriteLanguage : MonoBehaviour {

    [SerializeField] List<Sprite> sprites;
    SpriteRenderer spriteRender;

    void Start() {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    void Update() {
        int currentlang = AC.Options.GetLanguage();
        spriteRender.sprite = sprites[currentlang];
    }
}

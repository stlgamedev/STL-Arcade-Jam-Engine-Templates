using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ButtonIndex
{
    Button1, Button2
}

public class MoveButton : MonoBehaviour
{
    public ButtonIndex buttonIndex = ButtonIndex.Button1;

    public InputHelper inputHelper;

    public Sprite buttonUpSprite;
    public Sprite buttonDownSprite;

    private SpriteRenderer spriteRenderer;


    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyCode code = inputHelper.button1;
        if (buttonIndex == ButtonIndex.Button2)
        {
            code = inputHelper.button2;
        }
        if (Input.GetKey(code))
        {
            spriteRenderer.sprite = buttonDownSprite;
        } else
        {
            spriteRenderer.sprite = buttonUpSprite;
        }
    }
}

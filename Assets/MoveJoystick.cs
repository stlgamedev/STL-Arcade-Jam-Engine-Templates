using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJoystick : MonoBehaviour
{

    public Sprite upLeft;
    public Sprite up;
    public Sprite upRight;
    public Sprite left;
    public Sprite center;
    public Sprite right;
    public Sprite downLeft;
    public Sprite down;
    public Sprite downRight;

    private SpriteRenderer spriterRenderer;

    // Use this for initialization
    void Start()
    {
        spriterRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var vertical = 0;
        var horizontal = 0;
        if (Input.GetKey("up"))
        {
            vertical += 1;
        }
        if (Input.GetKey("down"))
        {
            vertical -= 1;
        }
        if (Input.GetKey("left"))
        {
            horizontal -= 1;
        }
        if (Input.GetKey("right"))
        {
            horizontal += 1;
        }

        if (vertical > 0)
        {
            if (horizontal < 0)
            {
                spriterRenderer.sprite = upLeft;
            }
            else if (horizontal > 0)
            {
                spriterRenderer.sprite = upRight;
            }
            else
            {
                spriterRenderer.sprite = up;
            }

        }
        else if (vertical < 0)
        {
            if (horizontal < 0)
            {
                spriterRenderer.sprite = downLeft;
            }
            else if (horizontal > 0)
            {
                spriterRenderer.sprite = downRight;
            }
            else
            {
                spriterRenderer.sprite = down;
            }
        }
        else
        {
            if (horizontal < 0)
            {
                spriterRenderer.sprite = left;
            }
            else if (horizontal > 0)
            {
                spriterRenderer.sprite = right;
            }
            else
            {
                spriterRenderer.sprite = center;
            }
        }
    }
}

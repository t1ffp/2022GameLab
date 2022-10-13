using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Image _cake;
    public Sprite _cake2;
    public Sprite _cake3;
    public Sprite _cake4;
    public Sprite _cake5;

    public void NextSprite()
    {
        _cake.sprite = _cake2;
        _cake2 = _cake3;
        _cake3 = _cake4;
        _cake4 = _cake5;
    }

}
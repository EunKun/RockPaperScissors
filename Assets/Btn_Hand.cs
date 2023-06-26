using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_Hand : MonoBehaviour
{
    [SerializeField]
    ROCKPAPERSCISSORS _hand;
    [SerializeField]
    Sprite _handImage;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = _handImage;
        GetComponent<Button>().onClick.AddListener(() => Btn_Result());
    }

    void Btn_Result()
    {
        var _temp = RandomEnum<ROCKPAPERSCISSORS>();
        Debug.Log(_temp.ToString());
        RuleManager.BattleResult(_hand, _temp);
    }

    private T RandomEnum<T>(){
        T[] values = (T[]) System.Enum.GetValues(typeof(T));
        return values[new System.Random().Next(0, values.Length)];
    }
}

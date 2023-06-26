using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ROCKPAPERSCISSORS
{
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameManager : MonoBehaviour
{
    public static GameManager ins;

    public Text battleResult;
    [SerializeField]
    Image _enemyImage;
    [SerializeField]
    Sprite _rock;
    [SerializeField]
    Sprite _paper;
    [SerializeField]
    Sprite _scissors;

    public void Result(string _result, ROCKPAPERSCISSORS _enemy)
    {
        battleResult.gameObject.SetActive(true);
        _enemyImage.gameObject.SetActive(true);
        battleResult.text = _result;

        switch (_result)
        {
            case "Win":
                break;
            case "Lose":
                break;
            case "Draw":
                break;
        }

        switch (_enemy)
        {
            case ROCKPAPERSCISSORS.ROCK:
                _enemyImage.sprite = _rock;
                break;
            case ROCKPAPERSCISSORS.PAPER:
                _enemyImage.sprite = _paper;
                break;
            case ROCKPAPERSCISSORS.SCISSORS:
                _enemyImage.sprite = _scissors;
                break;
        }
    }

    public void Restart()
    {
        battleResult.text = "";
        battleResult.gameObject.SetActive(false);
    }

    private void Start()
    {
        _enemyImage.gameObject.SetActive(false);
    }

    private void Awake()
    {
        if(ins == null)
        {
            ins = this;
        }
        else
            Destroy(ins);
    }
}

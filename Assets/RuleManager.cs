using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuleManager : MonoBehaviour
{
    public static void BattleResult(ROCKPAPERSCISSORS _player, ROCKPAPERSCISSORS _enemy)
    {
        string _result = string.Empty;
        if(_player == _enemy)
        {
            _result = "Draw";
        }

        if(_player == ROCKPAPERSCISSORS.ROCK)
        {
            if (_enemy == ROCKPAPERSCISSORS.SCISSORS)
                _result = "Win";
            else
                _result = "Lose";
        }

        if (_player == ROCKPAPERSCISSORS.SCISSORS)
        {
            if (_enemy == ROCKPAPERSCISSORS.PAPER)
                _result = "Win";
            else
                _result = "Lose";
        }

        if (_player == ROCKPAPERSCISSORS.PAPER)
        {
            if (_enemy == ROCKPAPERSCISSORS.ROCK)
                _result = "Win";
            else
                _result = "Lose";
        }

        GameManager.ins.Result(_result, _enemy);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickingManager : MonoBehaviour
{
    public Text textCoinFlipResult;
    public Text textD6RollResult;

    private void Start()
    {
        RepickBoth();
    }

    [ContextMenu("Repick Both")]
    public void RepickBoth()
    {
        RepickCoinflip();
        RepickDiceRoll();
    }

    [ContextMenu("Repick Coin Flip")]
    public void RepickCoinflip()
    {
        textCoinFlipResult.text = RandomPickFromData.PickRandomOneFromData<string>(
            new string[] {
                        "HEADS",
                        "TAILS"
            });
    }

    [ContextMenu("Repick Dice Roll")]
    public void RepickDiceRoll()
    {
        textD6RollResult.text = RandomPickFromData.PickRandomOneFromData<int>(
            new int[] {
                        1,2,3,4,5,6
            }).ToString();
    }

}

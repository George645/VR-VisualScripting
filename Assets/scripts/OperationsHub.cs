using System;
using UnityEngine;

public class OperationsHub : MonoBehaviour{
    public static int Addition(CharacterScript input1, CharacterScript input2) { //the added plus will be the thing to run this function
        int firstInt = GetEntireNumber(input1);
        int secondInt = GetEntireNumber(input2);
        return firstInt + secondInt;
    }
    public static int GetEntireNumber(CharacterScript input) {
        if (input.leftThing != null && input.leftThing.isNumber) {
            int returnInt = GetEntireNumber(input.leftThing);
            return returnInt;
        }
        string returningNumber = Convert.ToString(input.character);
        if (input.rightThing != null && input.rightThing.isNumber) {
            returningNumber += Convert.ToString(GetEntireNumber(input.rightThing));
            return Convert.ToInt32(returningNumber);
        }
        else {
            return Convert.ToInt32(returningNumber);
        }
    }
}

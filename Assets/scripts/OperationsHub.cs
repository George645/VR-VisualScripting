using System;
using UnityEngine;
using Unity.VisualScripting;
using System.Diagnostics.CodeAnalysis;
using UnityEditor;

[IncludeInSettings(true)]
public class OperationsHub : MonoBehaviour{
    /*public static int Addition(CharacterScript input1, CharacterScript input2) { //the added plus will be the thing to run this function
        int firstInt = GetEntireNumber(input1);
        int secondInt = GetEntireNumber(input2);
        return firstInt + secondInt;
    }*/
    public static int GetEntireNumberFromLeft(GameObject input) {
        GameObject objecta = (GameObject)Variables.Object(input).Get("leftThing");
        string temporaryString = "";
        int returningInt;
        bool thing = true;
        while (thing) {
            try {
                temporaryString = (string)Variables.Object(objecta).Get("character") + temporaryString;
                objecta = (GameObject)Variables.Object(objecta).Get("leftThing");
            }
            catch {
                Debug.Log(Variables.Object(objecta).Get<string>("character"));
                temporaryString = (string)Variables.Object(objecta).Get("character");
                Debug.Log("dfgh");
                thing = false;
            }
        }
        if (CountPlusses(temporaryString) >= 2) {
            for (int i = 0; i < CountPlusses(temporaryString); i++) {
                int locationOfTheFirstPlus = temporaryString.IndexOf('+');
                int firstNumberToAdd = Convert.ToInt32(temporaryString[0..locationOfTheFirstPlus]);
                Console.WriteLine(temporaryString);
                try {
                    int locationOfTheSecondPlus = temporaryString[(locationOfTheFirstPlus + 1)..].IndexOf('+') + locationOfTheFirstPlus + 1;
                    int secondNumberToAdd = Convert.ToInt32(temporaryString[(locationOfTheFirstPlus+1)..locationOfTheSecondPlus]);
                    temporaryString = Convert.ToString(firstNumberToAdd + secondNumberToAdd) + temporaryString[(locationOfTheSecondPlus + 1)..^0];
                }
                catch {
                    int secondNumberToAdd = Convert.ToInt32(temporaryString[(locationOfTheFirstPlus + 1)..]);
                    temporaryString = Convert.ToString(firstNumberToAdd + secondNumberToAdd);
                }
            }
            returningInt = Convert.ToInt32(temporaryString);
        }
        else if(CountPlusses(temporaryString) == 1) {
            returningInt = Convert.ToInt32(temporaryString[..temporaryString.IndexOf('+')]) + Convert.ToInt32(temporaryString[(temporaryString.IndexOf('+') + 1)..]);
        }
        else {
            Debug.Log("huasdg");
            Debug.Log(temporaryString);
            returningInt = Convert.ToInt32(temporaryString);
            Debug.Log("hksdg");
        }
        return returningInt;

    }
    public static int GetEntireNumberFromRight(GameObject input) {
        return 123456;
        /*string returningNumber = Convert.ToString(input.character);
        if (input.rightThing != null && input.rightThing.isNumber) {
            returningNumber += Convert.ToString(GetEntireNumber(input.rightThing));
            return Convert.ToInt32(returningNumber);
        }*/
    }
    private static int CountPlusses(string stringToCheck) {
        int counter = 0;
        foreach (char character in stringToCheck.ToCharArray()) {
            if (character == '+') {
                counter++;
            }
        }
        return counter;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
using Rnd = UnityEngine.Random;

public class DejaVuScript : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMBombModule Module;

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;

    private static int? staticVal = null; //Index of the chosen group/rule from 0-4
    private static bool? usingRules = null; //If this is false, every mod will have a group in common. Otherwise, every mod will have a rule number in common.

    void Awake () {
        moduleId = moduleIdCounter++;
        /*
        foreach (KMSelectable button in Buttons) 
            button.OnInteract += delegate () { ButtonPress(button); return false; };
        */

        //Button.OnInteract += delegate () { ButtonPress(); return false; };

    }

    void Start ()
    {
        if (staticVal == null)
            staticVal = Rnd.Range(0, 5);
        if (usingRules == null)
            usingRules = Ut.RandBool();
    }

    void Update ()
    {

    }

    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use <!{0} foobar> to do something.";
    #pragma warning restore 414

    IEnumerator ProcessTwitchCommand (string command)
    {
        command = command.Trim().ToUpperInvariant();
        List<string> parameters = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        yield return null;
    }

    IEnumerator TwitchHandleForcedSolve ()
    {
        yield return null;
    }
}

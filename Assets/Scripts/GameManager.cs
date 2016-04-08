﻿using UnityEngine;
using UnityTwine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour {

    public List<LoveInterest> loveInterests;
    public Mansion mansion;

    public static int currentDay;
    public static Room currentRoom;


    public static DialogController dialogControls;
    public static MapController mapControls;
    public static BackgroundController backgroundControls;
    public static LoveInterestSelectController loveInterestControls;

    public enum RoomName
    {
        Drawing,
        Parlor,
        Library,
        Kitchen,
        Dining,
        Pasture
    }

	public enum LoveInterestName
	{
		Beauregard,
		Henrietta,
		Lucille,
		John,
		Patrice,
		Noelle,
	}

    public enum Gifts
    {
        Oats,
        Letter,
        Software,
        Yarn,
        Picture
    }

    public void Awake()
    {
        //loveInterests = new List<LoveInterest>(GameObject.FindObjectsOfType<LoveInterest>());
        dialogControls = GameObject.FindObjectOfType<DialogController>();
        mapControls = GameObject.FindObjectOfType<MapController>();
        backgroundControls = GameObject.FindObjectOfType<BackgroundController>();
        loveInterestControls = GameObject.FindObjectOfType<LoveInterestSelectController>();
    }

    public LoveInterest getLoveInterest(GameManager.LoveInterestName name)
    {
        return loveInterests[(int)name];
    }

    public static void LoadRoom(Room room)
    {
		Debug.Log ("Loading room!");
        currentRoom = room;
        backgroundControls.displayRoom(room.background);
    }
    
    //Need to put common functions that occur all the time here (like changing rooms, displaying dialog, etc.)
    public static void StartConversation(TwineStory story)
    {
        dialogControls.StartConversation(story);
        mapControls.hideControls();
    }

    public static void EndConversation()
    {
        dialogControls.CloseConversation();
        mapControls.displayControls();
    }


    public static void AdvanceDay()
    {
        currentDay++;
    }
}

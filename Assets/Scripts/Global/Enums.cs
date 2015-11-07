﻿using UnityEngine;
using System.Collections;

public enum TILE_TYPE
{
	Cave, Village, ControlPoint, Neutral, Production, Block
};

public enum PLAYERS
{    
	None = -1,
	Baroque = 0,
    Retroish
}

public enum NEUTRAL_BEATS
{
    Neutral1 = 0
};

public enum GAME_STATE
{
	Creation = 0,
	InitTheMap,
	PhaseBegins,
	DisplayCurrentTurn,
	InitCurrentTurn,
	PlayCurrentPlayer,
	EndOfCurrentPlayer,
	EndOfTurn
};

public enum DIRECTIONS
{
	EAST, 
	WEST,
	NORTHEAST,
	NORTHWEST,
	SOUTHEAST,
	SOUTHWEST
};
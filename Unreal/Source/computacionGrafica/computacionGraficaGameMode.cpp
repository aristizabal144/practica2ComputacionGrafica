// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "computacionGraficaGameMode.h"
#include "computacionGraficaPawn.h"

AcomputacionGraficaGameMode::AcomputacionGraficaGameMode()
{
	// set default pawn class to our character class
	DefaultPawnClass = AcomputacionGraficaPawn::StaticClass();
}


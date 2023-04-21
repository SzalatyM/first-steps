﻿using System;

namespace FirstSteps.RPG.Items
{
    public class HeroCantHoldItemException : Exception
    {
        const string text = "You can't hold this item";
        public HeroCantHoldItemException() : base(text)
        {

        }
    }
}
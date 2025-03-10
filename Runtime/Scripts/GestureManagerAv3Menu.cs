/* Copyright (c) 2020-2022 Lyuma <xn.lyuma@gmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

using System;
using UnityEngine;
using System.Collections.Generic;
using VRC.SDK3.Avatars.ScriptableObjects;

namespace Lyuma.Av3Emulator.Runtime
{
    public class GestureManagerAv3Menu : LyumaAv3Menu
    {

        // public LyumaAv3Runtime Runtime;
        // public VRCExpressionsMenu RootMenu;
        // public bool IsMenuOpen { get; private set; }
        // private int? _activeControlIndex = null;
        // private string _activeControlParameterName;
        public bool compact = true;

        private void Awake()
        {
            IsMenuOpen = true;

        if (LyumaAv3Runtime.addRuntimeDelegate != null) {
                LyumaAv3Runtime.addRuntimeDelegate(this);
            }
        }

        // public void ToggleMenu()
        // {

        //     IsMenuOpen = !IsMenuOpen;
        // }

    }
}
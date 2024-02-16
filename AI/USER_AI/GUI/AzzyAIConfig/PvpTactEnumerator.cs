﻿// PvpTactEnumerator.cs
//
// Programmed by Machiavellian of iRO Chaos
//
// Description:
// This file contains the PvpTactEnumerator, which implements the generic
// interface IEnumerator<T>.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;


namespace AzzyAIConfig
{
    class PvpTactEnumerator : System.Collections.Generic.IEnumerator<PvpTact>
    {
        PvpTact[] _list;
        int _index = -1;

        public PvpTactEnumerator(PvpTact[] list)
        {
            // Set the list
            _list = list;
        }

        public PvpTact Current
        {
            get { return _list[_index]; }
        }

        public void Dispose()
        {
        }

        object IEnumerator.Current
        {
            get { return _list[_index]; }
        }

        public bool MoveNext()
        {
            // Increment the index
            _index++;

            // Check if the index is within the bounds of the list
            if (_index < _list.Length)
            {
                // Return true
                return true;
            }

            // Return false
            return false;
        }

        public void Reset()
        {
            // Reset the index
            _index = -1;
        }
    }
}
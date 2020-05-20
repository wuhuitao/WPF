// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.Windows.Media;

using MS.Internal;
using MS.Win32;

namespace System.Windows.Automation.Peers
{
    ///
    public class TabControlAutomationPeer : SelectorAutomationPeer, ISelectionProvider
    {
        ///
        public TabControlAutomationPeer(TabControl owner): base(owner)
        {}

        ///
        override protected ItemAutomationPeer CreateItemAutomationPeer(object item)
        {
            return new TabItemAutomationPeer(item, this);
        }

        ///
        override protected AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Tab;
        }

        ///
        override protected string GetClassNameCore()
        {
            return "TabControl";
        }

        ///
        protected override Point GetClickablePointCore()
        {
            return new Point(double.NaN, double.NaN);
        }

        bool ISelectionProvider.IsSelectionRequired
        {
            get
            {
                return true;
            }
        }
    }
}




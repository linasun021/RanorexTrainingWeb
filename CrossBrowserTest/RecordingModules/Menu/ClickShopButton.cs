﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CrossBrowserTest.RecordingModules.Menu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickShopButton recording.
    /// </summary>
    [TestModule("a9c3430e-6a35-4d26-84f0-19a9da43973d", ModuleType.Recording, 1)]
    public partial class ClickShopButton : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CrossBrowserTest.RXTrainingWebAppRepository repository.
        /// </summary>
        public static global::CrossBrowserTest.RXTrainingWebAppRepository repo = global::CrossBrowserTest.RXTrainingWebAppRepository.Instance;

        static ClickShopButton instance = new ClickShopButton();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickShopButton()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickShopButton Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'JupiterPrimeGoogleChrome.Menu.MenuShop'.", repo.JupiterPrimeGoogleChrome.Menu.MenuShopInfo, new RecordItemIndex(0));
            repo.JupiterPrimeGoogleChrome.Menu.MenuShop.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Open() on item 'JupiterPrimeGoogleChrome.Menu.MenuShop'.", repo.JupiterPrimeGoogleChrome.Menu.MenuShopInfo, new RecordItemIndex(1));
            repo.JupiterPrimeGoogleChrome.Menu.MenuShop.Open();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

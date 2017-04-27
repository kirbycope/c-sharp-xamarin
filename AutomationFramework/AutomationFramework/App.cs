using AutomationFramework.POMs;
using System.IO;
using Xamarin.UITest;

namespace AutomationFramework
{
    public class App
    {
        internal static IApp app;

        #region App Methods

        /// <summary>
        /// Navigate back on the device.
        /// </summary>
        public static void Back()
        {
            app.Back();
        }

        /// <summary>
        /// Hides keyboard if present.
        /// </summary>
        public static void DismissKeyboard()
        {
            app.DismissKeyboard();
        }

        /// <summary>
        /// Presses the enter key in the app.
        /// </summary>
        public static void PressEnter()
        {
            app.PressEnter();
        }

        /// <summary>
        /// Presses the volume down button on the device.
        /// </summary>
        public static void PressVolumeDown()
        {
            app.PressVolumeDown();
        }

        /// <summary>
        /// Presses the volume up button on the device.
        /// </summary>
        public static void PressVolumeUp()
        {
            app.PressVolumeUp();
        }

        /// <summary>
        /// Starts an interactive REPL (Read-Eval-Print-Loop) for app exploration and pauses test execution until it is closed.
        /// </summary>
        public static void Repl()
        {
            app.Repl();
        }

        /// <summary>
        /// Takes a screenshot of the app in it's current state. This is used to denote test steps in the Xamarin Test Cloud.
        /// </summary>
        public static FileInfo Screenshot(string title)
        {
            return app.Screenshot(title);
        }

        /// <summary>
        /// Changes the device (iOS) or current activity (Android) orientation to landscape mode.
        /// </summary>
        public static void SetOrientationLandscape()
        {
            app.SetOrientationLandscape();
        }

        /// <summary>
        /// Changes the device (iOS) or current activity (Android) orientation to portrait mode.
        /// </summary>
        public static void SetOrientationPortrait()
        {
            app.SetOrientationPortrait();
        }

        /// <summary>
        /// Performs a left to right swipe gesture.
        /// </summary>
        public static void SwipeLeftToRight()
        {
            app.SwipeLeftToRight();
        }

        /// <summary>
        /// Performs a left to right swipe gesture on an element.
        /// </summary>
        /// <param name="appControl"></param>
        public static void SwipeLeftToRight(AppControl appControl)
        {
            app.SwipeLeftToRight(appControl.controlIdQuery);
        }

        /// <summary>
        /// Performs a right to left swipe gesture.
        /// </summary>
        public static void SwipeRightToLeft()
        {
            app.SwipeRightToLeft();
        }

        /// <summary>
        /// Performs a right to left swipe gesture.
        /// </summary>
        public static void SwipeRightToLeft(AppControl appControl)
        {
            app.SwipeRightToLeft(appControl.controlIdQuery);
        }

        #endregion

        #region Page Object Models
        
        // "Home" page object
        public static HomePageObject HomePage
        {
            get
            {
                return new HomePageObject();
            }
        }
        
        #endregion
    }
}
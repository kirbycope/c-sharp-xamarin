using System;
using System.Text;
using Xamarin.UITest.Queries;

namespace AutomationFramework
{
    public class AppControl
    {
        public Func<AppQuery, AppQuery> controlIdQuery;
        TimeSpan timeout = TimeSpan.FromSeconds(60);

        #region Object constructor(s)

        public AppControl(Func<AppQuery, AppQuery> idQuery)
        {
            controlIdQuery = idQuery;
        }

        #endregion Object constructor(s)

        #region Properties

        /// <summary>
        /// The class of the view element.
        /// </summary>
        public virtual string Class
        {
            get
            {
                string _class = "";
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _class = appResult[0].Class;
                }
                return _class;
            }
        }

        /// <summary>
        /// A platform specific text representation of the view element.
        /// </summary>
        public virtual string Description
        {
            get
            {
                string _description = "";
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _description = appResult[0].Description;
                }
                return _description;
            }
        }

        /// <summary>
        /// Returns true if element is present and have some dimensions greater than 0
        /// </summary>
        public virtual bool Displayed
        {
            get
            {
                bool _displayed = false;
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    if ((appResult[0].Rect.Height > 0) && (appResult[0].Rect.Width > 0))
                    {
                        _displayed = true;
                    }
                }
                return _displayed;
            }
        }

        /// <summary>
        /// Whether the element is enabled or not.
        /// </summary>
        public virtual bool Enabled
        {
            get
            {
                bool _enabled = false;
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _enabled = appResult[0].Enabled;
                }
                return _enabled;
            }
        }

        /// <summary>
        /// The identifier of the view element. For Android: The id of the element. For iOS: The accessibilityIdentifier of the element.
        /// </summary>
        public virtual string Id
        {
            get
            {
                string _id = "";
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _id = appResult[0].Id;
                }
                return _id;
            }
        }

        /// <summary>
        /// The label of the view element. For Android: The contentDescription of the element.
        /// For iOS: The accessibilityLabel of the element.
        /// </summary>
        public virtual string Label
        {
            get
            {
                string _label = "";
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _label = appResult[0].Label;
                }
                return _label;
            }
        }

        /// <summary>
        /// The Xamarin.UITest.Queries.AppRect rectangle representing the elements position and size.
        /// </summary>
        public virtual AppRect Rect
        {
            get
            {
                AppRect _rect = new AppRect();
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _rect = appResult[0].Rect;
                }
                return _rect;
            }
        }

        /// <summary>
        /// The text of the view element.
        /// </summary>
        public virtual string Text
        {
            get
            {
                string _text = "";
                AppResult[] appResult = App.app.Query(controlIdQuery);
                if (appResult.Length > 0)
                {
                    _text = appResult[0].Text;
                }
                return _text;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clears text from a matching element that supports it.
        /// </summary>
        public virtual void ClearText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.ClearText()");
            try
            {
                App.app.ClearText(controlIdQuery);
                sb.AppendLine("    [SUCCESS] Text cleared");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
        }

        /// <summary>
        /// Enters text into a matching element that supports it.
        /// </summary>
        public virtual void EnterText(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.EnterText(text)");
            sb.AppendLine("    [INFO] Text: " + text);
            try
            {
                App.app.EnterText(controlIdQuery, text);
                sb.AppendLine("    [SUCCESS] Text entered");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
        }

        /// <summary>
        /// Highlights the results of the query by making them flash. 
        /// </summary>
        public virtual AppResult[] Flash()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.Flash()");
            AppResult[] appResult = null;
            try
            {
                appResult = App.app.Flash(controlIdQuery);
                sb.AppendLine("    [SUCCESS] Element flashed");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
            return appResult;
        }

        /// <summary>
        /// Queries view objects using the fluent API. Defaults to only return view objects that are visible.
        /// </summary>
        public virtual AppResult[] Query()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.Query()");
            AppResult[] appResult = null;
            try
            {
                appResult = App.app.Query(controlIdQuery);
                sb.AppendLine("    [SUCCESS] Element queried");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
            return appResult;
        }

        /// <summary>
        /// Performs a tap/touch gesture on the matched element.
        /// If multiple elements are matched, the first one will be used.
        /// </summary>
        public virtual AppControl Tap()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.Tap()");
            try
            {
                App.app.Tap(controlIdQuery);
                sb.AppendLine("    [SUCCESS] Element tapped");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
            return this;
        }

        /// <summary>
        /// Wait function that will repeatly query the app until a matching element is found.
        /// Throws a System.TimeoutException if no element is found within the time limit.
        /// </summary>
        public virtual void WaitForElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.WaitForElement()");
            try
            {
                App.app.WaitForElement(controlIdQuery, "Timed out waiting for element: " + controlIdQuery.ToString(), timeout);
                sb.AppendLine("    [SUCCESS] Element found");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
        }

        /// <summary>
        /// Wait function that will repeatly query the app until a matching element is not found.
        /// Throws a System.TimeoutException if no element is found within the time limit.
        /// </summary>
        public virtual void WaitForElementNotDisplayed()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppControl.WaitForElementNotDisplayed()");
            try
            {
                App.app.WaitForNoElement(controlIdQuery, "Element displayed after the timeout! " + controlIdQuery.ToString(), timeout);
                sb.AppendLine("    [SUCCESS] Element not found");
            }
            catch (Exception e)
            {
                sb.AppendLine("    [ERROR] Exception: " + e.Message);
                throw e;
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
        }

        #endregion
    }
}

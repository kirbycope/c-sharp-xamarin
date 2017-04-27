using System;
using System.Text;
using Xamarin.UITest.Queries;

namespace AutomationFramework
{
    public class AppWebControl
    {
        Func<AppQuery, AppWebQuery> controlIdQuery;
        TimeSpan timeout = TimeSpan.FromSeconds(60);

        public AppWebControl(Func<AppQuery, AppWebQuery> idQuery)
        {
            controlIdQuery = idQuery;
        }

        /// <summary>
        /// Clears text from a matching element that supports it.
        /// </summary>
        public virtual void ClearText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppWebControl.ClearText()");
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
            sb.AppendLine("AppWebControl.EnterText(text)");
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
        /// Performs a tap/touch gesture on the matched element.
        /// If multiple elements are matched, the first one will be used.
        /// </summary>
        public virtual void Tap()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppWebControl.Tap()");
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
        }

        /// <summary>
        /// Wait function that will repeatly query the app until a matching element is found.
        /// Throws a System.TimeoutException if no element is found within the time limit.
        /// </summary>
        public virtual void WaitForElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AppWebControl.WaitForElement()");
            try
            {
                App.app.WaitForElement(controlIdQuery, "Timed out waiting for element!" + controlIdQuery.ToString(), timeout);
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
    }
}

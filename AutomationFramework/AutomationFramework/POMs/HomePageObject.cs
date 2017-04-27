namespace AutomationFramework.POMs
{
    public class HomePageObject
    {
        public HomePageObject()
        {
            /* Empty Constructor */
        }

        #region Page Elements

        public AppControl imgLogo
        {
            get
            {
                return new AppControl(x => x.Id("logo"));
            }
        }

        #endregion

        #region Page Methods

        #endregion
    }
}

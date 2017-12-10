namespace Infrastructure
{
    public static class Utility
    {

        #region Default Constractor

        static Utility()
        {
        }

        #endregion / Default Constractor

        #region Default Date Time System Property
        public static Models.User AuthenticatedUser { get; set; }

        /// <summary>
        /// پراپرتی استاتیک که زمان جاری را برمیگرداند
        /// </summary>
        public static System.DateTime Now
        {
            get
            {
                return (System.DateTime.Now);
            }
        }

        #endregion / Default Date Time System Property

        #region 
        #endregion

        #region 
        #endregion

        #region 
        #endregion

    }
}


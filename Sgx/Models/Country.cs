namespace Models
{
    /// <summary>
    /// کلاس کانتری که از کلاس بیس انتیتی ویت ایز اکتیو اینهریت شده است
    /// کلاس هایی به جدول تبدیل میشود که در دیتابیس کانتکست یک کالکشن براشون ایجاد شده باشد
    /// </summary>
    public class Country : System.Object
    {
        /// <summary>
        /// write default constractor
        /// </summary>
        public Country() 
            : base()
        {
            ID = System.Guid.NewGuid();
        }

        /// <summary>
        /// Country Id : Property
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key()]
        [System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.Schema.Column("CountryId")]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
        (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid ID { get; set; }

        /// <summary>
        /// Country Name : Property
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.Schema.Column("CountryName")]
        public string Name { get; set; }

        /// <summary>
        /// Display Country Name : Property
        /// </summary>
        public string DisplayName
        {
            get
            {
                string strResult =
                    string.Format("{0} - [{1}]", ID, Name);

                return (strResult);
            }
        }

    }
}

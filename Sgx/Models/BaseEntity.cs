namespace Models
{
    public class BaseEntity : object
    {
        public BaseEntity() : base()
        {
            Id = System.Guid.NewGuid();
        }

        //*******************************************************************************************
        //public System.Guid Id { get; set; }

        //*******************************************************************************************

        //*******************************************************************************************
        /// <summary>
        /// Country Id : Property
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key()]
        [System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.Schema.Column("Id")]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
        (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid Id { get; set; }

        //*******************************************************************************************


        //*******************************************************************************************

        //*******************************************************************************************


        //*******************************************************************************************

        //*******************************************************************************************
    }
}

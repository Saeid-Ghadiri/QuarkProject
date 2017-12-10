namespace Models
{
    public class Name : BaseEntity
    {
        public Name() : base()
        {
        }

        //*******************************************************************
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FirstName { get; set; }
        //*******************************************************************

        //*******************************************************************
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string LastName { get; set; }
        //*******************************************************************

        //*******************************************************************
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string MiddleName { get; set; }
        //*******************************************************************

        //*******************************************************************
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Nickname { get; set; }
        //*******************************************************************

        //*******************************************************************
        // Complex model FullName

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName + "معروف به:" + Nickname;
            }
        }
        //*******************************************************************
    }
}

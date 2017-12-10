namespace Models
{
    public class Person : Name
    {
        public Person() : base()
        {
        }



        //************
        //[System.ComponentModel.DataAnnotations.Required
        //    (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.DataType
            (System.ComponentModel.DataAnnotations.DataType.DateTime)]
        public System.DateTime? DateOfBirth { get; set; }
        //************

        //************
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 11, ErrorMessage = "Use 11 Character", MinimumLength = 11)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string NationalCode { get; set; }
        //************

        //************
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.DataType
            (System.ComponentModel.DataAnnotations.DataType.EmailAddress,
            ErrorMessage = "Not a valid email address")]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 64)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Email { get; set; }
        //************

        //************
        public byte[] Picture { get; set; }
        //************

        //************
        //************

        //************
        //************

        //************
        //************


    }
}






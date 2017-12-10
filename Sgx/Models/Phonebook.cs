namespace Models
{
    public class Phonebook : Person
    {
        public Phonebook() : base()
        {
        }

        //************
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 11, ErrorMessage = "تعداد کاراکترهایی ورودی باید 11 عدد باشد!", MinimumLength = 11)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Telephone { get; set; }
        //************

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 11, ErrorMessage = "تعداد کاراکترهایی ورودی باید 11 عدد باشد!", MinimumLength = 11)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Fax { get; set; }
        //************

        //************
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 11, ErrorMessage = "تعداد کاراکترهایی ورودی باید 11 عدد باشد!", MinimumLength = 11)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string CellPhone { get; set; }
        //************

        //************
        public string Address { get; set; }
        //************

        // **********
        public string Description { get; set; }
        // **********
    }

}
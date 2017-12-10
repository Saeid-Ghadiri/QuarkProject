namespace Models
{
    public class User : BaseEntity
    {
        //Defualt Costractor
        public User() : base()
        {
        }


        //---------------------------------------------------------------- Reglage User Table ---------------------------------------------------------------------

        // **********
        public bool IsActive { get; set; }
        // **********

        // **********
        public bool IsAdmin { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20, MinimumLength = 1, ErrorMessage = ("Use 5-20 characters"))]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string Username { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 40, MinimumLength = 1, ErrorMessage = ("Use 6-40 characters"))]
        public string Password { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FullName { get; set; }
        // **********

        // **********
        public string Description { get; set; }
        // **********
    }
}

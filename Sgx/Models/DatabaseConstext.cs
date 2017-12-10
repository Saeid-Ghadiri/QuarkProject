namespace Models
{
    /// <summary>
    /// DatabaseContext فقط یک نام است.
    /// این کلاس باید حتما از کلاس دیگری با نام DbContext --> Inherit گردد.
    /// </summary>
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        /// <summary>
        /// سازنده استاتیک کلاس دیتا بیس کانتکست
        /// این سازنده حداکثر یک بار اتفاق میفتد
        /// یا اولین بار که با یک ممبر استاتیک از این کلاس کار کار میکنیم
        /// یا اولین بار که یک شی از این کلاس میسازیم 
        /// این سازنده اور لود ندارد و اکسز مادی فایر نیز ندارد و خروجی هم ندارد
        /// استراتژی های دیتا بیس را در این سازنده می نویسم
        /// </summary>
        static DatabaseContext()
        {
            // اين گزينه به درد برنامه نويسان می خورد
            //این استراتژی یعنی هر وقت که برنامه اجرا میشود اگر دیتا بیس وجود ندارد میسازد و 
            //اگر در مدل تغییری حاصل شده بود دیتا بیس را پاک میکند و مجددا میسازد
            //افزودن و پاک کردن فیلد  و پراپرتی در مدل نیز جز تغییرات حساب میشود
            System.Data.Entity.Database.SetInitializer
                (new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());

        }

        public DatabaseContext() : base()
        {
        }

        public System.Data.Entity.DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Phonebook> Phonebooks { get; set; }

        //به این خاطر این کلاس رو اینجا نمیاریم که موضوع استفاده از پدر فرزندی درست عمل کند
        //یعنی اینکه: ما یه کلاس پدر با نام person ایجاد کردیم
        //حالا کلاس Phonebook فرزند کلاس پدر است.
        //public System.Data.Entity.DbSet<Person> Pepole { get; set; }


        public System.Data.Entity.DbSet<Country> Countries { get; set; }

    }
}

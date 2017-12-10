using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgx.Ztest
{
    class complexType
    {
    }
}

////#################################################
namespace Models
{
    /// <summary>
    /// کلاس نام کامل با اتربیوت کامپلکس تایپ
    /// </summary>
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
    public class FullName : System.Object
    {
        /// <summary>
        /// سازنده پیش فرض کلاس
        /// </summary>
		public FullName()
        {
        }

        /// <summary>
        /// سازنده با ورودی نام  و نام خانوادگی
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
		public FullName(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        /// <summary>
        /// پراپرتی نام 
        /// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.MaxLength(20)]
        public string FirstName { get; set; }

        /// <summary>
        /// پراپرتی نام میانی
        /// </summary>
		[System.ComponentModel.DataAnnotations.MaxLength(20)]
        public string MiddleName { get; set; }

        /// <summary>
        /// پراپرتی نام خانودگی
        /// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.MaxLength(30)]
        public string LastName { get; set; }
    }
}


////#################################################
//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| databasecontext ||||||||||||||||||||||||||||||||||||||||||||||

//namespace Models
//{
//    /// <summary>
//    /// کلاس دیتا بیس کانتکست که از دی بی کانتکست اینهریت شده است
//    /// </summary>
//	public class DatabaseContext : System.Data.Entity.DbContext
//    {
//        /// <summary>
//        /// سازنده استاتیک
//        /// </summary>
//		static DatabaseContext()
//        {
//            System.Data.Entity.Database.SetInitializer
//                (new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
//        }

//        /// <summary>
//        /// سازنده پیش فرض
//        /// </summary>
//		public DatabaseContext()
//        {
//        }

//        /// <summary>
//        /// ایجاد یک کالکشن که در دیتا بیس جدول میشود که از جنس پرسون و بانام پیپل هست
//        /// </summary>
//		public System.Data.Entity.DbSet<Person> People { get; set; }
//    }
//}


////#################################################
namespace Models
{
    /// <summary>
    /// کلاس آدرس با اتربویت کامپلکس تایپ
    /// </summary>
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
    public class Address : System.Object
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public Address()
        {
        }

        /// <summary>
        /// سازنده با یک ورودی کشور
        /// </summary>
        /// <param name="country"></param>
		public Address(string country)
        {
            Country = country;
        }

        /// <summary>
        /// پراپرتی شهر
        /// </summary>
		[System.ComponentModel.DataAnnotations.MaxLength(50)]
        public string City { get; set; }

        /// <summary>
        /// پراپرتی استان
        /// </summary>
		[System.ComponentModel.DataAnnotations.MaxLength(75)]
        public string State { get; set; }

        /// <summary>
        /// پراپرتی کشور 
        /// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public string Country { get; set; }
    }
}


////#################################################

namespace Models
{
    /// <summary>
    /// کلاس پرسون با اتربیوت نام جدول در دیتا بیس
    /// </summary>
	[System.ComponentModel.DataAnnotations.Schema.Table("People")]
    public class Person2 : System.Object
    {
        /// <summary>
        /// سازنده پیش فرض که در آن به آی دی مقدار جی یو آی دی اعمال میگردد
        /// </summary>
		public Person2()
        {
            Id = System.Guid.NewGuid();
        }

        /// <summary>
        /// پراپرتی آی دی یا اتربیوت های مربوطه
        /// </summary>
		[System.ComponentModel.DataAnnotations.Key()]
        [System.ComponentModel.DataAnnotations.Required()]
        [System.ComponentModel.DataAnnotations.Schema.Column("PersonId")]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid Id { get; set; }

        /// <summary>
        /// پراپرتی آدرس از جنس کلاس آدرس
        /// </summary>
		public Address Address { get; set; }

        /// <summary>
        /// پراپرتی نام کامل از جنس کلاس نام کامل
        /// </summary>
		public FullName FullName { get; set; }


        /// <summary>
        /// پراپرتی توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}



////#################################################


////#################################################



//Models.DatabaseContext oDatabaseContext = null;

//			try
//			{
//				oDatabaseContext =
//					new Models.DatabaseContext();

//				Models.Person oPerson = null;

////#################################################

//oPerson = new Models.Person();

//				oPerson.FullName =
//					new Models.FullName("Dariush", "Tasdighi");

//				Models.Address oAddress =
//                    new Models.Address("Iran");

//oAddress.State = "Tehran";
//                oAddress.City = "";
//                oAddress.Country = "";

//				oPerson.Address = oAddress;

//			  //#################################################

//				oDatabaseContext.People.Add(oPerson);

//				oDatabaseContext.SaveChanges();
//			}
//			catch (System.Exception ex)
//			{
//				System.Windows.Forms.MessageBox.Show(ex.Message);
//			}
//			finally
//			{
//				if (oDatabaseContext != null)
//				{
//					oDatabaseContext.Dispose();
//					oDatabaseContext = null;
//				}
//			}
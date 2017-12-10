namespace Models
{
    //public class Person : object
    //{
    //	public Person()
    //	{
    //	}

    //	// به عنوان يک حرفه‌ای، هيچگاه از فيلد عمومی استفاده نمی‌کنيم
    //	// .تعریف می‌کنیم Property نوشته، و معادل آن یک private بلکه آن را به صورت
    //	public int Age;
    //}

    //public class Person : object
    //{
    //	public Person()
    //	{
    //	}

    //	private int _age;

    //	public int Age
    //	{
    //		get
    //		{
    //			return (_age);
    //		}
    //		set
    //		{
    //			_age = value;
    //		}
    //	}
    //}

    //public class Person : object
    //{
    //	public Person()
    //	{
    //	}

    //	private int _age;

    //	public int Age
    //	{
    //		get
    //		{
    //			return (_age);
    //		}
    //		set
    //		{
    //			if ((value >= 1) && (value <= 99))
    //			{
    //				_age = value;
    //			}
    //		}
    //	}
    //}

    /// <summary>
    ///.متناظر آن استفاده می‌کنیم property دسترسی مستقیم داریم، ولی برای دسترسی (خواندن و نوشتن) به آنها باز هم از private هر چند که در داخل کلاس به فیلدهای
    /// </summary>
    //public class Person : object
    //{
    //	public Person()
    //	{
    //	}

    //	public Person(int age)
    //	{
    //		//_age = age;

    //		//if ((age >= 1) && (age <= 99))
    //		//{
    //		//	_age = age;
    //		//}

    //		Age = age;
    //	}

    //	private int _age;

    //	public int Age
    //	{
    //		get
    //		{
    //			return (_age);
    //		}
    //		set
    //		{
    //			if ((value >= 1) && (value <= 99))
    //			{
    //				_age = value;
    //			}
    //		}
    //	}
    //}

    //public class Person : object
    //{
    //	public Person()
    //	{
    //	}

    //	public Person(int salary)
    //	{
    //		Salary = salary;

    //		_salary = salary;
    //	}

    //	private int _salary;

    //	public int Salary
    //	{
    //		get
    //		{
    //			return (_salary);
    //		}
    //	}
    //}

    //public class Person1 : object
    //{
    //    public Person1()
    //    {
    //    }

    //    public Person1(int salary)
    //    {
    //        Salary = salary;
    //    }

    //    private int _salary;

    //    public int Salary
    //    {
    //        get
    //        {
    //            return (_salary);
    //        }
    //        //private set
    //        protected set
    //        {
    //            _salary = value;
    //        }
    //    }
    //}
}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int ID { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int CountryId { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int CountryID { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	/// <summary>
	/// Note: Error On Database Creation!
	/// </summary>
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int AlakiId { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	/// <summary>
	/// Note: Error On Database Creation!
	/// </summary>
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Code { get; set; }

	//	public string Description { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "CountriesTable")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "CountryId")]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "CountryName")]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "TABLE001")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "FIELD001")]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "FIELD002")]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "Countries", Schema = "Cms")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	// Note: Does Not Work!
	//[System.ComponentModel.DataAnnotations.Schema.Table(Schema = "Cms")]
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "", Schema = "Cms")]
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: null, Schema = "Cms")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public int? Area { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required]
	//	public string Name { get; set; }

	//	public string Description { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.MaxLength
	//		(length: 50)]

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50)]

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Key]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		// Note: Wrong Usage!
	//		//Id = new System.Guid();

	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 1)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 1)]
	//	public string Name { get; set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی گردد
	//	/// </summary>
	//	public string DisplayName
	//	{
	//		get
	//		{
	//			string strResult =
	//				string.Format("{0} - {1}",
	//				Code.ToString().PadLeft(3, '0'), Name);

	//			return (strResult);
	//		}
	//	}
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public Country(string someProperty1, string someProperty2) : this()
	//	{
	//		SomeProperty1 = someProperty1;
	//		SomeProperty2 = someProperty2;
	//	}

	//	public System.Guid Id { get; set; }

	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد می‌گردد
	//	/// </summary>
	//	public string SomeProperty1 { get; private set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد می‌گردد
	//	/// </summary>
	//	public string SomeProperty2 { get; protected set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی‌گردد
    //  /// این فیلد که در بانک ذخیره نمی شود به این علت است یا get و یا set ندارد.
	//	/// </summary>
	//	public string DisplayName
	//	{
	//		get
	//		{
	//			string strResult =
	//				string.Format("{0} - {1}",
	//				Code.ToString().PadLeft(4, '_'), Name);

	//			return (strResult);
	//		}
	//	}

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی‌گردد
    //  /// بخاطر Schema.NotMapped
	//	/// </summary>
	//	[System.ComponentModel.DataAnnotations.Schema.NotMapped]
	//	public string SomeProperty3 { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	/// <summary>
	//	/// Note:
	//	/// 1. Order is Zero based!
	//	/// 2. For changing field type or field order,
	//	/// We should write the property name! (TypeName =)( Order =)
	//	/// </summary>
	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]

	//	// Note: Using TypeName is not recommended!
	//	[System.ComponentModel.DataAnnotations.Schema.Column
	//		(name: "CountryName", Order = 0, TypeName = "Char")]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	/// <summary>
	/// با تشکر از آقايان، مهدی مشايخی و حسين شريفی پناه
	/// </summary>
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Key]

	//	[System.ComponentModel.DataAnnotations.Schema.Column
	//		(Order = 0)]

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id1 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Key]

	//	[System.ComponentModel.DataAnnotations.Schema.Column
	//		(Order = 1)]

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id2 { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = true)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = false)]
	//	public string Name { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code1Code2", IsUnique = true, Order = 0)]
	//	public int Code1 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code1Code2", IsUnique = true, Order = 1)]
	//	public int Code2 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code3Code4", IsUnique = false, Order = 1)]
	//	public int Code3 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code3Code4", IsUnique = false, Order = 0)]
	//	public int Code4 { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************


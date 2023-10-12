﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace test.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitStudentEntityMappings();
		}

		/// <summary>Inits StudentEntity's mappings</summary>
		private void InitStudentEntityMappings()
		{
			this.AddElementMapping("StudentEntity", @"School", @"public", "Student", 3, 0);
			this.AddElementFieldMapping("StudentEntity", "Email", "Email", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("StudentEntity", "Id", "Id", false, "Bigint", 0, 20, 0, true, "public.Student_Id_seq", null, typeof(System.Int64), 1);
			this.AddElementFieldMapping("StudentEntity", "Name", "Name", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 2);
		}

	}
}

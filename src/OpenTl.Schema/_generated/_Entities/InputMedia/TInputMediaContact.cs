﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa6e45987)]
	public class TInputMediaContact : IInputMedia
	{
       [SerializationOrder(0)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

       [SerializationOrder(1)]
       public byte[] FirstNameAsBinary { get => _FirstNameAsBinary; set { _FirstName = Encoding.UTF8.GetString(value); _FirstNameAsBinary = value; }}
       private byte[] _FirstNameAsBinary;
       private string _FirstName;
       public string FirstName { get => _FirstName; set { FirstNameAsBinary = Encoding.UTF8.GetBytes(value); _FirstName = value; }}

       [SerializationOrder(2)]
       public byte[] LastNameAsBinary { get => _LastNameAsBinary; set { _LastName = Encoding.UTF8.GetString(value); _LastNameAsBinary = value; }}
       private byte[] _LastNameAsBinary;
       private string _LastName;
       public string LastName { get => _LastName; set { LastNameAsBinary = Encoding.UTF8.GetBytes(value); _LastName = value; }}

	}
}

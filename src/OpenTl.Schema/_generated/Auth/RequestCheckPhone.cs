﻿// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6fe51dfb)]
    public class RequestCheckPhone : IRequest<OpenTl.Schema.Auth.ICheckedPhone>
    {
       [SerializationOrder(0)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

    }
}

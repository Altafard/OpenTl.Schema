﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x86916deb)]
	public class TPasswordInputSettings : IPasswordInputSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] NewSalt {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] NewPasswordHash {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] HintAsBinary { get => _HintAsBinary; set { _Hint = Encoding.UTF8.GetString(value); _HintAsBinary = value; }}
       private byte[] _HintAsBinary;
       private string _Hint;
       public string Hint { get => _Hint; set { HintAsBinary = Encoding.UTF8.GetBytes(value); _Hint = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] EmailAsBinary { get => _EmailAsBinary; set { _Email = Encoding.UTF8.GetString(value); _EmailAsBinary = value; }}
       private byte[] _EmailAsBinary;
       private string _Email;
       public string Email { get => _Email; set { EmailAsBinary = Encoding.UTF8.GetBytes(value); _Email = value; }}

	}
}

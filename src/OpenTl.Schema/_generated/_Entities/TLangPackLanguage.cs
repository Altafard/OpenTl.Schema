﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x117698f1)]
	public class TLangPackLanguage : IObject
	{
       [SerializationOrder(0)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

       [SerializationOrder(1)]
       public byte[] NativeNameAsBinary { get => _NativeNameAsBinary; set { _NativeName = Encoding.UTF8.GetString(value); _NativeNameAsBinary = value; }}
       private byte[] _NativeNameAsBinary;
       private string _NativeName;
       public string NativeName { get => _NativeName; set { NativeNameAsBinary = Encoding.UTF8.GetBytes(value); _NativeName = value; }}

       [SerializationOrder(2)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

	}
}

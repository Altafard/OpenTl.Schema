﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd912a59c)]
	public class TTextItalic : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
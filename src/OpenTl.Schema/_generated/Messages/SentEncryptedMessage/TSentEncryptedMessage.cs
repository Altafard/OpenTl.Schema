﻿namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x560f8935)]
	public class TSentEncryptedMessage : ISentEncryptedMessage
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

	}
}
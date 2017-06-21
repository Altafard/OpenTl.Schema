﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xed18c118)]
	public class TEncryptedMessage : IEncryptedMessage
	{
       [SerializationOrder(0)]
       public long RandomId {get; set;}

       [SerializationOrder(1)]
       public int ChatId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(3)]
       public byte[] Bytes {get; set;}

       [SerializationOrder(4)]
       public IEncryptedFile File {get; set;}

	}
}
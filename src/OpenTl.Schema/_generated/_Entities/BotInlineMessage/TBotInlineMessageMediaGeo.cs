﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3a8fd8b8)]
	public class TBotInlineMessageMediaGeo : IBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

	}
}

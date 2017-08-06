﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x15a3b8e3)]
    public class RequestMigrateChat : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

    }
}

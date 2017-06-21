﻿namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x199f3a6c)]
    public class RequestInviteToChannel : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public TVector<IInputUser> Users {get; set;}

    }
}
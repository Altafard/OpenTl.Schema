﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x791451ed)]
    public class RequestSetEncryptedTyping : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public bool Typing {get; set;}

    }
}

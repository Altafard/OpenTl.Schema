﻿// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf715c87b)]
    public class RequestGetCdnFileHashes : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ICdnFileHash>>
    {
       [SerializationOrder(0)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

    }
}

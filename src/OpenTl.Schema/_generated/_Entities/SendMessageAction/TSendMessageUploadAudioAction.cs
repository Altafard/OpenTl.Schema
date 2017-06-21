﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf351d7ab)]
	public class TSendMessageUploadAudioAction : ISendMessageAction
	{
       [SerializationOrder(0)]
       public int Progress {get; set;}

	}
}
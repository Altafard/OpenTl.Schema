﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9852f9c6)]
	public class TDocumentAttributeAudio : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 10)]
       public bool Voice {get; set;}

       [SerializationOrder(2)]
       public int Duration {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] PerformerAsBinary { get => _PerformerAsBinary; set { _Performer = Encoding.UTF8.GetString(value); _PerformerAsBinary = value; }}
       private byte[] _PerformerAsBinary;
       private string _Performer;
       public string Performer { get => _Performer; set { PerformerAsBinary = Encoding.UTF8.GetBytes(value); _Performer = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public byte[] Waveform {get; set;}

	}
}
